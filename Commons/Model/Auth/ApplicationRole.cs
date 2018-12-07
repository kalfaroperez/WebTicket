using Microsoft.AspNetCore.Identity;

namespace Model.Auth
{
    public class ApplicationRole : IdentityRole
    {
        public bool Enabled { set; get;  }

    }
}
