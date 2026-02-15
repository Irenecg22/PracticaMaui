using System;
using System.Collections.Generic;
using System.Text;

namespace MauiPractica.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Puesto { get; set; }
        public string Image_uri { get; set; }
        public Departamento Departamento { get; set; } 
        public int Departamento_id { get; set; }
       
        
    }
}
