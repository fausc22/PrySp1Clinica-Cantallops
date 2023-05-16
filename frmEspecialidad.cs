using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrySp1Clinica_Cantallops
{
    public partial class frmEspecialidad : Form
    {
        public frmEspecialidad()
        {
            InitializeComponent();
        }

        //declaracion del archivo .txt
        private const string PATH_ARCHIVO_E = "Especialidad.txt";


        //metodo para limpiar y deshabilitar boton
        private void Inicializar()
        {
            txtNombre.Text = "";
            txtIdent.Text = "";
            btnRegistrar.Enabled = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Inicializar();
        }


        //metodo para validar repetidos
        private bool ValidarDatos()
        {
            bool resultado = false;
            if (txtNombre.Text != "")
            {
                if (txtIdent.Text != "")
                {
                    ClsArchivo especialidad = new ClsArchivo();
                    especialidad.NombreArchivo = PATH_ARCHIVO_E;
                    if (especialidad.BuscarRepetido(txtIdent.Text) == false)
                    {
                        resultado = true;
                    }
                }
            }
            return resultado;
        }

        //metodo para copiar los datos de los txt
        private ClsMedico NuevaEspecialidad()
        {
            ClsMedico especialidad = new ClsMedico();
            especialidad.especialidad = int.Parse(txtIdent.Text);
            especialidad.nombre = txtNombre.Text;
            return especialidad;
        }


        //evento para registrar una nueva especialidad
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                ClsMedico especialidad = NuevaEspecialidad();
                ClsArchivo especialidades = new ClsArchivo();
                especialidades.NombreArchivo = PATH_ARCHIVO_E;
                especialidades.GrabarEspecialidad(especialidad);
                Inicializar();
                MessageBox.Show("Especialidad registrada con éxito", "", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Datos incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }


        //evento para habilitar el boton registrar una vez completado los txt
        private void txtIdent_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != null && txtIdent.Text != null)
            {
                btnRegistrar.Enabled = true;
            }
        }


        //evento para solo numeros
        private void txtIdent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            
            this.Hide();
            frmConsulta frm = new frmConsulta();
            frm.ShowDialog();
        }
    }
}
