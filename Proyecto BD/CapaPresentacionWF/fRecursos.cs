using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using capaEntidades;

namespace CapaPresentacionWF
{
    public partial class fRecursos : Form
    {
        LogicaNegocioRecursos logicaNR = new LogicaNegocioRecursos();

        public fRecursos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnGuardar.Text == "Guardar")
                {
                    Recursos objetoRecursos = new Recursos();
                    objetoRecursos.nombrer = txtNombre.Text;
                    objetoRecursos.codigo = txtCodigo.Text;
                    objetoRecursos.descripcion = txtDescripcion.Text;

                    if (logicaNR.insertarRecursos(objetoRecursos) > 0)
                    {
                        MessageBox.Show("Agregado con Exito");
                        dataGridView1.DataSource = logicaNR.listarRecursos();
                        txtNombre.Text = "";
                        txtDescripcion.Text = "";
                        txtCodigo.Text = "";
                        tabconRecursos.SelectedTab = tabPage2;
                    }

                    else { MessageBox.Show("Error al agregar Recursos"); }
                }

                if (btnGuardar.Text == "Actualizar")
                {
                    Recursos objetoRecursos = new Recursos();
                    objetoRecursos.idrecursos = Convert.ToInt32(txtID.Text);
                    objetoRecursos.nombrer = txtNombre.Text;
                    objetoRecursos.codigo = txtCodigo.Text;
                    objetoRecursos.descripcion = txtDescripcion.Text;

                    if (logicaNR.EditarRecursos(objetoRecursos) > 0)
                    {
                        MessageBox.Show("Actualizando con exito");
                        dataGridView1.DataSource = logicaNR.listarRecursos();
                        txtNombre.Text = "";
                        txtDescripcion.Text = "";
                        txtCodigo.Text = "";
                        tabconRecursos.SelectedTab = tabPage2;

                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar Recurso");
                    }
                    btnGuardar.Text = "Guardar";
                }

            }
            catch
            {
                MessageBox.Show("ERROR");
            }

        }

        private void fRecursos_Load(object sender, EventArgs e)
        {
            txtID.Visible = false;
            lblid.Visible = false;
            dataGridView1.DataSource = logicaNR.listarRecursos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtID.Visible = true;
            txtID.Enabled = false;
            lblid.Visible = true;

            txtID.Text = dataGridView1.CurrentRow.Cells["idrec"].Value.ToString();
            txtNombre.Text = dataGridView1.CurrentRow.Cells["nombrer"].Value.ToString();
            txtCodigo.Text = dataGridView1.CurrentRow.Cells["codigo"].Value.ToString();
            txtDescripcion.Text = dataGridView1.CurrentRow.Cells["descripcion"].Value.ToString();

            tabconRecursos.SelectedTab = tabPage1;
            btnGuardar.Text = "Actualizar";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codigoR= Convert.ToInt32(dataGridView1.CurrentRow.Cells["idrecursos"].Value.ToString());

            try
            {
                if (logicaNR.eliminarRecursos(codigoR) > 0)
                {
                    MessageBox.Show("Eliminado con Exito");
                    dataGridView1.DataSource = logicaNR.listarRecursos();
                }

            }
            catch
            {
                MessageBox.Show("ERROR al eliminar recursos");  
              
            }
        }
         
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Recursos> listarRecursos = logicaNR.BuscarRecursos(textBox1.Text);
            dataGridView1.DataSource = listarRecursos;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
