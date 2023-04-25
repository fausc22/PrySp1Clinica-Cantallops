using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrySp1Clinica_Cantallops
{
    public partial class frmConsulta : Form
    {
        //declaro nombre archivo Medicos
        private const string PATH_ARCHIVO_M = "Medico.txt";

        //declaro nombre archivo Especialidades
        private const string PATH_ARCHIVO_E = "Especialidad.txt";

        //array unidimensional para entrelazar la identifiacion del medico con la especialidad
        int[] NroEspecialidad = new int[5];

        public frmConsulta()
        {
            InitializeComponent();
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            AgregarEspecialidad();
        }

        //metodo para agregar especialidades al combobox
        private void AgregarEspecialidad()
        {
            if (!File.Exists(Application.StartupPath + "\\" + PATH_ARCHIVO_E))
            {
                MessageBox.Show("No hay ninguna especialidad registrada, por favor registre una en la brevedad.", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            ClsArchivo especialidad = new ClsArchivo();
            especialidad.NombreArchivo = PATH_ARCHIVO_E;
            List<ClsMedico> especialidades = especialidad.ObtenerEspecialidad();

            cmbEspecialidad.Items.Clear();

            foreach(ClsMedico especial in especialidades)
            {
                cmbEspecialidad.Items.Add(especial.nombre);
                
                //ciclo FOR para escribir el nro de especialidad y asi entrelazarlo con el medico usando una LABEL
                for (int i = 1; i < especialidades.Count; i++)
                {
                    NroEspecialidad[i] = especial.especialidad;
                }
                
            }

            
        }


        //procedimiento consultar
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if(!File.Exists (Application.StartupPath + "\\" + PATH_ARCHIVO_M))
            {
                MessageBox.Show("No hay datos para mostrar", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            ClsArchivo medico = new ClsArchivo();
            medico.NombreArchivo = PATH_ARCHIVO_M;
            List<ClsMedico> medicos = medico.ObtenerMedicos();
            

            dgvInfo.Rows.Clear();

            foreach(ClsMedico medicoo in medicos)
            {
                if (medicoo.especialidad == int.Parse(lblNroEspecialidad.Text))
                {
                    dgvInfo.Rows.Add(medicoo.matricula, medicoo.nombre);
                }
            }

            cmbEspecialidad.SelectedIndex = -1;
            lblNroEspecialidad.Text = "";
        }


        //procedimiento de cambio de especialidad en el combobox, segun la posicion de la especialidad
        //se modifica la posicion del array para asi ser entrelazdo con el del medico escribiendo en una LABEL

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

            
           if (cmbEspecialidad.SelectedIndex == 0)
            {
                lblNroEspecialidad.Text = NroEspecialidad[0].ToString();
            }
            else
            {
                if (cmbEspecialidad.SelectedIndex == 1)
                {
                    lblNroEspecialidad.Text = NroEspecialidad[1].ToString();
                }
                else
                {
                    if (cmbEspecialidad.SelectedIndex == 2)
                    {
                        lblNroEspecialidad.Text = NroEspecialidad[2].ToString();
                    }
                    else
                    {
                        if (cmbEspecialidad.SelectedIndex == 3)
                        {
                            lblNroEspecialidad.Text = NroEspecialidad[3].ToString();
                        }
                        else
                        {
                            if (cmbEspecialidad.SelectedIndex == 4)
                            {
                                lblNroEspecialidad.Text = NroEspecialidad[4].ToString();
                            }
                            
                        }
                    }
                }
            }
        }


        //procedimiento que abre el formualrio para agregar una especialidad
        private void btnEspecial_Click(object sender, EventArgs e)
        {
            
            frmEspecialidad frm = new frmEspecialidad();
            frm.ShowDialog();
            
        }

        //procedimiento que abre el formulario para agregar un nuevo medico
        private void btnMedico_Click(object sender, EventArgs e)
        {
            
            frmMedico frm = new frmMedico();
            frm.ShowDialog();
            
        }
    }
}
