namespace CAPA_PRESENTACION.FORMULARIOS
{
    partial class FRM_CLIENTE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_CLIENTE));
            this.btn_agregar = new System.Windows.Forms.Button();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_nombre = new MetroFramework.Controls.MetroTextBox();
            this.txt_id = new MetroFramework.Controls.MetroTextBox();
            this.txt_identificacion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cb_oficina = new System.Windows.Forms.ComboBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_agregar
            // 
            this.btn_agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_agregar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btn_agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar.Image")));
            this.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregar.Location = new System.Drawing.Point(19, 215);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(101, 43);
            this.btn_agregar.TabIndex = 6;
            this.btn_agregar.Text = "  Guardar";
            this.btn_agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.cb_oficina);
            this.metroPanel1.Controls.Add(this.txt_identificacion);
            this.metroPanel1.Controls.Add(this.cb_tipo);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.cb_estado);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.txt_nombre);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(19, 56);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(422, 156);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // cb_tipo
            // 
            this.cb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Items.AddRange(new object[] {
            "",
            "FISICO",
            "JURIDICO"});
            this.cb_tipo.Location = new System.Drawing.Point(16, 110);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(130, 23);
            this.cb_tipo.TabIndex = 11;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(16, 94);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(31, 15);
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "Tipo";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(160, 94);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(43, 15);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Estado";
            // 
            // cb_estado
            // 
            this.cb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "",
            "ACTIVO",
            "INACTIVO"});
            this.cb_estado.Location = new System.Drawing.Point(157, 110);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(108, 23);
            this.cb_estado.TabIndex = 3;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(16, 52);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 15);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Identificación";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(16, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 15);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txt_nombre.CustomButton.Image = null;
            this.txt_nombre.CustomButton.Location = new System.Drawing.Point(367, 1);
            this.txt_nombre.CustomButton.Name = "";
            this.txt_nombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_nombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_nombre.CustomButton.TabIndex = 1;
            this.txt_nombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_nombre.CustomButton.UseSelectable = true;
            this.txt_nombre.CustomButton.Visible = false;
            this.txt_nombre.Lines = new string[0];
            this.txt_nombre.Location = new System.Drawing.Point(16, 26);
            this.txt_nombre.MaxLength = 100;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PasswordChar = '\0';
            this.txt_nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_nombre.SelectedText = "";
            this.txt_nombre.SelectionLength = 0;
            this.txt_nombre.SelectionStart = 0;
            this.txt_nombre.ShortcutsEnabled = true;
            this.txt_nombre.Size = new System.Drawing.Size(389, 23);
            this.txt_nombre.TabIndex = 0;
            this.txt_nombre.UseSelectable = true;
            this.txt_nombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_nombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_id
            // 
            this.txt_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txt_id.CustomButton.Image = null;
            this.txt_id.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.txt_id.CustomButton.Name = "";
            this.txt_id.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_id.CustomButton.TabIndex = 1;
            this.txt_id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_id.CustomButton.UseSelectable = true;
            this.txt_id.CustomButton.Visible = false;
            this.txt_id.Lines = new string[0];
            this.txt_id.Location = new System.Drawing.Point(384, 25);
            this.txt_id.MaxLength = 100;
            this.txt_id.Name = "txt_id";
            this.txt_id.PasswordChar = '\0';
            this.txt_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_id.SelectedText = "";
            this.txt_id.SelectionLength = 0;
            this.txt_id.SelectionStart = 0;
            this.txt_id.ShortcutsEnabled = true;
            this.txt_id.Size = new System.Drawing.Size(64, 23);
            this.txt_id.TabIndex = 7;
            this.txt_id.UseSelectable = true;
            this.txt_id.Visible = false;
            this.txt_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_identificacion
            // 
            this.txt_identificacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txt_identificacion.CustomButton.Image = null;
            this.txt_identificacion.CustomButton.Location = new System.Drawing.Point(108, 1);
            this.txt_identificacion.CustomButton.Name = "";
            this.txt_identificacion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_identificacion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_identificacion.CustomButton.TabIndex = 1;
            this.txt_identificacion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_identificacion.CustomButton.UseSelectable = true;
            this.txt_identificacion.CustomButton.Visible = false;
            this.txt_identificacion.Lines = new string[0];
            this.txt_identificacion.Location = new System.Drawing.Point(16, 68);
            this.txt_identificacion.MaxLength = 100;
            this.txt_identificacion.Name = "txt_identificacion";
            this.txt_identificacion.PasswordChar = '\0';
            this.txt_identificacion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_identificacion.SelectedText = "";
            this.txt_identificacion.SelectionLength = 0;
            this.txt_identificacion.SelectionStart = 0;
            this.txt_identificacion.ShortcutsEnabled = true;
            this.txt_identificacion.Size = new System.Drawing.Size(130, 23);
            this.txt_identificacion.TabIndex = 14;
            this.txt_identificacion.UseSelectable = true;
            this.txt_identificacion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_identificacion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(160, 52);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(46, 15);
            this.metroLabel7.TabIndex = 16;
            this.metroLabel7.Text = "Oficina";
            // 
            // cb_oficina
            // 
            this.cb_oficina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_oficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_oficina.FormattingEnabled = true;
            this.cb_oficina.Location = new System.Drawing.Point(157, 68);
            this.cb_oficina.Name = "cb_oficina";
            this.cb_oficina.Size = new System.Drawing.Size(247, 23);
            this.cb_oficina.TabIndex = 15;
            // 
            // FRM_CLIENTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(463, 283);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.txt_id);
            this.Name = "FRM_CLIENTE";
            this.Load += new System.EventHandler(this.FRM_CLIENTE_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_agregar;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txt_identificacion;
        private System.Windows.Forms.ComboBox cb_tipo;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ComboBox cb_estado;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_nombre;
        private MetroFramework.Controls.MetroTextBox txt_id;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.ComboBox cb_oficina;
    }
}
