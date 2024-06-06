using GestLab.Models;

namespace GestLab.Shared
{
    public static class Constantes
    {
        public const string SessionKeyID = "_Id";
        public const string SessionKeyNome = "_Nome";
        public const string SessionKeyEmail = "_Email";
        public const string SessionKeyTipo = "_Tipo";

        public const string PerfilAdm = "Administrador";
        public const string PerfilMontador = "Montador";
        public const string PerfilCliente = "Cliente";

        public static UsuarioModel UsuarioModel { get; set; }
    }
}
