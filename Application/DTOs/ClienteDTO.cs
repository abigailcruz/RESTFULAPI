﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs
{
    public class ClienteDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string DUI { get; set; }
        public string NIT { get; set; }
        
    }
}
