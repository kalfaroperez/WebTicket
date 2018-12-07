using Common;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

namespace Model.Auth
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        public int Area { get; set; }
        public string Ubicacion { get; set; }
        public string Telefono { get; set; }
        public string Extension { get; set; }

    }
}
