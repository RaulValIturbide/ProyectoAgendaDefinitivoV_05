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
        private Contacto _Contacto = new Contacto();
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

        private void BindeoManual()
        {
            txtNombre.Text = _Contacto.Nombre;
            txtApellidos.Text = _Contacto.Apellidos;
            txtEmail.Text = _Contacto.Email;
            imgContacto.Image = _Contacto.imagen;
        }
        #endregion

        #region EVENTOS

        private void btnMasInfo_Click(object sender, EventArgs e)
        {
            MostrarInfoContacto mostrarInfo = new MostrarInfoContacto( _Contacto);

            if (mostrarInfo.ShowDialog() == DialogResult.OK)
            {
                BindeoManual();
            }
        }
        
        #endregion
    }
}
