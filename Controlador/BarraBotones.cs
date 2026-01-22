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
    public partial class BarraBotones : UserControl
    {
        //Mostramos los clicks públicos para poder ejecutarlos desde fuera de la clase
        public event EventHandler ClickGuardar;
        public event EventHandler ClickPermitirModificar;
        public event EventHandler ClickMasInfo;
        public BarraBotones()
        {
            InitializeComponent();
        }

        #region EVENTOS
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClickGuardar?.Invoke(this, e);
        }

        private void btnPermitirModificar_Click(object sender, EventArgs e)
        {
            ClickPermitirModificar?.Invoke(this, e);
        }

        private void btnMasInfo_Click(object sender, EventArgs e)
        {
            ClickMasInfo?.Invoke(this, e);
        }

        #endregion

        #region PROPIEDADES PÚBLICAS
        public bool VisibilidadGuardar
        {
            get => btnGuardar.Visible;
            set => btnGuardar.Visible = value;
        }
        public bool VisibilidadPermitirModificar
        {
            get => btnPermitirModificar.Visible;
            set => btnPermitirModificar.Visible = value;
        }
        public bool VisibilidadMasInfo
        {
            get => btnInfo.Visible;
            set => btnInfo.Visible = value;
        }
        #endregion
    }
}
