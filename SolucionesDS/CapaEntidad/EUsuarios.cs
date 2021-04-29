namespace CapaEntidad
{
    public class EUsuarios
    {
        public short IdUsuario { get; set; }
        public short IdSociedad { get; set; }
        public short IdPerfil { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Alias { get; set; }
        public string Email { get; set; }
        public string ListaPrecio { get; set; }
        public string ImpuestoIVA { get; set; }
        public char AccesoRapido { get; set; }
        public char Activo { get; set; }
    }
}
