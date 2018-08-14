namespace CAPA_PRESENTACION.FORMULARIOS
{
    partial class FRM_USUARIO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_USUARIO));
            this.btn_agregar = new System.Windows.Forms.Button();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.cb_sexo = new System.Windows.Forms.ComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txt_clave = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txt_usuario = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cb_puesto = new System.Windows.Forms.ComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cb_departamento = new System.Windows.Forms.ComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cb_oficina = new System.Windows.Forms.ComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_nombre = new MetroFramework.Controls.MetroTextBox();
            this.txt_id = new MetroFramework.Controls.MetroTextBox();
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
            this.btn_agregar.Location = new System.Drawing.Point(12, 261);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(101, 43);
            this.btn_agregar.TabIndex = 12;
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
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.cb_sexo);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.txt_clave);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.txt_usuario);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.cb_puesto);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.cb_departamento);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.cb_oficina);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.cb_estado);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.txt_nombre);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(12, 69);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(468, 186);
            this.metroPanel1.TabIndex = 11;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(65, 149);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(35, 15);
            this.metroLabel8.TabIndex = 21;
            this.metroLabel8.Text = "Sexo";
            // 
            // cb_sexo
            // 
            this.cb_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sexo.FormattingEnabled = true;
            this.cb_sexo.Items.AddRange(new object[] {
            "",
            "MASCULINO",
            "FEMENINO"});
            this.cb_sexo.Location = new System.Drawing.Point(102, 146);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(121, 23);
            this.cb_sexo.TabIndex = 6;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(251, 125);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(37, 15);
            this.metroLabel7.TabIndex = 19;
            this.metroLabel7.Text = "Clave";
            // 
            // txt_clave
            // 
            this.txt_clave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txt_clave.CustomButton.Image = null;
            this.txt_clave.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.txt_clave.CustomButton.Name = "";
            this.txt_clave.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_clave.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_clave.CustomButton.TabIndex = 1;
            this.txt_clave.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_clave.CustomButton.UseSelectable = true;
            this.txt_clave.CustomButton.Visible = false;
            this.txt_clave.Lines = new string[0];
            this.txt_clave.Location = new System.Drawing.Point(290, 120);
            this.txt_clave.MaxLength = 100;
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.PasswordChar = '●';
            this.txt_clave.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_clave.SelectedText = "";
            this.txt_clave.SelectionLength = 0;
            this.txt_clave.SelectionStart = 0;
            this.txt_clave.ShortcutsEnabled = true;
            this.txt_clave.Size = new System.Drawing.Size(152, 23);
            this.txt_clave.TabIndex = 5;
            this.txt_clave.UseSelectable = true;
            this.txt_clave.UseSystemPasswordChar = true;
            this.txt_clave.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_clave.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(51, 125);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(49, 15);
            this.metroLabel6.TabIndex = 17;
            this.metroLabel6.Text = "Usuario";
            // 
            // txt_usuario
            // 
            this.txt_usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txt_usuario.CustomButton.Image = null;
            this.txt_usuario.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txt_usuario.CustomButton.Name = "";
            this.txt_usuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_usuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_usuario.CustomButton.TabIndex = 1;
            this.txt_usuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_usuario.CustomButton.UseSelectable = true;
            this.txt_usuario.CustomButton.Visible = false;
            this.txt_usuario.Lines = new string[0];
            this.txt_usuario.Location = new System.Drawing.Point(102, 120);
            this.txt_usuario.MaxLength = 100;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.PasswordChar = '\0';
            this.txt_usuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_usuario.SelectedText = "";
            this.txt_usuario.SelectionLength = 0;
            this.txt_usuario.SelectionStart = 0;
            this.txt_usuario.ShortcutsEnabled = true;
            this.txt_usuario.Size = new System.Drawing.Size(121, 23);
            this.txt_usuario.TabIndex = 4;
            this.txt_usuario.UseSelectable = true;
            this.txt_usuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_usuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(48, 99);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(53, 15);
            this.metroLabel5.TabIndex = 15;
            this.metroLabel5.Text = "Nombre";
            // 
            // cb_puesto
            // 
            this.cb_puesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_puesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_puesto.FormattingEnabled = true;
            this.cb_puesto.Location = new System.Drawing.Point(102, 68);
            this.cb_puesto.Name = "cb_puesto";
            this.cb_puesto.Size = new System.Drawing.Size(339, 23);
            this.cb_puesto.TabIndex = 2;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(12, 45);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(89, 15);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Departamento";
            // 
            // cb_departamento
            // 
            this.cb_departamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_departamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_departamento.FormattingEnabled = true;
            this.cb_departamento.Location = new System.Drawing.Point(102, 42);
            this.cb_departamento.Name = "cb_departamento";
            this.cb_departamento.Size = new System.Drawing.Size(339, 23);
            this.cb_departamento.TabIndex = 1;
            this.cb_departamento.SelectedIndexChanged += new System.EventHandler(this.cb_departamento_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(55, 19);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 15);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Oficina";
            // 
            // cb_oficina
            // 
            this.cb_oficina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_oficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_oficina.FormattingEnabled = true;
            this.cb_oficina.Location = new System.Drawing.Point(102, 16);
            this.cb_oficina.Name = "cb_oficina";
            this.cb_oficina.Size = new System.Drawing.Size(339, 23);
            this.cb_oficina.TabIndex = 0;
            this.cb_oficina.SelectedIndexChanged += new System.EventHandler(this.cb_oficina_SelectedIndexChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(245, 149);
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
            this.cb_estado.Location = new System.Drawing.Point(290, 146);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(151, 23);
            this.cb_estado.TabIndex = 7;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(56, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 15);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Puesto";
            // 
            // txt_nombre
            // 
            this.txt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txt_nombre.CustomButton.Image = null;
            this.txt_nombre.CustomButton.Location = new System.Drawing.Point(318, 1);
            this.txt_nombre.CustomButton.Name = "";
            this.txt_nombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_nombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_nombre.CustomButton.TabIndex = 1;
            this.txt_nombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_nombre.CustomButton.UseSelectable = true;
            this.txt_nombre.CustomButton.Visible = false;
            this.txt_nombre.Lines = new string[0];
            this.txt_nombre.Location = new System.Drawing.Point(102, 94);
            this.txt_nombre.MaxLength = 100;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PasswordChar = '\0';
            this.txt_nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_nombre.SelectedText = "";
            this.txt_nombre.SelectionLength = 0;
            this.txt_nombre.SelectionStart = 0;
            this.txt_nombre.ShortcutsEnabled = true;
            this.txt_nombre.Size = new System.Drawing.Size(340, 23);
            this.txt_nombre.TabIndex = 3;
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
            this.txt_id.Location = new System.Drawing.Point(416, 42);
            this.txt_id.MaxLength = 100;
            this.txt_id.Name = "txt_id";
            this.txt_id.PasswordChar = '\0';
            this.txt_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_id.SelectedText = "";
            this.txt_id.SelectionLength = 0;
            this.txt_id.SelectionStart = 0;
            this.txt_id.ShortcutsEnabled = true;
            this.txt_id.Size = new System.Drawing.Size(64, 23);
            this.txt_id.TabIndex = 13;
            this.txt_id.UseSelectable = true;
            this.txt_id.Visible = false;
            this.txt_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FRM_USUARIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(494, 316);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.txt_id);
            this.Name = "FRM_USUARIO";
            this.Load += new System.EventHandler(this.FRM_USUARIO_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_agregar;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ComboBox cb_departamento;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ComboBox cb_oficina;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ComboBox cb_estado;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_nombre;
        private MetroFramework.Controls.MetroTextBox txt_id;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.ComboBox cb_sexo;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txt_clave;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txt_usuario;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.ComboBox cb_puesto;
    }
}
