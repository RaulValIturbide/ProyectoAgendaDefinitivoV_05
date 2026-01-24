using Controlador.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlador
{
    public partial class MostrarResultado : Form
    {

        /// <summary>
        /// Constructor para mostrar un mensaje
        /// </summary>
        /// <param name="mensaje"></param>
        public MostrarResultado(string mensaje)
        {
            InitializeComponent();
            picBox.Image = Resources.correcto;
            lbCodigoError.Text = "";
            lbMostrarErrores.Text = mensaje;
        }

        /// <summary>
        /// Constructor para mostrar un error
        /// </summary>
        /// <param name="res"></param>
        public MostrarResultado(Resultado res) 
        {
            InitializeComponent();
            picBox.Image = Resources.error;
            lbCodigoError.Text = $"ERROR: {res.CodigoError.ToString()}";
            lbMostrarErrores.Text = res.MensajeResultado;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
