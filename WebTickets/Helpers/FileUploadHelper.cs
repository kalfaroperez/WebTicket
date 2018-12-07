using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebTickets.ViewModels;

namespace WebTickets.Helpers
{

    public class FileHelpers
    {

        public static IConfiguration Configuration { get; set; }

        public static string GetPathFile_FichaTecnica()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

            Configuration = builder.Build();

            return Configuration.GetSection("FilesSources")["Path_Ficha_Tecnica"];

        }

        public static string GetPathFile_Ticket()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

            Configuration = builder.Build();

            return Configuration.GetSection("FilesSources")["Path_Ficha_Tecnica"];

        }

        public static async Task<string> ProcessFormFile(IFormFile formFile,
            ModelStateDictionary modelState)
        {
            var fieldDisplayName = string.Empty;

            // Use reflection to obtain the display name for the model 
            // property associated with this IFormFile. If a display
            // name isn't found, error messages simply won't show
            // a display name.
            MemberInfo property =
                typeof(FileUploadView).GetProperty(
                    formFile.Name.Substring(formFile.Name.IndexOf(".") + 1));

            if (property != null)
            {
                var displayAttribute =
                    property.GetCustomAttribute(typeof(DisplayAttribute))
                        as DisplayAttribute;

                if (displayAttribute != null)
                {
                    fieldDisplayName = $"{displayAttribute.Name} ";
                }
            }

            // Use Path.GetFileName to obtain the file name, which will
            // strip any path information passed as part of the
            // FileName property. HtmlEncode the result in case it must 
            // be returned in an error message.
            var fileName = WebUtility.HtmlEncode(
                Path.GetFileName(formFile.FileName));
            
            if (!Es_permitido(formFile.ContentType.ToLower()))
            {
                string tiposSoportados = "";
                foreach (var item in mimeTypes)
                {
                    tiposSoportados += item.Key +", ";
                }
                modelState.AddModelError(formFile.Name,
                    $"El archivo {fieldDisplayName} ({fileName}) no es un archivo valido. " +
                    $"Solo se permiten los siguientes tipos de archivos: "+ tiposSoportados);
            }

            // Check the file length and don't bother attempting to
            // read it if the file contains no content. This check
            // doesn't catch files that only have a BOM as their
            // content, so a content length check is made later after 
            // reading the file's content to catch a file that only
            // contains a BOM.
            if (formFile.Length == 0)
            {
                modelState.AddModelError(formFile.Name,
                    $"El archivo {fieldDisplayName} ({fileName}) está vacio. El arivo no puede ser vacio.");
            }
            else if (formFile.Length > 10485760)
            {
                modelState.AddModelError(formFile.Name,
                    $"El archivo {fieldDisplayName} ({fileName}) excede el tamaño maximo permitido(10 MB.)");
            }
            else
            {
                try
                {
                    string fileContents;

                    // The StreamReader is created to read files that are UTF-8 encoded. 
                    // If uploads require some other encoding, provide the encoding in the 
                    // using statement. To change to 32-bit encoding, change 
                    // new UTF8Encoding(...) to new UTF32Encoding().
                    using (
                        var reader =
                            new StreamReader(
                                formFile.OpenReadStream(),
                                detectEncodingFromByteOrderMarks: true))
                    {
                        fileContents = await reader.ReadToEndAsync();

                        // Check the content length in case the file's only
                        // content was a BOM and the content is actually
                        // empty after removing the BOM.
                        if (fileContents.Length > 0)
                        {
                            return fileContents;
                        }
                        else
                        {
                            modelState.AddModelError(formFile.Name,
                                $"El archivo {fieldDisplayName} ({fileName}) está vacio, no puede ser vacio.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    modelState.AddModelError(formFile.Name,
                        $"El archivo {fieldDisplayName} ({fileName}) no se ha podido subir con exito. " +
                        $"Por favor contacte al Administrador del sistema. Error: {ex.Message}");
                    // Log the exception
                }
            }

            return string.Empty;
        }

        public static string GetContentType(string path)
        {
            var types = GetMimeTypes();
            var ext = Path.GetExtension(path).ToLowerInvariant();
            return types[ext];
        }

        private static Dictionary<string, string> mimeTypes = new Dictionary<string, string>
            {
                {".txt", "text/plain"},
                {".pdf", "application/pdf"},
                {".doc", "application/vnd.ms-word"},
                {".docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document"},
                {".xls", "application/vnd.ms-excel"},
                {".xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"},
                {".png", "image/png"},
                {".jpg", "image/jpeg"},
                {".jpeg", "image/jpeg"},
                {".gif", "image/gif"},
                {".csv", "text/csv"}
            };

        public static Dictionary<string, string> GetMimeTypes()
        {
            return mimeTypes;
        }

        public static bool Es_permitido(string file_ext)
        {
            bool existe = mimeTypes.ContainsValue(file_ext);
            if (!existe)
            {
                return false;
            }
            return true;
        }
    }
}
