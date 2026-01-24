using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class Contacto
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public List<string> ListaTelefonos { get; set; } = new List<string>();
        public Image imagen { get; set; }

        public Resultado ValidarDatos()
        {
            Resultado res = new Resultado();
            StringBuilder mensajero = new StringBuilder();
            int contadorError = 0;

            if (string.IsNullOrEmpty(Nombre) || string.IsNullOrWhiteSpace(Nombre))
            {
                contadorError++;
                res.CodigoError = 101;
                mensajero.AppendLine($"{contadorError}-Rellena el campo 'Nombre'");
            }

            if (string.IsNullOrEmpty(Apellidos) || string.IsNullOrWhiteSpace(Apellidos))
            {
                contadorError++;
                res.CodigoError = 102;
                mensajero.AppendLine($"{contadorError}-Rellena el campo 'Apellidos'");
            }

            if (res.CodigoError != 0)
            {
                res.MensajeResultado = $"Comprueba los siguientes campos:{Environment.NewLine}{mensajero.ToString()}";
            }
            return res;
        }
    }
}
