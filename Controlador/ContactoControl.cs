using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlador
{
    public partial class ContactoControl: UserControl
    {
        public ContactoControl()
        {
            InitializeComponent();
            BarraBotonesPrincipal.ClickMasInfo += btnMasInfo_Click; //Agregamos el evento al click original
            EstablecerAspectoFormulario(EstadoEnum.Consulta);
        }

        #region MetodosPrivados


        /// <summary>
        /// Establece un aspecto visual del formulario
        /// </summary>
        /// <param name="estadoEnum"></param>
        private void EstablecerAspectoFormulario(EstadoEnum estadoEnum)
        {
            switch (estadoEnum)
            {
                case EstadoEnum.Consulta:
                    //BarraBotones
                   BarraBotonesPrincipal.VisibilidadGuardar = false;
                   BarraBotonesPrincipal.VisibilidadPermitirModificar = false;
                   BarraBotonesPrincipal.VisibilidadMasInfo = true;

                    txtNombre.Enabled = false;
                    txtApellidos.Enabled = false;
                    txtEmail.Enabled = false;
                    break;                   
            }
        }
        #endregion

        #region EVENTOS

        private void btnMasInfo_Click(object sender, EventArgs e)
        {
            MostrarInfoContacto mostrarInfo = new MostrarInfoContacto();
            mostrarInfo.ShowDialog();
        }
        
        #endregion
    }
}
