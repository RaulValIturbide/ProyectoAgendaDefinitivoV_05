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

            EstablecerAspectoFormulario(EstadoEnum.Consulta);

            BarraBotonesPrincipal.ClickGuardar += btnGuardar_Click;
            BarraBotonesPrincipal.ClickPermitirModificar += btnPermitirModificar_Click;
        }

        #region METODOS PRIVADOS
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

        private void EstablecerAspectoFormulario(EstadoEnum estadoEnum)
        {
            switch (estadoEnum)
            {
                case EstadoEnum.Edicion:
                    BarraBotonesPrincipal.VisibilidadMasInfo = false;
                    BarraBotonesPrincipal.VisibilidadPermitirModificar = false;
                    BarraBotonesPrincipal.VisibilidadGuardar = true;

                    btnAddImage.Visible = true;
                    tbInfo.Enabled = true;
                    break;
                case EstadoEnum.Consulta:

                    BarraBotonesPrincipal.VisibilidadMasInfo = false;
                    BarraBotonesPrincipal.VisibilidadPermitirModificar = true;
                    BarraBotonesPrincipal.VisibilidadGuardar = false;

                    tbInfo.Enabled = false;
                    btnAddImage.Visible = false;
                    break;
            }
        }
        #endregion

        #region EVENTOS
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EstablecerAspectoFormulario(EstadoEnum.Consulta);
        }
        private void btnPermitirModificar_Click(object sender, EventArgs e)
        {
            EstablecerAspectoFormulario(EstadoEnum.Edicion);
        }
        #endregion

        private void btnAddTelefono_Click(object sender, EventArgs e)
        {
            tbInfo.RowCount++;

            Label lb = new Label();
            lb.Text = $"TELEFONO {tbInfo.RowCount - 3}";
            lb.Font = new Font("MV Boli", (float)9.5, FontStyle.Regular);

            tbInfo.Controls.Add(lb, 0, tbInfo.RowCount - 1);

        }
        
    }

}
