using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ///Demostración de como cargar un contacto por parámetros:

            //Creamos el contacto:
            //Contacto contacto = new Contacto() { Nombre = "Pedro", Apellidos = "Bautista" };

            //Lo añadimos a el componente a través del metodo público "CargarContacto"
            //ContactoPrimero.CargarContacto(contacto);

            ///Demostración de como recuperar un contacto de un componente

           // if (!string.IsNullOrEmpty(contacto.Nombre) && contacto.Nombre.StartsWith("A")) 
           // { 
           // Console.WriteLine("El nombre de este contacto comienza por la letra 'A'");
           // }

        }
    }
}
