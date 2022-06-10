using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace semiSenior.Models
{
    public partial class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Genero { get; set; }
        public string Edad { get; set; }
        public string EstadoCivil { get; set; }
        public string Email { get; set; }
        public string CantidadHijos { get; set; }
        public string Documento { get; set; }
    }
}
