namespace WebTickets.Helpers
{
    public enum Role
    {
        Administrador,
        Operador
    }

    public static class RoleExtensions
    {
        public static string GetRoleName(this Role role) // convenience method
        {
            return role.ToString();
        }
    }
}
