using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_POO_A.Models
{
    //Modelo que se utiliza para crear un empleado
    public class Persona
    {
        public int ID {get;set;}
        public String Nombre {get;set;}
        public int Numero {get;set;}
        public String Correo {get;set;}
        public String Trabajo {get;set;}
        public int Sueldo {get;set;}
        public DateTime FechaModificacion {get;set;}
        public int HorasTrabajadas {get;set;}
        public int SueldoHora {get;set;}
        public int Total {get;set;}
        public String Rendimiento { get; set; }
        public String Usuario{ get; set; }

    }
}