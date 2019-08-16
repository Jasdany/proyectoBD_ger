namespace CapaPresentacionWF
{
    partial class Solicitud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblid = new System.Windows.Forms.Label();
            this.lblAula = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblFs = new System.Windows.Forms.Label();
            this.lblFu = new System.Windows.Forms.Label();
            this.lblHi = new System.Windows.Forms.Label();
            this.lblHf = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblAsigatura = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtAsigatura = new System.Windows.Forms.TextBox();
            this.txtAula = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tabSolicitud = new System.Windows.Forms.TabControl();
            this.tabNuevo = new System.Windows.Forms.TabPage();
            this.txtnivel = new System.Windows.Forms.TextBox();
            this.txtIdRecurso = new System.Windows.Forms.TextBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFu = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFs = new System.Windows.Forms.DateTimePicker();
            this.tabDetalle = new System.Windows.Forms.TabPage();
            this.dataGridViewSolicitud = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtHf = new System.Windows.Forms.DateTimePicker();
            this.txtHi = new System.Windows.Forms.DateTimePicker();
            this.tabSolicitud.SuspendLayout();
            this.tabNuevo.SuspendLayout();
            this.tabDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolicitud)).BeginInit();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(21, 94);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(27, 19);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "ID";
            this.lblid.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAula
            // 
            this.lblAula.AutoSize = true;
            this.lblAula.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAula.Location = new System.Drawing.Point(348, 205);
            this.lblAula.Name = "lblAula";
            this.lblAula.Size = new System.Drawing.Size(40, 19);
            this.lblAula.TabIndex = 1;
            this.lblAula.Text = "Aula";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(16, 208);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(45, 19);
            this.lblNivel.TabIndex = 2;
            this.lblNivel.Text = "Nivel";
            // 
            // lblFs
            // 
            this.lblFs.AutoSize = true;
            this.lblFs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFs.Location = new System.Drawing.Point(16, 265);
            this.lblFs.Name = "lblFs";
            this.lblFs.Size = new System.Drawing.Size(110, 19);
            this.lblFs.TabIndex = 3;
            this.lblFs.Text = "Fecha Solicitud";
            // 
            // lblFu
            // 
            this.lblFu.AutoSize = true;
            this.lblFu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFu.Location = new System.Drawing.Point(348, 263);
            this.lblFu.Name = "lblFu";
            this.lblFu.Size = new System.Drawing.Size(76, 19);
            this.lblFu.TabIndex = 4;
            this.lblFu.Text = "Fecha uso";
            // 
            // lblHi
            // 
            this.lblHi.AutoSize = true;
            this.lblHi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHi.Location = new System.Drawing.Point(21, 318);
            this.lblHi.Name = "lblHi";
            this.lblHi.Size = new System.Drawing.Size(84, 19);
            this.lblHi.TabIndex = 5;
            this.lblHi.Text = "Hora Inicio";
            // 
            // lblHf
            // 
            this.lblHf.AutoSize = true;
            this.lblHf.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHf.Location = new System.Drawing.Point(344, 318);
            this.lblHf.Name = "lblHf";
            this.lblHf.Size = new System.Drawing.Size(80, 19);
            this.lblHf.TabIndex = 6;
            this.lblHf.Text = "Hora Final";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(16, 152);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(62, 19);
            this.lblCarrera.TabIndex = 7;
            this.lblCarrera.Text = "Carrera";
            // 
            // lblAsigatura
            // 
            this.lblAsigatura.AutoSize = true;
            this.lblAsigatura.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsigatura.Location = new System.Drawing.Point(350, 152);
            this.lblAsigatura.Name = "lblAsigatura";
            this.lblAsigatura.Size = new System.Drawing.Size(74, 19);
            this.lblAsigatura.TabIndex = 8;
            this.lblAsigatura.Text = "Asigatura";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(99, 95);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(119, 20);
            this.txtid.TabIndex = 9;
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(430, 204);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(210, 20);
            this.txtCarrera.TabIndex = 10;
            // 
            // txtAsigatura
            // 
            this.txtAsigatura.Location = new System.Drawing.Point(132, 152);
            this.txtAsigatura.Name = "txtAsigatura";
            this.txtAsigatura.Size = new System.Drawing.Size(210, 20);
            this.txtAsigatura.TabIndex = 11;
            // 
            // txtAula
            // 
            this.txtAula.Location = new System.Drawing.Point(430, 153);
            this.txtAula.Name = "txtAula";
            this.txtAula.Size = new System.Drawing.Size(210, 20);
            this.txtAula.TabIndex = 12;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGuardar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(286, 404);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 31);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tabSolicitud
            // 
            this.tabSolicitud.Controls.Add(this.tabNuevo);
            this.tabSolicitud.Controls.Add(this.tabDetalle);
            this.tabSolicitud.Location = new System.Drawing.Point(0, 1);
            this.tabSolicitud.Name = "tabSolicitud";
            this.tabSolicitud.SelectedIndex = 0;
            this.tabSolicitud.Size = new System.Drawing.Size(654, 495);
            this.tabSolicitud.TabIndex = 19;
            // 
            // tabNuevo
            // 
            this.tabNuevo.Controls.Add(this.txtHi);
            this.tabNuevo.Controls.Add(this.txtHf);
            this.tabNuevo.Controls.Add(this.txtnivel);
            this.tabNuevo.Controls.Add(this.txtIdRecurso);
            this.tabNuevo.Controls.Add(this.txtIdUsuario);
            this.tabNuevo.Controls.Add(this.label3);
            this.tabNuevo.Controls.Add(this.label2);
            this.tabNuevo.Controls.Add(this.label1);
            this.tabNuevo.Controls.Add(this.dateTimePickerFu);
            this.tabNuevo.Controls.Add(this.dateTimePickerFs);
            this.tabNuevo.Controls.Add(this.lblid);
            this.tabNuevo.Controls.Add(this.btnGuardar);
            this.tabNuevo.Controls.Add(this.txtid);
            this.tabNuevo.Controls.Add(this.lblCarrera);
            this.tabNuevo.Controls.Add(this.lblHf);
            this.tabNuevo.Controls.Add(this.lblHi);
            this.tabNuevo.Controls.Add(this.txtCarrera);
            this.tabNuevo.Controls.Add(this.lblAsigatura);
            this.tabNuevo.Controls.Add(this.txtAsigatura);
            this.tabNuevo.Controls.Add(this.lblFu);
            this.tabNuevo.Controls.Add(this.txtAula);
            this.tabNuevo.Controls.Add(this.lblAula);
            this.tabNuevo.Controls.Add(this.lblFs);
            this.tabNuevo.Controls.Add(this.lblNivel);
            this.tabNuevo.Location = new System.Drawing.Point(4, 22);
            this.tabNuevo.Name = "tabNuevo";
            this.tabNuevo.Padding = new System.Windows.Forms.Padding(3);
            this.tabNuevo.Size = new System.Drawing.Size(646, 469);
            this.tabNuevo.TabIndex = 0;
            this.tabNuevo.Text = "Nuevo";
            this.tabNuevo.UseVisualStyleBackColor = true;
            // 
            // txtnivel
            // 
            this.txtnivel.Location = new System.Drawing.Point(132, 207);
            this.txtnivel.Name = "txtnivel";
            this.txtnivel.Size = new System.Drawing.Size(210, 20);
            this.txtnivel.TabIndex = 29;
            // 
            // txtIdRecurso
            // 
            this.txtIdRecurso.Location = new System.Drawing.Point(521, 99);
            this.txtIdRecurso.Name = "txtIdRecurso";
            this.txtIdRecurso.Size = new System.Drawing.Size(119, 20);
            this.txtIdRecurso.TabIndex = 28;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(305, 97);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(119, 20);
            this.txtIdUsuario.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(436, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "IdRecurso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "IdUsuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Thistle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Solicitud";
            // 
            // dateTimePickerFu
            // 
            this.dateTimePickerFu.Location = new System.Drawing.Point(430, 261);
            this.dateTimePickerFu.Name = "dateTimePickerFu";
            this.dateTimePickerFu.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFu.TabIndex = 21;
            // 
            // dateTimePickerFs
            // 
            this.dateTimePickerFs.Location = new System.Drawing.Point(132, 263);
            this.dateTimePickerFs.Name = "dateTimePickerFs";
            this.dateTimePickerFs.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFs.TabIndex = 20;
            // 
            // tabDetalle
            // 
            this.tabDetalle.Controls.Add(this.dataGridViewSolicitud);
            this.tabDetalle.Controls.Add(this.btnEliminar);
            this.tabDetalle.Controls.Add(this.btnEditar);
            this.tabDetalle.Controls.Add(this.txtBuscar);
            this.tabDetalle.Controls.Add(this.lblBuscar);
            this.tabDetalle.Location = new System.Drawing.Point(4, 22);
            this.tabDetalle.Name = "tabDetalle";
            this.tabDetalle.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetalle.Size = new System.Drawing.Size(646, 469);
            this.tabDetalle.TabIndex = 1;
            this.tabDetalle.Text = "Detalle";
            this.tabDetalle.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSolicitud
            // 
            this.dataGridViewSolicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSolicitud.Location = new System.Drawing.Point(8, 187);
            this.dataGridViewSolicitud.Name = "dataGridViewSolicitud";
            this.dataGridViewSolicitud.Size = new System.Drawing.Size(632, 273);
            this.dataGridViewSolicitud.TabIndex = 5;
            this.dataGridViewSolicitud.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSolicitud_CellContentClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEliminar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(486, 81);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 35);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEditar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(363, 81);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(84, 34);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(83, 89);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(238, 20);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(21, 89);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(56, 19);
            this.lblBuscar.TabIndex = 1;
            this.lblBuscar.Text = "Buscar";
            // 
            // txtHf
            // 
            this.txtHf.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtHf.Location = new System.Drawing.Point(430, 317);
            this.txtHf.Name = "txtHf";
            this.txtHf.Size = new System.Drawing.Size(104, 20);
            this.txtHf.TabIndex = 30;
            // 
            // txtHi
            // 
            this.txtHi.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtHi.Location = new System.Drawing.Point(132, 317);
            this.txtHi.Name = "txtHi";
            this.txtHi.Size = new System.Drawing.Size(103, 20);
            this.txtHi.TabIndex = 31;
            // 
            // Solicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(656, 495);
            this.Controls.Add(this.tabSolicitud);
            this.Name = "Solicitud";
            this.Text = "Solicitud";
            this.Load += new System.EventHandler(this.Solicitud_Load);
            this.tabSolicitud.ResumeLayout(false);
            this.tabNuevo.ResumeLayout(false);
            this.tabNuevo.PerformLayout();
            this.tabDetalle.ResumeLayout(false);
            this.tabDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolicitud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblAula;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblFs;
        private System.Windows.Forms.Label lblFu;
        private System.Windows.Forms.Label lblHi;
        private System.Windows.Forms.Label lblHf;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblAsigatura;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.TextBox txtAsigatura;
        private System.Windows.Forms.TextBox txtAula;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TabControl tabSolicitud;
        private System.Windows.Forms.TabPage tabNuevo;
        private System.Windows.Forms.TabPage tabDetalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFu;
        private System.Windows.Forms.DateTimePicker dateTimePickerFs;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dataGridViewSolicitud;
        private System.Windows.Forms.TextBox txtIdRecurso;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnivel;
        private System.Windows.Forms.DateTimePicker txtHi;
        private System.Windows.Forms.DateTimePicker txtHf;
    }
}