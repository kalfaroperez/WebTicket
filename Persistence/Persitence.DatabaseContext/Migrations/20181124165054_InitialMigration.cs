using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.DatabaseContext.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Estado = table.Column<int>(nullable: false),
                    Insert_Oper = table.Column<string>(nullable: true),
                    Insert_Datetime = table.Column<DateTime>(nullable: false),
                    Update_Oper = table.Column<string>(nullable: true),
                    Update_Datetime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Enabled = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    FullName = table.Column<string>(nullable: true),
                    Area = table.Column<string>(nullable: true),
                    Ubicacion = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    Extension = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Componentes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Estado = table.Column<bool>(nullable: false),
                    Insert_Oper = table.Column<string>(nullable: true),
                    Insert_Datetime = table.Column<DateTime>(nullable: false),
                    Update_Oper = table.Column<string>(nullable: true),
                    Update_Datetime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Componentes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EMailError",
                columns: table => new
                {
                    IdEmailError = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FromName = table.Column<string>(nullable: true),
                    FromEMail = table.Column<string>(nullable: true),
                    ToName = table.Column<string>(nullable: true),
                    ToEMail = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    ErrorMessage = table.Column<string>(nullable: true),
                    FechaInsercion = table.Column<DateTime>(nullable: false),
                    FechaModificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMailError", x => x.IdEmailError);
                });

            migrationBuilder.CreateTable(
                name: "EquipoPrincipal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Estado = table.Column<bool>(nullable: false),
                    Insert_Oper = table.Column<string>(nullable: true),
                    Insert_Datetime = table.Column<DateTime>(nullable: false),
                    Update_Oper = table.Column<string>(nullable: true),
                    Update_Datetime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipoPrincipal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EquipoSecundario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Estado = table.Column<bool>(nullable: false),
                    Insert_Oper = table.Column<string>(nullable: true),
                    Insert_Datetime = table.Column<DateTime>(nullable: false),
                    Update_Oper = table.Column<string>(nullable: true),
                    Update_Datetime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipoSecundario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstadoServicio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    FechaInsercion = table.Column<DateTime>(nullable: true),
                    FechaModificacion = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoServicio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistorialPassword",
                columns: table => new
                {
                    Id_Historial_Password = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Usuario = table.Column<int>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    InsertDatetime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialPassword", x => x.Id_Historial_Password);
                });

            migrationBuilder.CreateTable(
                name: "Operador",
                columns: table => new
                {
                    IdOperador = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OperadorId = table.Column<string>(nullable: true),
                    ApeYNom = table.Column<string>(nullable: true),
                    SectorId = table.Column<string>(nullable: true),
                    EMail = table.Column<string>(nullable: true),
                    Contrasenia = table.Column<string>(nullable: true),
                    Privado = table.Column<int>(nullable: false),
                    Nivel = table.Column<sbyte>(nullable: false),
                    ExpiraClave = table.Column<DateTime>(nullable: false),
                    AvisarAsignado = table.Column<int>(nullable: false),
                    AvisarSolicitud = table.Column<int>(nullable: false),
                    InsertOper = table.Column<string>(nullable: true),
                    InsertDatetime = table.Column<DateTime>(nullable: false),
                    UpdateOper = table.Column<string>(nullable: true),
                    UpdateDatetime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operador", x => x.IdOperador);
                });

            migrationBuilder.CreateTable(
                name: "Parametros",
                columns: table => new
                {
                    ParametrosId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ValidezPsw = table.Column<ushort>(nullable: false),
                    DiasPsw = table.Column<ushort>(nullable: false),
                    MaxLinesScreen = table.Column<ushort>(nullable: false),
                    MaxLinesExport = table.Column<uint>(nullable: false),
                    MaxDifMin = table.Column<ushort>(nullable: false),
                    MaxAttach = table.Column<uint>(nullable: false),
                    AssignTicket = table.Column<int>(nullable: false),
                    FromUserRequest = table.Column<string>(nullable: true),
                    SubcarpetaAdjuntoTicket = table.Column<string>(nullable: true),
                    SubcarpetaAdjuntoFichaTec = table.Column<string>(nullable: true),
                    FromUserPsw = table.Column<string>(nullable: true),
                    ContactDefault = table.Column<string>(nullable: true),
                    ProcessDefault = table.Column<string>(nullable: true),
                    StateDefault = table.Column<string>(nullable: true),
                    StateAlert = table.Column<string>(nullable: true),
                    MainScreenState = table.Column<string>(nullable: true),
                    DateFormat = table.Column<string>(nullable: true),
                    Pen = table.Column<string>(nullable: true),
                    Pas = table.Column<string>(nullable: true),
                    Can = table.Column<string>(nullable: true),
                    InsertOper = table.Column<string>(nullable: true),
                    InsertDatetime = table.Column<DateTime>(nullable: false),
                    UpdateOper = table.Column<string>(nullable: true),
                    UpdateDatetime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametros", x => x.ParametrosId);
                });

            migrationBuilder.CreateTable(
                name: "Planta",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Estado = table.Column<bool>(nullable: false),
                    Insert_Oper = table.Column<string>(nullable: true),
                    Insert_Datetime = table.Column<DateTime>(nullable: false),
                    Update_Oper = table.Column<string>(nullable: true),
                    Update_Datetime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prioridad",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre_Prioridad = table.Column<string>(nullable: true),
                    Fecha_Insercion = table.Column<DateTime>(nullable: true),
                    Fecha_Modificacion = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prioridad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Procesos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre_Proceso = table.Column<string>(nullable: true),
                    Fecha_Insercion = table.Column<DateTime>(nullable: true),
                    Fecha_Modificacion = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procesos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegistroEquipo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdPlanta = table.Column<int>(nullable: false),
                    NombrePlanta = table.Column<string>(nullable: true),
                    IdEquipoPrinc = table.Column<int>(nullable: false),
                    NombreEquipoPrinc = table.Column<string>(nullable: true),
                    IdEquipoSec = table.Column<int>(nullable: true),
                    NombreEquipoSec = table.Column<string>(nullable: true),
                    IdComponente = table.Column<int>(nullable: true),
                    NombreComponente = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroEquipo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SigoTicket",
                columns: table => new
                {
                    SeqSigoTicketId = table.Column<ulong>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SeqTicketId = table.Column<uint>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    OperadorId = table.Column<string>(nullable: true),
                    UsuarioId = table.Column<string>(nullable: true),
                    CampoCambiado = table.Column<string>(nullable: true),
                    ValorAnterior = table.Column<string>(nullable: true),
                    ValorActual = table.Column<string>(nullable: true),
                    Comentario = table.Column<string>(nullable: true),
                    Visible = table.Column<int>(nullable: false),
                    Adjunto = table.Column<byte[]>(nullable: true),
                    TipoAdjunto = table.Column<string>(nullable: true),
                    NombreAdjunto = table.Column<string>(nullable: true),
                    InsertOper = table.Column<string>(nullable: true),
                    InsertUser = table.Column<string>(nullable: true),
                    InsertDatetime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SigoTicket", x => x.SeqSigoTicketId);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id = table.Column<ulong>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Numero_Ticket = table.Column<string>(nullable: true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Privado = table.Column<int>(nullable: false),
                    Operador_Id = table.Column<string>(nullable: true),
                    Operador_Sector_Id = table.Column<string>(nullable: true),
                    Usuario_Id = table.Column<string>(nullable: true),
                    Nombre_completo = table.Column<string>(nullable: true),
                    Area_Id = table.Column<string>(nullable: true),
                    Piso = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    EMail = table.Column<string>(nullable: true),
                    Asignado_A = table.Column<string>(nullable: true),
                    Asignado_A_Sector = table.Column<string>(nullable: true),
                    Prioridad = table.Column<byte>(nullable: false),
                    Incidente = table.Column<string>(nullable: true),
                    Proceso = table.Column<string>(nullable: true),
                    Tipo_Trabajo = table.Column<string>(nullable: true),
                    Id_Planta = table.Column<string>(nullable: true),
                    Id_EquipoPrinc = table.Column<string>(nullable: true),
                    Id_EquipoSec = table.Column<string>(nullable: true),
                    Id_Componente = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    Calificacion = table.Column<string>(nullable: true),
                    Fecha_Ultimo_Estado = table.Column<DateTime>(nullable: false),
                    Fecha_Entrega = table.Column<DateTime>(nullable: true),
                    Operador_Ultimo_Estado = table.Column<string>(nullable: true),
                    Adjunto = table.Column<byte[]>(nullable: true),
                    Tipo_Adjunto = table.Column<string>(nullable: true),
                    Ruta_Adjunto = table.Column<string>(nullable: true),
                    Nombre_Adjunto = table.Column<string>(nullable: true),
                    Insert_Oper = table.Column<string>(nullable: true),
                    Insert_Datetime = table.Column<DateTime>(nullable: false),
                    Update_Oper = table.Column<string>(nullable: true),
                    Update_Datetime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoTrabajo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Estado = table.Column<bool>(nullable: false),
                    Fecha_Insercion = table.Column<DateTime>(nullable: false),
                    Fecha_Modificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoTrabajo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreCompleto = table.Column<string>(nullable: true),
                    EMail = table.Column<string>(nullable: true),
                    Ubicacion = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    AreaId = table.Column<int>(nullable: false),
                    Activo = table.Column<int>(nullable: false),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    CambioClave = table.Column<int>(nullable: false),
                    FechaRegistro = table.Column<DateTime>(nullable: false),
                    FechaModificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Area");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Componentes");

            migrationBuilder.DropTable(
                name: "EMailError");

            migrationBuilder.DropTable(
                name: "EquipoPrincipal");

            migrationBuilder.DropTable(
                name: "EquipoSecundario");

            migrationBuilder.DropTable(
                name: "EstadoServicio");

            migrationBuilder.DropTable(
                name: "HistorialPassword");

            migrationBuilder.DropTable(
                name: "Operador");

            migrationBuilder.DropTable(
                name: "Parametros");

            migrationBuilder.DropTable(
                name: "Planta");

            migrationBuilder.DropTable(
                name: "Prioridad");

            migrationBuilder.DropTable(
                name: "Procesos");

            migrationBuilder.DropTable(
                name: "RegistroEquipo");

            migrationBuilder.DropTable(
                name: "SigoTicket");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "TipoTrabajo");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
