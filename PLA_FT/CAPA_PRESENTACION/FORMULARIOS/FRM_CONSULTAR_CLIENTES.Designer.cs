﻿namespace CAPA_PRESENTACION.FORMULARIOS
{
    partial class FRM_CONSULTAR_CLIENTES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_CONSULTAR_CLIENTES));
            this.DG = new System.Windows.Forms.DataGridView();
            this.lbl_total = new MetroFramework.Controls.MetroLabel();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_buscar = new MetroFramework.Controls.MetroTextBox();
            this.ID_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDENTIFICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_OFICINA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFICINA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ID_CLIENTE,
            this.NOMBRES,
            this.IDENTIFICACION,
            this.ID_OFICINA,
            this.OFICINA,
            this.TIPO_CLIENTE});
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
            this.DG.Location = new System.Drawing.Point(16, 94);
            this.DG.MultiSelect = false;
            this.DG.Name = "DG";
            this.DG.ReadOnly = true;
            this.DG.RowHeadersVisible = false;
            this.DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG.Size = new System.Drawing.Size(738, 370);
            this.DG.TabIndex = 16;
            this.DG.DoubleClick += new System.EventHandler(this.DG_DoubleClick);
            // 
            // lbl_total
            // 
            this.lbl_total.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_total.Location = new System.Drawing.Point(378, 489);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(377, 25);
            this.lbl_total.TabIndex = 13;
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_total.Click += new System.EventHandler(this.lbl_total_Click);
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
            this.btn_agregar.Location = new System.Drawing.Point(15, 468);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(129, 43);
            this.btn_agregar.TabIndex = 14;
            this.btn_agregar.Text = "  Seleccionar";
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
            this.txt_buscar.Location = new System.Drawing.Point(14, 65);
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
            this.txt_buscar.TabIndex = 12;
            this.txt_buscar.UseSelectable = true;
            this.txt_buscar.WaterMark = "Ingrese la Descripción o ID a Buscar";
            this.txt_buscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_buscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // ID_CLIENTE
            // 
            this.ID_CLIENTE.DataPropertyName = "ID_CLIENTE";
            this.ID_CLIENTE.HeaderText = "ID";
            this.ID_CLIENTE.Name = "ID_CLIENTE";
            this.ID_CLIENTE.ReadOnly = true;
            this.ID_CLIENTE.Width = 50;
            // 
            // NOMBRES
            // 
            this.NOMBRES.DataPropertyName = "NOMBRES";
            this.NOMBRES.HeaderText = "NOMBRE";
            this.NOMBRES.Name = "NOMBRES";
            this.NOMBRES.ReadOnly = true;
            this.NOMBRES.Width = 280;
            // 
            // IDENTIFICACION
            // 
            this.IDENTIFICACION.DataPropertyName = "IDENTIFICACION";
            this.IDENTIFICACION.HeaderText = "IDENTIF.";
            this.IDENTIFICACION.Name = "IDENTIFICACION";
            this.IDENTIFICACION.ReadOnly = true;
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
            // TIPO_CLIENTE
            // 
            this.TIPO_CLIENTE.DataPropertyName = "TIPO_CLIENTE";
            this.TIPO_CLIENTE.HeaderText = "TIPO";
            this.TIPO_CLIENTE.Name = "TIPO_CLIENTE";
            this.TIPO_CLIENTE.ReadOnly = true;
            // 
            // FRM_CONSULTAR_CLIENTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(769, 534);
            this.Controls.Add(this.DG);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_buscar);
            this.Name = "FRM_CONSULTAR_CLIENTES";
            this.Text = "Consultar Clientes";
            this.Load += new System.EventHandler(this.FRM_CONSULTAR_CLIENTES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG;
        private MetroFramework.Controls.MetroLabel lbl_total;
        private System.Windows.Forms.Button btn_agregar;
        private MetroFramework.Controls.MetroTextBox txt_buscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDENTIFICACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_OFICINA;
        private System.Windows.Forms.DataGridViewTextBoxColumn OFICINA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_CLIENTE;
    }
}
