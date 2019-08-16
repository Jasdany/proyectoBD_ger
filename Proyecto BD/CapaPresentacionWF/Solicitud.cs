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
    public partial class Solicitud : Form

    {
    
        LogicaNegocioSolicitud logicaSolicitud= new LogicaNegocioSolicitud();
        

        public Solicitud()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnGuardar.Text == "Guardar")
                {

                    capaEntidades.Solicitud solicitud = new capaEntidades.Solicitud();

                    solicitud.carrera = txtCarrera.Text;
                    solicitud.asignatura = txtAsigatura.Text;
                    solicitud.aula = txtAula.Text;
                    solicitud.horainicio = txtHi.Text;
                    solicitud.horafinal = txtHf.Text;
                    solicitud.fechasolicitud = dateTimePickerFs.Text;
                    solicitud.fechauso = dateTimePickerFu.Text;
                    solicitud.idusuario = Convert.ToInt32(txtIdUsuario.Text);
                    solicitud.idrecursos = Convert.ToInt32(txtIdRecurso.Text);

                    if (btnGuardar.Text == "Guardar")
                    {
                        MessageBox.Show("Agregado con Exito");
                        dataGridViewSolicitud.DataSource = logicaSolicitud.listarSolicitud();
                        txtCarrera.Text = "";
                        txtAsigatura.Text = "";
                        txtAula.Text = "";
                        txtHi.Text = "";
                        txtHf.Text = "";
                        dateTimePickerFs.Text = "";
                        dateTimePickerFu.Text = "";
                        tabSolicitud.SelectedTab = tabDetalle;
                    }

                    else { MessageBox.Show("Error al agregar"); }
                }
                if (btnGuardar.Text == "Actualizar")
                {
                    capaEntidades.Solicitud objSolicitud = new capaEntidades.Solicitud();

                    objSolicitud.idsolicitud = Convert.ToInt32(txtid.Text);
                    objSolicitud.idusuario = Convert.ToInt32(txtIdUsuario.Text);
                    objSolicitud.idrecursos = Convert.ToInt32(txtIdRecurso.Text);
                    objSolicitud.carrera = txtCarrera.Text;
                    objSolicitud.asignatura = txtAsigatura.Text;
                    objSolicitud.aula = txtAula.Text;
                    objSolicitud.horainicio = txtHi.Text;
                    objSolicitud.horafinal = txtHf.Text;
                    objSolicitud.fechasolicitud = dateTimePickerFs.Text;
                    objSolicitud.fechauso = dateTimePickerFu.Text;
                    objSolicitud.idrecursos = Convert.ToInt32(txtIdRecurso.Text);
                    objSolicitud.idusuario = Convert.ToInt32(txtIdUsuario.Text);

                    if (logicaSolicitud.EditarSolicitud(objSolicitud) > 0)
                    {
                        MessageBox.Show("Actualizado con Exito");
                        dataGridViewSolicitud.DataSource = logicaSolicitud.listarSolicitud();
                        txtCarrera.Text = "";
                        txtAsigatura.Text = "";
                        txtAula.Text = "";
                        txtHi.Text = "";
                        txtHf.Text = "";
                        dateTimePickerFs.Text = "";
                        dateTimePickerFu.Text = "";
                        txtIdRecurso.Text = "";
                        txtIdUsuario.Text = "";
                        tabSolicitud.SelectedTab = tabDetalle;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar");
                    }

                    btnGuardar.Text = "Guardar";

                }

            }
            catch
            {
                MessageBox.Show("ERROR");
            
            }
        }

        private void Solicitud_Load(object sender, EventArgs e)
        {
            txtid.Visible = false;
            lblid.Visible = false;
            dataGridViewSolicitud.DataSource = logicaSolicitud.listarSolicitud();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtid.Visible = true;
            txtid.Enabled = false;
            lblid.Visible = true;

            txtid.Text = dataGridViewSolicitud.CurrentRow.Cells["idsolicitud"].Value.ToString();
            txtCarrera.Text = dataGridViewSolicitud.CurrentRow.Cells["carrera"].Value.ToString();
            txtAsigatura.Text = dataGridViewSolicitud.CurrentRow.Cells["asignatura"].Value.ToString();
            txtAula.Text = dataGridViewSolicitud.CurrentRow.Cells["aula"].Value.ToString();
            txtnivel.Text = dataGridViewSolicitud.CurrentRow.Cells["nivel"].Value.ToString();
            txtHi.Text = dataGridViewSolicitud.CurrentRow.Cells["horainicio"].Value.ToString();
            txtHf.Text = dataGridViewSolicitud.CurrentRow.Cells["horafinal"].Value.ToString();
            dateTimePickerFs.Text = dataGridViewSolicitud.CurrentRow.Cells["fechasolicitud"].Value.ToString();
            dateTimePickerFu.Text = dataGridViewSolicitud.CurrentRow.Cells["fechauso"].Value.ToString();
            txtIdRecurso.Text = dataGridViewSolicitud.CurrentRow.Cells["idrecursos"].Value.ToString();
            txtIdUsuario.Text = dataGridViewSolicitud.CurrentRow.Cells["idusuario"].Value.ToString();

            tabSolicitud.SelectedTab = tabDetalle;
            btnGuardar.Text = "Actualizar";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codigor = Convert.ToInt32(dataGridViewSolicitud.CurrentRow.Cells["idsolicitud"].Value.ToString());

            try
            {
                if (logicaSolicitud.eliminarSolicitud(codigor)>0)
                {
                    MessageBox.Show("Eliminado con exito");
                    dataGridViewSolicitud.DataSource = logicaSolicitud.listarSolicitud();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al eliminar");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<capaEntidades.Solicitud> listaSolicitud = logicaSolicitud.BuscarSolicitud(txtBuscar.Text);  
            dataGridViewSolicitud.DataSource = listaSolicitud;
            
        }

        private void dataGridViewSolicitud_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
            
    }
}
