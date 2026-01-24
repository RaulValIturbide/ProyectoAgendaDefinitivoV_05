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
        public Contacto _Contacto;

        public MostrarInfoContacto(Contacto contacto )
        {
            InitializeComponent();

            _Contacto = contacto;

            BindeoInverso();
           
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
                    btnAddTelefono.Visible = true;
                    tbInfo.Enabled = true;
                    break;
                case EstadoEnum.Consulta:

                    BarraBotonesPrincipal.VisibilidadMasInfo = false;
                    BarraBotonesPrincipal.VisibilidadPermitirModificar = true;
                    BarraBotonesPrincipal.VisibilidadGuardar = false;
                    btnAddTelefono.Visible = false;
                    tbInfo.Enabled = false;
                    btnAddImage.Visible = false;
                    break;
            }
        }
        //Metodo para añadir un datacontext Objeto => Visual pero de manera manual
        private void BindeoManual()
        {
            _Contacto.Nombre = txtNombre.Text;
            _Contacto.Apellidos = txtApellidos.Text;
            _Contacto.Email = txtEmail.Text;
            _Contacto.imagen = imgContacto.Image;
            _Contacto.ListaTelefonos = ConseguirListaTelefonos();
            
        }
        //Metodo para añadir un datacontext a la inversa
        //para cumplir la bidireccionalidad Objeto <= Visual de manera manual
        private void BindeoInverso()
        {
            if (_Contacto != null)
            {
                txtNombre.Text = _Contacto.Nombre;
                txtApellidos.Text = _Contacto.Apellidos;
                txtEmail.Text = _Contacto.Email;
                imgContacto.Image = _Contacto.imagen;
                if (_Contacto.ListaTelefonos.Count > 0)
                {
                    txtTelefono.Text = _Contacto.ListaTelefonos[0];
                }

                // Si hay más teléfonos, creamos filas dinámicas
                int indice = 2; // El segundo teléfono será TELEFONO 2
                for (int i = 1; i < _Contacto.ListaTelefonos.Count; i++)
                {
                    if (tbInfo.RowCount >= 6)
                    {
                        break;
                    }
                    tbInfo.RowCount++;
                    btnAddTelefono.Location = new Point(
                                              btnAddTelefono.Location.X,
                                              btnAddTelefono.Location.Y + 25
                                              );
                    Label lb = new Label();
                    lb.Text = $"TELEFONO {indice}";
                    lb.Font = new Font("MV Boli", (float)9.5, FontStyle.Regular);
                    lb.Name = $"lbTelefono{indice}";


                    TextBox txt = new TextBox();
                    txt.Dock = DockStyle.Fill;
                    txt.Name = $"txtTelefono{indice}";
                    txt.Text = _Contacto.ListaTelefonos[i];



                    tbInfo.Controls.Add(lb, 0, tbInfo.RowCount - 1);
                    tbInfo.Controls.Add(txt, 1, tbInfo.RowCount - 1);

                    indice++;
                }
            }

        }
        private List<string> ConseguirListaTelefonos() 
        { 
            List<string> lista = new List<string>(); 
            foreach (Control c in tbInfo.Controls) 
            { 
                if (c is TextBox && c.Name.StartsWith("txtTelefono")) 
                {
                    string valor = c.Text.Trim();
                    if (!string.IsNullOrEmpty(valor))
                    {
                        lista.Add(valor);
                    }
                } 
            } 
            return lista; 
        }
        #endregion

        #region EVENTOS
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Resultado res = new Resultado();
            BindeoManual();
            res = _Contacto.ValidarDatos();

            if (res.CodigoError == 0)
            {
                res.MensajeResultado = "Registro modificado con éxito";
                MostrarResultado mr = new MostrarResultado(res.MensajeResultado);
                mr.ShowDialog();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MostrarResultado mr = new MostrarResultado(res);
                mr.ShowDialog();
            }
        }
        private void btnPermitirModificar_Click(object sender, EventArgs e)
        {
           
            EstablecerAspectoFormulario(EstadoEnum.Edicion);
        }
        private void btnAddTelefono_Click(object sender, EventArgs e)
        {
            if (tbInfo.RowCount < 6)
            {
                tbInfo.RowCount++;

                btnAddTelefono.Location = new Point(
                    btnAddTelefono.Location.X,
                    btnAddTelefono.Location.Y + 25
                );


                Label lb = new Label();
                lb.Text = $"TELEFONO {tbInfo.RowCount - 3}";
                lb.Font = new Font("MV Boli", (float)9.5, FontStyle.Regular);
                lb.Name = $"lbTelefono{tbInfo.RowCount - 3}"; //Nombre para identificar el ID ya que es dinámico

                TextBox txt = new TextBox();
                txt.Dock = DockStyle.Fill;
                txt.Name = $"txtTelefono{tbInfo.RowCount - 3}";


                tbInfo.Controls.Add(lb, 0, tbInfo.RowCount - 1);
                tbInfo.Controls.Add(txt, 1, tbInfo.RowCount - 1);
            }
            else
            {
                //TODO MOSTRAR HAS LLEGADO AL MAX DE CAMPOS
            }

        }

        #endregion


    }

}
