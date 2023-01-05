using Proyecto_POO_A.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Schema;

namespace Proyecto_POO_A.Controllers
{
    //El patron utilizado en este proyecto es MVC la cual sea creo a partir de una plantilla ASP.net a esta le hemos agregado las funciones que necesita nuestra aplicacion de acuerdo a la arquitectura del mismo
    //Este es un controlador la cual permite al usuario interactuar con la aplicacion de acuerdo a cada funcion que sea solicitada
    public class HomeController : Controller
    {
        // Botones de la interfaz
        //Index es la pagina principal que observamos en la vista
        public ActionResult Index()
        {
            return View();
        }
        //About es un una funcion que permite obtener informacion adicional de la aplicacion
        public ActionResult About()
        {
            return View();
        }

        //Creacion de la lista que se utiliza para trabahar en las funciones propuestas
        public static List<Persona> Empleados = new List<Persona>
        {
                    new Persona
                    {
                        ID=1,
                        Nombre="Marquez Mar Gallardo",
                        Numero=0927632364,
                        Correo="hola1@gmail.com",
                        Trabajo="Ingeniero en sistemas",
                        Sueldo=3000,
                        FechaModificacion=DateTime.Parse(DateTime.Today.ToString()),
                        HorasTrabajadas=240,
                        SueldoHora=13,
                        Total=0,
                        Rendimiento="Vacio",

                    },
                    new Persona
                    {
                        ID=2,
                        Nombre="Andres Acuña Sanchez",
                        Numero=0997612163,
                        Correo="hola2@gmail.com",
                        Trabajo="Ingeniero en sistemas",
                        Sueldo=3000,
                        FechaModificacion=DateTime.Parse(DateTime.Today.ToString()),
                        HorasTrabajadas=166,
                        SueldoHora=13,
                        Total=0,
                        Rendimiento="Vacio",
                    },
                    new Persona
                    {
                        ID=3,
                        Nombre="Marco Guerrilla Gimenez",
                        Numero=0913284348,
                        Correo="hola3@gmail.com",
                        Trabajo="Ingenieria en software",
                        Sueldo=2000,
                        FechaModificacion=DateTime.Parse(DateTime.Today.ToString()),
                        HorasTrabajadas=200,
                        SueldoHora=10,
                        Total=0,
                        Rendimiento="Vacio",
                    },
                    new Persona
                    {
                        ID=4,
                        Nombre="Silvia Arroyo Velasquez",
                        Numero=0982145623,
                        Correo="hola4@gmail.com",
                        Trabajo="Ingenieria en software",
                        Sueldo=2000,
                        FechaModificacion=DateTime.Parse(DateTime.Today.ToString()),
                        HorasTrabajadas=220,
                        SueldoHora=10,
                        Total=0,
                        Rendimiento="Vacio",
                    },
                    new Persona
                    {
                        ID=5,
                        Nombre="Blas Yague Green",
                        Numero=0990983622,
                        Correo="hola5@gmail.com",
                        Trabajo="Ingenieria en software",
                        Sueldo=2000,
                        FechaModificacion=DateTime.Parse(DateTime.Today.ToString()),
                        HorasTrabajadas=100,
                        SueldoHora=10,
                        Total=0,
                        Rendimiento="Vacio",
                    },
                    new Persona
                    {
                        ID=6,
                        Nombre="Pablo Loor Correa",
                        Numero=0997612163,
                        Correo="hola6@gmail.com",
                        Trabajo="Ingenieria en software",
                        Sueldo=2000,
                        FechaModificacion=DateTime.Parse(DateTime.Today.ToString()),
                        HorasTrabajadas=120,
                        SueldoHora=10,
                        Total=0,
                        Rendimiento="Vacio",
                    },
                    new Persona
                    {
                       ID=7,
                        Nombre="Marco Antonio Gimenez",
                        Numero=0913284348,
                        Correo="hola7@gmail.com",
                        Trabajo="Ingenieria en software",
                        Sueldo=2000,
                        FechaModificacion=DateTime.Parse(DateTime.Today.ToString()),
                        HorasTrabajadas=250,
                        SueldoHora=10,
                        Total=0,
                        Rendimiento="Vacio",
                    },
                    new Persona
                    {
                        ID=8,
                        Nombre="Silvia Arroyo Velasquez",
                        Numero=0982145623,
                        Correo="hola8@gmail.com",
                        Trabajo="Ingenieria en software",
                        Sueldo=2000,
                        FechaModificacion=DateTime.Parse(DateTime.Today.ToString()),
                        HorasTrabajadas=300,
                        SueldoHora=10,
                        Total=0,
                        Rendimiento="Vacio",
                    },
                    new Persona
                    {
                        ID=9,
                        Nombre="Jose Pedro Camps",
                        Numero=0967233255,
                        Correo="hola9@gmail.com",
                        Trabajo="Personal de Limpieza",
                        Sueldo=1000,
                        FechaModificacion=DateTime.Parse(DateTime.Today.ToString()),
                        HorasTrabajadas=210,
                        SueldoHora=5,
                        Total=0,
                        Rendimiento="Vacio",
                    },
                     new Persona
                    {
                        ID=10,
                        Nombre="Ana Maria Lora",
                        Numero=0948892111,
                        Correo="hola10@gmail.com",
                        Trabajo="Personal de Limpieza",
                        Sueldo=1000,
                        FechaModificacion=DateTime.Parse(DateTime.Today.ToString()),
                        HorasTrabajadas=190,
                        SueldoHora=5,
                        Total=0,
                        Rendimiento="Vacio",
                    },               
                    new Persona
                    {
                        ID=11,
                        Nombre="Cristina Maria Parrilla",
                        Numero=0953459821,
                        Correo="hola11@gmail.com",
                        Trabajo="Personal de limpieza",
                        Sueldo=1000,
                        FechaModificacion=DateTime.Parse(DateTime.Today.ToString()),
                        HorasTrabajadas=200,
                        SueldoHora=5,
                        Total=0,
                        Rendimiento="Vacio",
                    },
                    new Persona
                    {
                        ID=12,
                        Nombre="Maria Teresa Fernandez",
                        Numero=0934734872,
                        Correo="hola12@gmail.com",
                        Trabajo="Personal de Limpieza",
                        Sueldo=1000,
                        FechaModificacion=DateTime.Parse(DateTime.Today.ToString()),
                        HorasTrabajadas=140,
                        SueldoHora=5,
                        Total=0,
                        Rendimiento="Vacio",
                    },
                    new Persona
                    {
                        ID=13,
                        Nombre="Antonio Javier Anton",
                        Numero=0945687897,
                        Correo="hola13@gmail.com",
                        Trabajo="Personal de Limpieza",
                        Sueldo=1000,
                        FechaModificacion=DateTime.Parse(DateTime.Today.ToString()),
                        HorasTrabajadas=300,
                        SueldoHora=5,
                        Total=0,
                        Rendimiento="Vacio",
                    },
                    new Persona
                    {
                        ID=14,
                        Nombre="Blas Yague Green",
                        Numero=0932637263,
                        Correo="hola14@gmail.com",
                        Trabajo="Ingenieria en tecnologias de la informacion",
                        Sueldo=5000,
                        FechaModificacion=DateTime.Parse(DateTime.Today.ToString()),
                        HorasTrabajadas=240,
                        SueldoHora=21,
                        Total=0,
                        Rendimiento="Vacio",
                    },
                    new Persona
                    {
                        ID=15,
                        Nombre="Pedro Parraga Vico",
                        Numero=0912374982,
                        Correo="hola15@gmail.com",
                        Trabajo="Ingenieria en tecnologias de la informacion",
                        Sueldo=5000,
                        FechaModificacion=DateTime.Parse(DateTime.Today.ToString()),
                        HorasTrabajadas=290,
                        SueldoHora=21,
                        Total=0,
                        Rendimiento="Vacio",
                    },
                    new Persona
                    {
                        ID=16,
                        Nombre="Maria Vera Segarra",
                        Numero=0912361899,
                        Correo="hola16@gmail.com",
                        Trabajo="Ingenieria en tecnologias de la informacion",
                        Sueldo=5000,
                        FechaModificacion=DateTime.Parse(DateTime.Today.ToString()),
                        HorasTrabajadas=190,
                        SueldoHora=21,
                        Total=0,
                        Rendimiento="Vacio",
                    },
                    new Persona
                    {
                        ID=17,
                        Nombre="Abel Prados Wood",
                        Numero=0985378181,
                        Correo="hola17@gmail.com",
                        Trabajo="Ingenieria en tecnologias de la informacion",
                        Sueldo=5000,
                        FechaModificacion=DateTime.Parse(DateTime.Today.ToString()),
                        HorasTrabajadas=200,
                        SueldoHora=21,
                        Total=0,
                        Rendimiento="Vacio",
                    },
                    new Persona
                    {
                        ID=18,
                        Nombre="Maria Gema Vizcaino",
                        Numero=0975487363,
                        Correo="hola18@gmail.com",
                        Trabajo="Ingenieria en tecnologias de la informacion",
                        Sueldo=5000,
                        FechaModificacion=DateTime.Parse(DateTime.Today.ToString()),
                        HorasTrabajadas=100,
                        SueldoHora=21,
                        Total=0,
                        Rendimiento="Vacio",
                    },
                    new Persona
                    {
                        ID=19,
                        Nombre="Fabricio Uber Berenguer",
                        Numero=0923662372,
                        Correo="hola19@gmail.com",
                        Trabajo="Ingenieria en tecnologias de la informacion",
                        Sueldo=5000,
                        FechaModificacion=DateTime.Parse(DateTime.Today.ToString()),
                        HorasTrabajadas=110,
                        SueldoHora=21,
                        Total=0,
                        Rendimiento="Vacio",
                    },
                    new Persona
                    {
                        ID=20,
                        Nombre="Antonio Xav Roca",
                        Numero=0979922651,
                        Correo="hola20@gmail.com",
                        Trabajo="Ingenieria en tecnologias de la informacion",
                        Sueldo=5000,
                        FechaModificacion=DateTime.Parse(DateTime.Today.ToString()),
                        HorasTrabajadas=260,
                        SueldoHora=21,
                        Total=0,
                        Rendimiento="Vacio",
                    },
        };

