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
    public partial class MostrarInfoContacto : Form
    {
        public MostrarInfoContacto()
        {
            InitializeComponent();
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog op = new OpenFileDialog())
            {
                op.Title = "Selecciona una Imagen";
                op.Filter = "Imágenes|*.jpg;*.png;*.jpeg";

                if (op.ShowDialog() == DialogResult.OK)
                {
                    string rutaArchivo = op.FileName;
                    imgContacto.Image = Image.FromFile(rutaArchivo);
                }
            }
        }
    }
    
}
