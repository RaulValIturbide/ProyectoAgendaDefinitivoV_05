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

        #region Metodos Publicos

        /// <summary>
        /// Devuelve el objero contacto del componente
        /// </summary>
        /// <returns></returns>
        public Contacto DevolverContacto()
        {
            return _Contacto;
        }
        /// <summary>
        /// Agrega un contacto al componente por parametros
        /// </summary>
        /// <param name="c"></param>
        public void CargarContacto(Contacto c)
        {
            this._Contacto = c;
            BindeoManual();
        }
        #endregion
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

        //Metodo para añadir un datacontext Objeto => Visual pero de manera manual
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
            mostrarInfo.Text = $"Contacto {_Contacto.Nombre} {_Contacto.Apellidos}";
            if (mostrarInfo.ShowDialog() == DialogResult.OK)
            {
                BindeoManual();
            }
        }
        
        #endregion
    }
}