        //Esta funcion permite mostrar la lista en la vista del usuario
        public ActionResult ObtenerEmpleados()
        {
            List<Persona> lista = Empleados;
            var Persona = from a in Empleados
                          orderby a.ID
                          select a;
            return View(Persona);
        }

        //Estas funciones permiten al usuario editar los datos solicitados
        public ActionResult Editar(int ID)
        {
            List<Persona> EditarPersona = Empleados;
            var Persona = EditarPersona.Single(a => a.ID == ID);
            return View(Persona);
        }

        [HttpPost]
        public ActionResult Editar(int ID, FormCollection collection)
        {
            var Persona = Empleados.Single(a => a.ID == ID);
            if (TryUpdateModel(Persona))
                return RedirectToAction("ObtenerEmpleados");
            return View(Persona);

        }

        //La siguiente funcion calcula el sueldo de cada empleado y su rendimiento de acuerdo al mismo junto a cada condicion
        public ActionResult CalcularSueldo()
        {
            List<Persona> CalcularSueldo = Empleados;
            foreach (var Calcular in Empleados)
            {
                Calcular.Total=Calcular.HorasTrabajadas*Calcular.SueldoHora;
                if(Calcular.ID>=1 && Calcular.ID <= 2)
                {
                    if (Calcular.Total>=3000)
                    {
                        Calcular.Rendimiento = "Exelente";
                    }
                    else if (Calcular.Total >= 1500)
                    {
                        Calcular.Rendimiento = "Bueno";
                    }
                    else if (Calcular.Total <= 500)
                    {
                        Calcular.Rendimiento = "Malo";
                    }
                }
                if (Calcular.ID >= 3 && Calcular.ID <= 13)
                {
                    if (Calcular.Total >= 2000)
                    {
                        Calcular.Rendimiento = "Exelente";
                    }
                    else if (Calcular.Total >= 1000)
                    {
                        Calcular.Rendimiento = "Bueno";
                    }
                    else if (Calcular.Total <= 500)
                    {
                        Calcular.Rendimiento = "Malo";
                    }
                }
                if (Calcular.ID >= 9 && Calcular.ID <= 13)
                {
                    if (Calcular.Total >= 1000)
                    {
                        Calcular.Rendimiento = "Exelente";
                    }
                    else if (Calcular.Total >= 500)
                    {
                        Calcular.Rendimiento = "Bueno";
                    }
                    else if (Calcular.Total <= 300)
                    {
                        Calcular.Rendimiento = "Malo";
                    }
                }
                if (Calcular.ID >= 14 && Calcular.ID <= 20)
                {
                    if (Calcular.Total >= 5000)
                    {
                        Calcular.Rendimiento = "Exelente";
                    }
                    else if (Calcular.Total >= 2500)
                    {
                        Calcular.Rendimiento = "Bueno";
                    }
                    else if (Calcular.Total >= 2000)
                    {
                        Calcular.Rendimiento = "Malo";
                    }
                }
            }
            var Persona = from a in Empleados
                          orderby a.ID
                          select a;
            return View(Persona);
        }

        //Este metodo permite buscar un empleado mediante sus nombres
        public ActionResult BuscarEmpleado(string buscar)
        {
            var Persona = from a in Empleados orderby a.ID select a;

            var Usuario = from usuario in Persona select usuario;

            if (!String.IsNullOrEmpty(buscar))
            {
                Usuario = Usuario.Where(s => s.Nombre.Contains(buscar));
            }
            return View(Usuario);
        }
    }
 }

//Toda esta informacion es enviada a las respectivas vistas en la caroeta views mostrando al usuario lo solicitado al momento
