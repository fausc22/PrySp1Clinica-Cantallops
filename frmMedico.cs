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
    public partial class frmMedico : Form
    {
        public frmMedico()
        {
            InitializeComponent();
        }

        //declaracion del archivo .txt
        private const string PATH_ARCHIVO_M = "Medico.txt";


        //metodo para limpiar txt y deshabilitar boton
        private void Inicializar()
        {
            txtMatricula.Text = "";
            txtNombre.Text = "";
            txtIdent.Text = "";
            btnRegistrar.Enabled = false;
        }

        private void frmMedico_Load(object sender, EventArgs e)
        {
            Inicializar();
        }


        //metodo para validar datos
        private bool ValidarDatos()
        {
            bool resultado = false;
            if (txtMatricula.Text != "")
            {
                if (txtNombre.Text != "")
                {
                    if (txtIdent.Text != "")
                    {
                        ClsArchivo medico = new ClsArchivo();
                        medico.NombreArchivo = PATH_ARCHIVO_M;
                        if (medico.BuscarRepetido(txtMatricula.Text) == false)
                        {
                            resultado = true;
                        }
                    }
                }
            }
            return resultado;
        }


        //metodo para copiar los datos de los txt
        private ClsMedico NuevoMedico()
        {
            ClsMedico nuevomedico = new ClsMedico();
            nuevomedico.matricula = int.Parse(txtMatricula.Text);
            nuevomedico.nombre = txtNombre.Text;
            nuevomedico.especialidad = int.Parse(txtIdent.Text);
            return nuevomedico;
        }


        //evento para registrar un nuevo medico
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                ClsMedico nuevomedico = NuevoMedico();
                ClsArchivo medicos = new ClsArchivo();
                medicos.NombreArchivo = PATH_ARCHIVO_M;
                medicos.GrabarMedico(nuevomedico);
                Inicializar();
            }
            else
            {
                MessageBox.Show("Datos incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //evento para habilitar el boton registrar una vez completados todos los txt
        private void txtIdent_TextChanged(object sender, EventArgs e)
        {
            if (txtMatricula.Text != null && txtNombre.Text != null && txtIdent.Text != null)
            {
                btnRegistrar.Enabled = true;
            }
        }

        //evento para solo numeros
        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
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

            Close();
        }
    }
}
