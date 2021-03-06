﻿namespace CAPA_PRESENTACION.FORMULARIOS
{
    partial class FRM_MANT_USUARIOS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_MANT_USUARIOS));
            this.DG = new System.Windows.Forms.DataGridView();
            this.ID_OFICINA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFICINA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_DEPARTAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPARTAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PUESTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUESTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEXO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLAVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_editar = new System.Windows.Forms.Button();
            this.lbl_total = new MetroFramework.Controls.MetroLabel();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_buscar = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            this.SuspendLayout();
            // 
            // DG
            // 
            this.DG.AllowUserToAddRows = false;
            this.DG.AllowUserToDeleteRows = false;
            this.DG.AllowUserToResizeColumns = false;
            this.DG.AllowUserToResizeRows = false;
            this.DG.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DG.ColumnHeadersHeight = 25;
            this.DG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_OFICINA,
            this.OFICINA,
            this.ID_DEPARTAMENTO,
            this.DEPARTAMENTO,
            this.ID_PUESTO,
            this.PUESTO,
            this.ID_USUARIO,
            this.USUARIO,
            this.NOMBRE,
            this.SEXO,
            this.ESTADO,
            this.CLAVE});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG.DefaultCellStyle = dataGridViewCellStyle2;
            this.DG.EnableHeadersVisualStyles = false;
            this.DG.GridColor = System.Drawing.Color.Gray;
            this.DG.Location = new System.Drawing.Point(13, 94);
            this.DG.MultiSelect = false;
            this.DG.Name = "DG";
            this.DG.ReadOnly = true;
            this.DG.RowHeadersVisible = false;
            this.DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG.Size = new System.Drawing.Size(658, 303);
            this.DG.TabIndex = 21;
            this.DG.DoubleClick += new System.EventHandler(this.DG_DoubleClick);
            // 
            // ID_OFICINA
            // 
            this.ID_OFICINA.DataPropertyName = "ID_OFICINA";
            this.ID_OFICINA.HeaderText = "ID";
            this.ID_OFICINA.Name = "ID_OFICINA";
            this.ID_OFICINA.ReadOnly = true;
            this.ID_OFICINA.Visible = false;
            // 
            // OFICINA
            // 
            this.OFICINA.DataPropertyName = "OFICINA";
            this.OFICINA.HeaderText = "OFICINA";
            this.OFICINA.Name = "OFICINA";
            this.OFICINA.ReadOnly = true;
            this.OFICINA.Width = 200;
            // 
            // ID_DEPARTAMENTO
            // 
            this.ID_DEPARTAMENTO.DataPropertyName = "ID_DEPARTAMENTO";
            this.ID_DEPARTAMENTO.HeaderText = "ID";
            this.ID_DEPARTAMENTO.Name = "ID_DEPARTAMENTO";
            this.ID_DEPARTAMENTO.ReadOnly = true;
            this.ID_DEPARTAMENTO.Visible = false;
            this.ID_DEPARTAMENTO.Width = 50;
            // 
            // DEPARTAMENTO
            // 
            this.DEPARTAMENTO.DataPropertyName = "DEPARTAMENTO";
            this.DEPARTAMENTO.HeaderText = "DEPARTAMENTO";
            this.DEPARTAMENTO.Name = "DEPARTAMENTO";
            this.DEPARTAMENTO.ReadOnly = true;
            this.DEPARTAMENTO.Visible = false;
            this.DEPARTAMENTO.Width = 200;
            // 
            // ID_PUESTO
            // 
            this.ID_PUESTO.DataPropertyName = "ID_PUESTO";
            this.ID_PUESTO.HeaderText = "ID";
            this.ID_PUESTO.Name = "ID_PUESTO";
            this.ID_PUESTO.ReadOnly = true;
            this.ID_PUESTO.Visible = false;
            this.ID_PUESTO.Width = 50;
            // 
            // PUESTO
            // 
            this.PUESTO.DataPropertyName = "PUESTO";
            this.PUESTO.HeaderText = "PUESTO";
            this.PUESTO.Name = "PUESTO";
            this.PUESTO.ReadOnly = true;
            this.PUESTO.Visible = false;
            this.PUESTO.Width = 240;
            // 
            // ID_USUARIO
            // 
            this.ID_USUARIO.DataPropertyName = "ID_USUARIO";
            this.ID_USUARIO.HeaderText = "ID_USUARIO";
            this.ID_USUARIO.Name = "ID_USUARIO";
            this.ID_USUARIO.ReadOnly = true;
            this.ID_USUARIO.Visible = false;
            // 
            // USUARIO
            // 
            this.USUARIO.DataPropertyName = "USUARIO";
            this.USUARIO.HeaderText = "USUARIO";
            this.USUARIO.Name = "USUARIO";
            this.USUARIO.ReadOnly = true;
            // 
            // NOMBRE
            // 
            this.NOMBRE.DataPropertyName = "NOMBRE";
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            this.NOMBRE.Width = 250;
            // 
            // SEXO
            // 
            this.SEXO.DataPropertyName = "SEXO";
            this.SEXO.HeaderText = "SEXO";
            this.SEXO.Name = "SEXO";
            this.SEXO.ReadOnly = true;
            this.SEXO.Visible = false;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "ESTADO";
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            // 
            // CLAVE
            // 
            this.CLAVE.DataPropertyName = "CLAVE";
            this.CLAVE.HeaderText = "CLAVE";
            this.CLAVE.Name = "CLAVE";
            this.CLAVE.ReadOnly = true;
            this.CLAVE.Visible = false;
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_editar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar.Image")));
            this.btn_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editar.Location = new System.Drawing.Point(116, 404);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(101, 43);
            this.btn_editar.TabIndex = 20;
            this.btn_editar.Text = "  Editar";
            this.btn_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_total.Location = new System.Drawing.Point(292, 422);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(377, 25);
            this.lbl_total.TabIndex = 18;
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btn_agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar.Image")));
            this.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregar.Location = new System.Drawing.Point(12, 404);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(101, 43);
            this.btn_agregar.TabIndex = 19;
            this.btn_agregar.Text = "  Agregar";
            this.btn_agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txt_buscar
            // 
            // 
            // 
            // 
            this.txt_buscar.CustomButton.Image = null;
            this.txt_buscar.CustomButton.Location = new System.Drawing.Point(355, 1);
            this.txt_buscar.CustomButton.Name = "";
            this.txt_buscar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_buscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_buscar.CustomButton.TabIndex = 1;
            this.txt_buscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_buscar.CustomButton.UseSelectable = true;
            this.txt_buscar.CustomButton.Visible = false;
            this.txt_buscar.DisplayIcon = true;
            this.txt_buscar.Icon = ((System.Drawing.Image)(resources.GetObject("txt_buscar.Icon")));
            this.txt_buscar.Lines = new string[0];
            this.txt_buscar.Location = new System.Drawing.Point(14, 65);
            this.txt_buscar.MaxLength = 32767;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.PasswordChar = '\0';
            this.txt_buscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_buscar.SelectedText = "";
            this.txt_buscar.SelectionLength = 0;
            this.txt_buscar.SelectionStart = 0;
            this.txt_buscar.ShortcutsEnabled = true;
            this.txt_buscar.Size = new System.Drawing.Size(377, 23);
            this.txt_buscar.TabIndex = 17;
            this.txt_buscar.UseSelectable = true;
            this.txt_buscar.WaterMark = "Buscar por Oficina, Departamento, Puesto, Nombre  o Usuario";
            this.txt_buscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_buscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // FRM_MANT_USUARIOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(687, 461);
            this.Controls.Add(this.DG);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_buscar);
            this.Name = "FRM_MANT_USUARIOS";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FRM_MANT_USUARIOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG;
        private System.Windows.Forms.Button btn_editar;
        private MetroFramework.Controls.MetroLabel lbl_total;
        private System.Windows.Forms.Button btn_agregar;
        private MetroFramework.Controls.MetroTextBox txt_buscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_OFICINA;
        private System.Windows.Forms.DataGridViewTextBoxColumn OFICINA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DEPARTAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPARTAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PUESTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUESTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEXO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLAVE;
    }
}
