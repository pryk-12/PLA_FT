﻿namespace CAPA_PRESENTACION.FORMULARIOS
{
    partial class FRM_MANT_EVALUACIONES
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_MANT_EVALUACIONES));
            this.DG = new System.Windows.Forms.DataGridView();
            this.ID_EVALUACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDENTIFICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_OFICINA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFICINA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_ACTIVIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACTIVIDAD_ECONOMICA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_ACTIVIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_NACIONALIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NACIONALIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_NACIONALIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PAIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_PAIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PROVINCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROVINCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_PROVINCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD_EFECTIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_CANAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_RECOMENDACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RECOMENDACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ID_EVALUACION,
            this.FECHA,
            this.ID_CLIENTE,
            this.NOMBRE,
            this.IDENTIFICACION,
            this.ID_OFICINA,
            this.OFICINA,
            this.TIPO,
            this.ID_ACTIVIDAD,
            this.ACTIVIDAD_ECONOMICA,
            this.VALOR_ACTIVIDAD,
            this.ID_NACIONALIDAD,
            this.NACIONALIDAD,
            this.VALOR_NACIONALIDAD,
            this.ID_PAIS,
            this.PAIS,
            this.VALOR_PAIS,
            this.ID_PROVINCIA,
            this.PROVINCIA,
            this.VALOR_PROVINCIA,
            this.ID_CANTIDAD,
            this.CANTIDAD_EFECTIVO,
            this.VALOR_CANTIDAD,
            this.VALOR_PRODUCTO,
            this.VALOR_CANAL,
            this.ID_RECOMENDACION,
            this.RECOMENDACION,
            this.VALOR_TOTAL});
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
            this.DG.Location = new System.Drawing.Point(22, 96);
            this.DG.MultiSelect = false;
            this.DG.Name = "DG";
            this.DG.ReadOnly = true;
            this.DG.RowHeadersVisible = false;
            this.DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG.Size = new System.Drawing.Size(813, 356);
            this.DG.TabIndex = 26;
            // 
            // ID_EVALUACION
            // 
            this.ID_EVALUACION.DataPropertyName = "ID_EVALUACION";
            this.ID_EVALUACION.HeaderText = "ID";
            this.ID_EVALUACION.Name = "ID_EVALUACION";
            this.ID_EVALUACION.ReadOnly = true;
            this.ID_EVALUACION.Width = 50;
            // 
            // FECHA
            // 
            this.FECHA.DataPropertyName = "FECHA";
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            this.FECHA.Width = 80;
            // 
            // ID_CLIENTE
            // 
            this.ID_CLIENTE.DataPropertyName = "ID_CLIENTE";
            this.ID_CLIENTE.HeaderText = "ID_CLIENTE";
            this.ID_CLIENTE.Name = "ID_CLIENTE";
            this.ID_CLIENTE.ReadOnly = true;
            this.ID_CLIENTE.Visible = false;
            // 
            // NOMBRE
            // 
            this.NOMBRE.DataPropertyName = "NOMBRE";
            this.NOMBRE.HeaderText = "CLIENTE";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            this.NOMBRE.Width = 365;
            // 
            // IDENTIFICACION
            // 
            this.IDENTIFICACION.DataPropertyName = "IDENTIFICACION";
            this.IDENTIFICACION.HeaderText = "IDENTIFICACION";
            this.IDENTIFICACION.Name = "IDENTIFICACION";
            this.IDENTIFICACION.ReadOnly = true;
            // 
            // ID_OFICINA
            // 
            this.ID_OFICINA.DataPropertyName = "ID_OFICINA";
            this.ID_OFICINA.HeaderText = "ID_OFICINA";
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
            this.OFICINA.Visible = false;
            // 
            // TIPO
            // 
            this.TIPO.DataPropertyName = "TIPO";
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            // 
            // ID_ACTIVIDAD
            // 
            this.ID_ACTIVIDAD.DataPropertyName = "ID_ACTIVIDAD";
            this.ID_ACTIVIDAD.HeaderText = "ID_ACTIVIDAD";
            this.ID_ACTIVIDAD.Name = "ID_ACTIVIDAD";
            this.ID_ACTIVIDAD.ReadOnly = true;
            this.ID_ACTIVIDAD.Visible = false;
            // 
            // ACTIVIDAD_ECONOMICA
            // 
            this.ACTIVIDAD_ECONOMICA.DataPropertyName = "ACTIVIDAD_ECONOMICA";
            this.ACTIVIDAD_ECONOMICA.HeaderText = "ACTIVIDAD_ECONOMICA";
            this.ACTIVIDAD_ECONOMICA.Name = "ACTIVIDAD_ECONOMICA";
            this.ACTIVIDAD_ECONOMICA.ReadOnly = true;
            this.ACTIVIDAD_ECONOMICA.Visible = false;
            // 
            // VALOR_ACTIVIDAD
            // 
            this.VALOR_ACTIVIDAD.DataPropertyName = "VALOR_ACTIVIDAD";
            this.VALOR_ACTIVIDAD.HeaderText = "VALOR_ACTIVIDAD";
            this.VALOR_ACTIVIDAD.Name = "VALOR_ACTIVIDAD";
            this.VALOR_ACTIVIDAD.ReadOnly = true;
            this.VALOR_ACTIVIDAD.Visible = false;
            // 
            // ID_NACIONALIDAD
            // 
            this.ID_NACIONALIDAD.DataPropertyName = "ID_NACIONALIDAD";
            this.ID_NACIONALIDAD.HeaderText = "ID_NACIONALIDAD";
            this.ID_NACIONALIDAD.Name = "ID_NACIONALIDAD";
            this.ID_NACIONALIDAD.ReadOnly = true;
            this.ID_NACIONALIDAD.Visible = false;
            // 
            // NACIONALIDAD
            // 
            this.NACIONALIDAD.DataPropertyName = "NACIONALIDAD";
            this.NACIONALIDAD.HeaderText = "NACIONALIDAD";
            this.NACIONALIDAD.Name = "NACIONALIDAD";
            this.NACIONALIDAD.ReadOnly = true;
            this.NACIONALIDAD.Visible = false;
            // 
            // VALOR_NACIONALIDAD
            // 
            this.VALOR_NACIONALIDAD.DataPropertyName = "VALOR_NACIONALIDAD";
            this.VALOR_NACIONALIDAD.HeaderText = "VALOR_NACIONALIDAD";
            this.VALOR_NACIONALIDAD.Name = "VALOR_NACIONALIDAD";
            this.VALOR_NACIONALIDAD.ReadOnly = true;
            this.VALOR_NACIONALIDAD.Visible = false;
            // 
            // ID_PAIS
            // 
            this.ID_PAIS.DataPropertyName = "ID_PAIS";
            this.ID_PAIS.HeaderText = "ID_PAIS";
            this.ID_PAIS.Name = "ID_PAIS";
            this.ID_PAIS.ReadOnly = true;
            this.ID_PAIS.Visible = false;
            // 
            // PAIS
            // 
            this.PAIS.DataPropertyName = "PAIS";
            this.PAIS.HeaderText = "PAIS";
            this.PAIS.Name = "PAIS";
            this.PAIS.ReadOnly = true;
            this.PAIS.Visible = false;
            // 
            // VALOR_PAIS
            // 
            this.VALOR_PAIS.DataPropertyName = "VALOR_PAIS";
            this.VALOR_PAIS.HeaderText = "VALOR_PAIS";
            this.VALOR_PAIS.Name = "VALOR_PAIS";
            this.VALOR_PAIS.ReadOnly = true;
            this.VALOR_PAIS.Visible = false;
            // 
            // ID_PROVINCIA
            // 
            this.ID_PROVINCIA.DataPropertyName = "ID_PROVINCIA";
            this.ID_PROVINCIA.HeaderText = "ID_PROVINCIA";
            this.ID_PROVINCIA.Name = "ID_PROVINCIA";
            this.ID_PROVINCIA.ReadOnly = true;
            this.ID_PROVINCIA.Visible = false;
            // 
            // PROVINCIA
            // 
            this.PROVINCIA.DataPropertyName = "PROVINCIA";
            this.PROVINCIA.HeaderText = "PROVINCIA";
            this.PROVINCIA.Name = "PROVINCIA";
            this.PROVINCIA.ReadOnly = true;
            this.PROVINCIA.Visible = false;
            // 
            // VALOR_PROVINCIA
            // 
            this.VALOR_PROVINCIA.DataPropertyName = "VALOR_PROVINCIA";
            this.VALOR_PROVINCIA.HeaderText = "VALOR_PROVINCIA";
            this.VALOR_PROVINCIA.Name = "VALOR_PROVINCIA";
            this.VALOR_PROVINCIA.ReadOnly = true;
            this.VALOR_PROVINCIA.Visible = false;
            // 
            // ID_CANTIDAD
            // 
            this.ID_CANTIDAD.DataPropertyName = "ID_CANTIDAD";
            this.ID_CANTIDAD.HeaderText = "ID_CANTIDAD";
            this.ID_CANTIDAD.Name = "ID_CANTIDAD";
            this.ID_CANTIDAD.ReadOnly = true;
            this.ID_CANTIDAD.Visible = false;
            // 
            // CANTIDAD_EFECTIVO
            // 
            this.CANTIDAD_EFECTIVO.DataPropertyName = "CANTIDAD_EFECTIVO";
            this.CANTIDAD_EFECTIVO.HeaderText = "CANTIDAD_EFECTIVO";
            this.CANTIDAD_EFECTIVO.Name = "CANTIDAD_EFECTIVO";
            this.CANTIDAD_EFECTIVO.ReadOnly = true;
            this.CANTIDAD_EFECTIVO.Visible = false;
            // 
            // VALOR_CANTIDAD
            // 
            this.VALOR_CANTIDAD.DataPropertyName = "VALOR_CANTIDAD";
            this.VALOR_CANTIDAD.HeaderText = "VALOR_CANTIDAD";
            this.VALOR_CANTIDAD.Name = "VALOR_CANTIDAD";
            this.VALOR_CANTIDAD.ReadOnly = true;
            this.VALOR_CANTIDAD.Visible = false;
            // 
            // VALOR_PRODUCTO
            // 
            this.VALOR_PRODUCTO.DataPropertyName = "VALOR_PRODUCTO";
            this.VALOR_PRODUCTO.HeaderText = "VALOR_PRODUCTO";
            this.VALOR_PRODUCTO.Name = "VALOR_PRODUCTO";
            this.VALOR_PRODUCTO.ReadOnly = true;
            this.VALOR_PRODUCTO.Visible = false;
            // 
            // VALOR_CANAL
            // 
            this.VALOR_CANAL.DataPropertyName = "VALOR_CANAL";
            this.VALOR_CANAL.HeaderText = "VALOR_CANAL";
            this.VALOR_CANAL.Name = "VALOR_CANAL";
            this.VALOR_CANAL.ReadOnly = true;
            this.VALOR_CANAL.Visible = false;
            // 
            // ID_RECOMENDACION
            // 
            this.ID_RECOMENDACION.DataPropertyName = "ID_RECOMENDACION";
            this.ID_RECOMENDACION.HeaderText = "ID_RECOMENDACION";
            this.ID_RECOMENDACION.Name = "ID_RECOMENDACION";
            this.ID_RECOMENDACION.ReadOnly = true;
            this.ID_RECOMENDACION.Visible = false;
            // 
            // RECOMENDACION
            // 
            this.RECOMENDACION.DataPropertyName = "RECOMENDACION";
            this.RECOMENDACION.HeaderText = "RECOMENDACION";
            this.RECOMENDACION.Name = "RECOMENDACION";
            this.RECOMENDACION.ReadOnly = true;
            this.RECOMENDACION.Visible = false;
            // 
            // VALOR_TOTAL
            // 
            this.VALOR_TOTAL.DataPropertyName = "VALOR_TOTAL";
            this.VALOR_TOTAL.HeaderText = "VALOR_TOTAL";
            this.VALOR_TOTAL.Name = "VALOR_TOTAL";
            this.VALOR_TOTAL.ReadOnly = true;
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
            this.btn_editar.Location = new System.Drawing.Point(125, 456);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(101, 43);
            this.btn_editar.TabIndex = 25;
            this.btn_editar.Text = "  Editar";
            this.btn_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_total.Location = new System.Drawing.Point(457, 474);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(377, 25);
            this.lbl_total.TabIndex = 23;
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
            this.btn_agregar.Location = new System.Drawing.Point(21, 456);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(101, 43);
            this.btn_agregar.TabIndex = 24;
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
            this.txt_buscar.CustomButton.Location = new System.Drawing.Point(308, 1);
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
            this.txt_buscar.Location = new System.Drawing.Point(23, 67);
            this.txt_buscar.MaxLength = 32767;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.PasswordChar = '\0';
            this.txt_buscar.PromptText = "Ingrese la Descripción o ID a Buscar";
            this.txt_buscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_buscar.SelectedText = "";
            this.txt_buscar.SelectionLength = 0;
            this.txt_buscar.SelectionStart = 0;
            this.txt_buscar.ShortcutsEnabled = true;
            this.txt_buscar.Size = new System.Drawing.Size(330, 23);
            this.txt_buscar.TabIndex = 22;
            this.txt_buscar.UseSelectable = true;
            this.txt_buscar.WaterMark = "Ingrese la Descripción o ID a Buscar";
            this.txt_buscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_buscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // FRM_MANT_EVALUACIONES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(857, 519);
            this.Controls.Add(this.DG);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_buscar);
            this.Name = "FRM_MANT_EVALUACIONES";
            this.Text = "Evaluaciones de Riesgo";
            this.Load += new System.EventHandler(this.FRM_MANT_EVALUACIONES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG;
        private System.Windows.Forms.Button btn_editar;
        private MetroFramework.Controls.MetroLabel lbl_total;
        private System.Windows.Forms.Button btn_agregar;
        private MetroFramework.Controls.MetroTextBox txt_buscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_EVALUACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDENTIFICACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_OFICINA;
        private System.Windows.Forms.DataGridViewTextBoxColumn OFICINA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ACTIVIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACTIVIDAD_ECONOMICA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_ACTIVIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_NACIONALIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NACIONALIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_NACIONALIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PAIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_PAIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PROVINCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROVINCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_PROVINCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD_EFECTIVO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_CANAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_RECOMENDACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn RECOMENDACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_TOTAL;
    }
}
