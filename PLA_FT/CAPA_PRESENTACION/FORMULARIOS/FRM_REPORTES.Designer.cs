namespace CAPA_PRESENTACION.FORMULARIOS
{
    partial class FRM_REPORTES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_REPORTES));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.ch_incluir_fecha = new System.Windows.Forms.CheckBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dt_fecha2 = new System.Windows.Forms.DateTimePicker();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dt_fecha1 = new System.Windows.Forms.DateTimePicker();
            this.txt_nombre_cliente = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txt_id_cliente = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_id_evaluacion = new MetroFramework.Controls.MetroTextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.button1);
            this.metroPanel1.Controls.Add(this.ch_incluir_fecha);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.dt_fecha2);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.dt_fecha1);
            this.metroPanel1.Controls.Add(this.txt_nombre_cliente);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.txt_id_cliente);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.txt_id_evaluacion);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(18, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(458, 169);
            this.metroPanel1.TabIndex = 11;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(189, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 25);
            this.button1.TabIndex = 22;
            this.button1.Text = "Consultar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ch_incluir_fecha
            // 
            this.ch_incluir_fecha.AutoSize = true;
            this.ch_incluir_fecha.Location = new System.Drawing.Point(346, 121);
            this.ch_incluir_fecha.Name = "ch_incluir_fecha";
            this.ch_incluir_fecha.Size = new System.Drawing.Size(92, 17);
            this.ch_incluir_fecha.TabIndex = 21;
            this.ch_incluir_fecha.Text = "Incluir Fechas";
            this.ch_incluir_fecha.UseVisualStyleBackColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(204, 122);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(38, 15);
            this.metroLabel3.TabIndex = 20;
            this.metroLabel3.Text = "Hasta";
            // 
            // dt_fecha2
            // 
            this.dt_fecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_fecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fecha2.Location = new System.Drawing.Point(244, 119);
            this.dt_fecha2.Name = "dt_fecha2";
            this.dt_fecha2.Size = new System.Drawing.Size(89, 21);
            this.dt_fecha2.TabIndex = 19;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(59, 122);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(42, 15);
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "Desde";
            // 
            // dt_fecha1
            // 
            this.dt_fecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_fecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fecha1.Location = new System.Drawing.Point(104, 119);
            this.dt_fecha1.Name = "dt_fecha1";
            this.dt_fecha1.Size = new System.Drawing.Size(89, 21);
            this.dt_fecha1.TabIndex = 17;
            // 
            // txt_nombre_cliente
            // 
            this.txt_nombre_cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txt_nombre_cliente.CustomButton.Image = null;
            this.txt_nombre_cliente.CustomButton.Location = new System.Drawing.Point(312, 1);
            this.txt_nombre_cliente.CustomButton.Name = "";
            this.txt_nombre_cliente.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_nombre_cliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_nombre_cliente.CustomButton.TabIndex = 1;
            this.txt_nombre_cliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_nombre_cliente.CustomButton.UseSelectable = true;
            this.txt_nombre_cliente.CustomButton.Visible = false;
            this.txt_nombre_cliente.Enabled = false;
            this.txt_nombre_cliente.Lines = new string[0];
            this.txt_nombre_cliente.Location = new System.Drawing.Point(104, 81);
            this.txt_nombre_cliente.MaxLength = 100;
            this.txt_nombre_cliente.Name = "txt_nombre_cliente";
            this.txt_nombre_cliente.PasswordChar = '\0';
            this.txt_nombre_cliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_nombre_cliente.SelectedText = "";
            this.txt_nombre_cliente.SelectionLength = 0;
            this.txt_nombre_cliente.SelectionStart = 0;
            this.txt_nombre_cliente.ShortcutsEnabled = true;
            this.txt_nombre_cliente.Size = new System.Drawing.Size(334, 23);
            this.txt_nombre_cliente.TabIndex = 16;
            this.txt_nombre_cliente.UseSelectable = true;
            this.txt_nombre_cliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_nombre_cliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(40, 59);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(62, 15);
            this.metroLabel5.TabIndex = 15;
            this.metroLabel5.Text = "ID Cliente";
            // 
            // txt_id_cliente
            // 
            this.txt_id_cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txt_id_cliente.CustomButton.Image = null;
            this.txt_id_cliente.CustomButton.Location = new System.Drawing.Point(62, 1);
            this.txt_id_cliente.CustomButton.Name = "";
            this.txt_id_cliente.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_id_cliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_id_cliente.CustomButton.TabIndex = 1;
            this.txt_id_cliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_id_cliente.CustomButton.UseSelectable = true;
            this.txt_id_cliente.CustomButton.Visible = false;
            this.txt_id_cliente.Lines = new string[0];
            this.txt_id_cliente.Location = new System.Drawing.Point(104, 56);
            this.txt_id_cliente.MaxLength = 100;
            this.txt_id_cliente.Name = "txt_id_cliente";
            this.txt_id_cliente.PasswordChar = '\0';
            this.txt_id_cliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_id_cliente.SelectedText = "";
            this.txt_id_cliente.SelectionLength = 0;
            this.txt_id_cliente.SelectionStart = 0;
            this.txt_id_cliente.ShortcutsEnabled = true;
            this.txt_id_cliente.Size = new System.Drawing.Size(84, 23);
            this.txt_id_cliente.TabIndex = 14;
            this.txt_id_cliente.UseSelectable = true;
            this.txt_id_cliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_id_cliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(20, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 15);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "ID Evaluación";
            // 
            // txt_id_evaluacion
            // 
            this.txt_id_evaluacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txt_id_evaluacion.CustomButton.Image = null;
            this.txt_id_evaluacion.CustomButton.Location = new System.Drawing.Point(62, 1);
            this.txt_id_evaluacion.CustomButton.Name = "";
            this.txt_id_evaluacion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_id_evaluacion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_id_evaluacion.CustomButton.TabIndex = 1;
            this.txt_id_evaluacion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_id_evaluacion.CustomButton.UseSelectable = true;
            this.txt_id_evaluacion.CustomButton.Visible = false;
            this.txt_id_evaluacion.Lines = new string[0];
            this.txt_id_evaluacion.Location = new System.Drawing.Point(104, 20);
            this.txt_id_evaluacion.MaxLength = 100;
            this.txt_id_evaluacion.Name = "txt_id_evaluacion";
            this.txt_id_evaluacion.PasswordChar = '\0';
            this.txt_id_evaluacion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_id_evaluacion.SelectedText = "";
            this.txt_id_evaluacion.SelectionLength = 0;
            this.txt_id_evaluacion.SelectionStart = 0;
            this.txt_id_evaluacion.ShortcutsEnabled = true;
            this.txt_id_evaluacion.Size = new System.Drawing.Size(84, 23);
            this.txt_id_evaluacion.TabIndex = 2;
            this.txt_id_evaluacion.UseSelectable = true;
            this.txt_id_evaluacion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_id_evaluacion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.btn_agregar.Location = new System.Drawing.Point(18, 236);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(135, 43);
            this.btn_agregar.TabIndex = 12;
            this.btn_agregar.Text = "  Ver Listado";
            this.btn_agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(157, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 43);
            this.button2.TabIndex = 13;
            this.button2.Text = "  Ver Detalles";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FRM_REPORTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(495, 298);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.metroPanel1);
            this.Name = "FRM_REPORTES";
            this.Text = "Reportes";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_agregar;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_id_evaluacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ch_incluir_fecha;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DateTimePicker dt_fecha2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DateTimePicker dt_fecha1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        public MetroFramework.Controls.MetroTextBox txt_nombre_cliente;
        public MetroFramework.Controls.MetroTextBox txt_id_cliente;
        private System.Windows.Forms.Button button2;
    }
}
