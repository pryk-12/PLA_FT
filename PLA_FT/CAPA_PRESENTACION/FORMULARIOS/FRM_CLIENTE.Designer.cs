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
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cb_oficina = new System.Windows.Forms.ComboBox();
            this.txt_identificacion = new MetroFramework.Controls.MetroTextBox();
            this.cb_tipo_cliente = new System.Windows.Forms.ComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_nombres = new MetroFramework.Controls.MetroTextBox();
            this.txt_id = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_apellido_pat = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txt_apellido_mat = new MetroFramework.Controls.MetroTextBox();
            this.cb_tipo_identificacion = new System.Windows.Forms.ComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.cb_lugar_nacimiento = new System.Windows.Forms.ComboBox();
            this.dt_fecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.cb_pais_nacionalidad = new System.Windows.Forms.ComboBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.cb_estado_civil = new System.Windows.Forms.ComboBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.cb_sexo = new System.Windows.Forms.ComboBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.cb_ocupacion = new System.Windows.Forms.ComboBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.txt_email = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.txt_direccion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.cb_provincia = new System.Windows.Forms.ComboBox();
            this.txt_celular = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.txt_telefono = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.cb_tipo_vivienda = new System.Windows.Forms.ComboBox();
            this.ch_pep = new System.Windows.Forms.CheckBox();
            this.ch_vinculado_pep = new System.Windows.Forms.CheckBox();
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
            this.btn_agregar.Location = new System.Drawing.Point(19, 573);
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
            this.metroPanel1.Controls.Add(this.ch_vinculado_pep);
            this.metroPanel1.Controls.Add(this.ch_pep);
            this.metroPanel1.Controls.Add(this.metroLabel20);
            this.metroPanel1.Controls.Add(this.cb_estado_civil);
            this.metroPanel1.Controls.Add(this.metroLabel12);
            this.metroPanel1.Controls.Add(this.cb_tipo_vivienda);
            this.metroPanel1.Controls.Add(this.txt_celular);
            this.metroPanel1.Controls.Add(this.metroLabel18);
            this.metroPanel1.Controls.Add(this.txt_telefono);
            this.metroPanel1.Controls.Add(this.metroLabel19);
            this.metroPanel1.Controls.Add(this.metroLabel17);
            this.metroPanel1.Controls.Add(this.cb_provincia);
            this.metroPanel1.Controls.Add(this.metroLabel16);
            this.metroPanel1.Controls.Add(this.txt_direccion);
            this.metroPanel1.Controls.Add(this.metroLabel15);
            this.metroPanel1.Controls.Add(this.txt_email);
            this.metroPanel1.Controls.Add(this.metroLabel14);
            this.metroPanel1.Controls.Add(this.cb_ocupacion);
            this.metroPanel1.Controls.Add(this.metroLabel13);
            this.metroPanel1.Controls.Add(this.cb_sexo);
            this.metroPanel1.Controls.Add(this.metroLabel11);
            this.metroPanel1.Controls.Add(this.cb_pais_nacionalidad);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.Controls.Add(this.dt_fecha_nacimiento);
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.Controls.Add(this.cb_lugar_nacimiento);
            this.metroPanel1.Controls.Add(this.cb_tipo_identificacion);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.txt_apellido_mat);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.txt_apellido_pat);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.cb_oficina);
            this.metroPanel1.Controls.Add(this.txt_identificacion);
            this.metroPanel1.Controls.Add(this.cb_tipo_cliente);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.cb_estado);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.txt_nombres);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(19, 56);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(425, 514);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(19, 134);
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
            this.cb_oficina.Location = new System.Drawing.Point(16, 150);
            this.cb_oficina.Name = "cb_oficina";
            this.cb_oficina.Size = new System.Drawing.Size(389, 23);
            this.cb_oficina.TabIndex = 7;
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
            this.txt_identificacion.Location = new System.Drawing.Point(151, 110);
            this.txt_identificacion.MaxLength = 100;
            this.txt_identificacion.Name = "txt_identificacion";
            this.txt_identificacion.PasswordChar = '\0';
            this.txt_identificacion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_identificacion.SelectedText = "";
            this.txt_identificacion.SelectionLength = 0;
            this.txt_identificacion.SelectionStart = 0;
            this.txt_identificacion.ShortcutsEnabled = true;
            this.txt_identificacion.Size = new System.Drawing.Size(130, 23);
            this.txt_identificacion.TabIndex = 5;
            this.txt_identificacion.UseSelectable = true;
            this.txt_identificacion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_identificacion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_identificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_identificacion_KeyPress);
            // 
            // cb_tipo_cliente
            // 
            this.cb_tipo_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipo_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tipo_cliente.FormattingEnabled = true;
            this.cb_tipo_cliente.Items.AddRange(new object[] {
            "",
            "FISICO",
            "JURIDICO"});
            this.cb_tipo_cliente.Location = new System.Drawing.Point(288, 68);
            this.cb_tipo_cliente.Name = "cb_tipo_cliente";
            this.cb_tipo_cliente.Size = new System.Drawing.Size(117, 23);
            this.cb_tipo_cliente.TabIndex = 3;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(288, 52);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(73, 15);
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "Tipo Cliente";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(290, 94);
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
            this.cb_estado.Location = new System.Drawing.Point(287, 110);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(118, 23);
            this.cb_estado.TabIndex = 6;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(151, 94);
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
            // txt_nombres
            // 
            this.txt_nombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txt_nombres.CustomButton.Image = null;
            this.txt_nombres.CustomButton.Location = new System.Drawing.Point(367, 1);
            this.txt_nombres.CustomButton.Name = "";
            this.txt_nombres.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_nombres.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_nombres.CustomButton.TabIndex = 1;
            this.txt_nombres.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_nombres.CustomButton.UseSelectable = true;
            this.txt_nombres.CustomButton.Visible = false;
            this.txt_nombres.Lines = new string[0];
            this.txt_nombres.Location = new System.Drawing.Point(16, 26);
            this.txt_nombres.MaxLength = 100;
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.PasswordChar = '\0';
            this.txt_nombres.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_nombres.SelectedText = "";
            this.txt_nombres.SelectionLength = 0;
            this.txt_nombres.SelectionStart = 0;
            this.txt_nombres.ShortcutsEnabled = true;
            this.txt_nombres.Size = new System.Drawing.Size(389, 23);
            this.txt_nombres.TabIndex = 0;
            this.txt_nombres.UseSelectable = true;
            this.txt_nombres.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_nombres.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txt_id.Location = new System.Drawing.Point(387, 25);
            this.txt_id.MaxLength = 100;
            this.txt_id.Name = "txt_id";
            this.txt_id.PasswordChar = '\0';
            this.txt_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_id.SelectedText = "";
            this.txt_id.SelectionLength = 0;
            this.txt_id.SelectionStart = 0;
            this.txt_id.ShortcutsEnabled = true;
            this.txt_id.Size = new System.Drawing.Size(57, 23);
            this.txt_id.TabIndex = 7;
            this.txt_id.UseSelectable = true;
            this.txt_id.Visible = false;
            this.txt_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(16, 52);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(99, 15);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "Apellido Paterno";
            // 
            // txt_apellido_pat
            // 
            this.txt_apellido_pat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txt_apellido_pat.CustomButton.Image = null;
            this.txt_apellido_pat.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.txt_apellido_pat.CustomButton.Name = "";
            this.txt_apellido_pat.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_apellido_pat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_apellido_pat.CustomButton.TabIndex = 1;
            this.txt_apellido_pat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_apellido_pat.CustomButton.UseSelectable = true;
            this.txt_apellido_pat.CustomButton.Visible = false;
            this.txt_apellido_pat.Lines = new string[0];
            this.txt_apellido_pat.Location = new System.Drawing.Point(16, 68);
            this.txt_apellido_pat.MaxLength = 100;
            this.txt_apellido_pat.Name = "txt_apellido_pat";
            this.txt_apellido_pat.PasswordChar = '\0';
            this.txt_apellido_pat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_apellido_pat.SelectedText = "";
            this.txt_apellido_pat.SelectionLength = 0;
            this.txt_apellido_pat.SelectionStart = 0;
            this.txt_apellido_pat.ShortcutsEnabled = true;
            this.txt_apellido_pat.Size = new System.Drawing.Size(131, 23);
            this.txt_apellido_pat.TabIndex = 1;
            this.txt_apellido_pat.UseSelectable = true;
            this.txt_apellido_pat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_apellido_pat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(151, 52);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(103, 15);
            this.metroLabel6.TabIndex = 20;
            this.metroLabel6.Text = "Apellido Materno";
            // 
            // txt_apellido_mat
            // 
            this.txt_apellido_mat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txt_apellido_mat.CustomButton.Image = null;
            this.txt_apellido_mat.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.txt_apellido_mat.CustomButton.Name = "";
            this.txt_apellido_mat.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_apellido_mat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_apellido_mat.CustomButton.TabIndex = 1;
            this.txt_apellido_mat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_apellido_mat.CustomButton.UseSelectable = true;
            this.txt_apellido_mat.CustomButton.Visible = false;
            this.txt_apellido_mat.Lines = new string[0];
            this.txt_apellido_mat.Location = new System.Drawing.Point(151, 68);
            this.txt_apellido_mat.MaxLength = 100;
            this.txt_apellido_mat.Name = "txt_apellido_mat";
            this.txt_apellido_mat.PasswordChar = '\0';
            this.txt_apellido_mat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_apellido_mat.SelectedText = "";
            this.txt_apellido_mat.SelectionLength = 0;
            this.txt_apellido_mat.SelectionStart = 0;
            this.txt_apellido_mat.ShortcutsEnabled = true;
            this.txt_apellido_mat.Size = new System.Drawing.Size(131, 23);
            this.txt_apellido_mat.TabIndex = 2;
            this.txt_apellido_mat.UseSelectable = true;
            this.txt_apellido_mat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_apellido_mat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cb_tipo_identificacion
            // 
            this.cb_tipo_identificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipo_identificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tipo_identificacion.FormattingEnabled = true;
            this.cb_tipo_identificacion.Items.AddRange(new object[] {
            "",
            "FISICO",
            "JURIDICO"});
            this.cb_tipo_identificacion.Location = new System.Drawing.Point(16, 110);
            this.cb_tipo_identificacion.Name = "cb_tipo_identificacion";
            this.cb_tipo_identificacion.Size = new System.Drawing.Size(130, 23);
            this.cb_tipo_identificacion.TabIndex = 4;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(16, 94);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(110, 15);
            this.metroLabel8.TabIndex = 22;
            this.metroLabel8.Text = "Tipo Identificación";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(19, 176);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(105, 15);
            this.metroLabel9.TabIndex = 24;
            this.metroLabel9.Text = "Lugar Nacimiento";
            // 
            // cb_lugar_nacimiento
            // 
            this.cb_lugar_nacimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_lugar_nacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_lugar_nacimiento.FormattingEnabled = true;
            this.cb_lugar_nacimiento.Location = new System.Drawing.Point(16, 192);
            this.cb_lugar_nacimiento.Name = "cb_lugar_nacimiento";
            this.cb_lugar_nacimiento.Size = new System.Drawing.Size(279, 23);
            this.cb_lugar_nacimiento.TabIndex = 8;
            // 
            // dt_fecha_nacimiento
            // 
            this.dt_fecha_nacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_fecha_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fecha_nacimiento.Location = new System.Drawing.Point(301, 192);
            this.dt_fecha_nacimiento.Name = "dt_fecha_nacimiento";
            this.dt_fecha_nacimiento.Size = new System.Drawing.Size(104, 23);
            this.dt_fecha_nacimiento.TabIndex = 9;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(298, 176);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(106, 15);
            this.metroLabel10.TabIndex = 26;
            this.metroLabel10.Text = "Fecha Nacimiento";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.Location = new System.Drawing.Point(19, 219);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(101, 15);
            this.metroLabel11.TabIndex = 28;
            this.metroLabel11.Text = "Pais Nacionalidad";
            // 
            // cb_pais_nacionalidad
            // 
            this.cb_pais_nacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_pais_nacionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_pais_nacionalidad.FormattingEnabled = true;
            this.cb_pais_nacionalidad.Location = new System.Drawing.Point(16, 235);
            this.cb_pais_nacionalidad.Name = "cb_pais_nacionalidad";
            this.cb_pais_nacionalidad.Size = new System.Drawing.Size(389, 23);
            this.cb_pais_nacionalidad.TabIndex = 10;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel12.Location = new System.Drawing.Point(125, 262);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(69, 15);
            this.metroLabel12.TabIndex = 30;
            this.metroLabel12.Text = "Estado Civil";
            // 
            // cb_estado_civil
            // 
            this.cb_estado_civil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_estado_civil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_estado_civil.FormattingEnabled = true;
            this.cb_estado_civil.Items.AddRange(new object[] {
            "",
            "SOLTERO"});
            this.cb_estado_civil.Location = new System.Drawing.Point(122, 278);
            this.cb_estado_civil.Name = "cb_estado_civil";
            this.cb_estado_civil.Size = new System.Drawing.Size(105, 23);
            this.cb_estado_civil.TabIndex = 11;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel13.Location = new System.Drawing.Point(19, 262);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(35, 15);
            this.metroLabel13.TabIndex = 32;
            this.metroLabel13.Text = "Sexo";
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
            this.cb_sexo.Location = new System.Drawing.Point(16, 278);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(101, 23);
            this.cb_sexo.TabIndex = 12;
            this.cb_sexo.SelectedIndexChanged += new System.EventHandler(this.cb_sexo_SelectedIndexChanged);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel14.Location = new System.Drawing.Point(232, 262);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(65, 15);
            this.metroLabel14.TabIndex = 34;
            this.metroLabel14.Text = "Ocupación";
            // 
            // cb_ocupacion
            // 
            this.cb_ocupacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ocupacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ocupacion.FormattingEnabled = true;
            this.cb_ocupacion.Items.AddRange(new object[] {
            "",
            "ACTIVO",
            "INACTIVO"});
            this.cb_ocupacion.Location = new System.Drawing.Point(233, 278);
            this.cb_ocupacion.Name = "cb_ocupacion";
            this.cb_ocupacion.Size = new System.Drawing.Size(172, 23);
            this.cb_ocupacion.TabIndex = 13;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel15.Location = new System.Drawing.Point(16, 305);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(41, 15);
            this.metroLabel15.TabIndex = 36;
            this.metroLabel15.Text = "E-Mail";
            // 
            // txt_email
            // 
            this.txt_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txt_email.CustomButton.Image = null;
            this.txt_email.CustomButton.Location = new System.Drawing.Point(256, 1);
            this.txt_email.CustomButton.Name = "";
            this.txt_email.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_email.CustomButton.TabIndex = 1;
            this.txt_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_email.CustomButton.UseSelectable = true;
            this.txt_email.CustomButton.Visible = false;
            this.txt_email.Lines = new string[0];
            this.txt_email.Location = new System.Drawing.Point(16, 321);
            this.txt_email.MaxLength = 100;
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_email.SelectedText = "";
            this.txt_email.SelectionLength = 0;
            this.txt_email.SelectionStart = 0;
            this.txt_email.ShortcutsEnabled = true;
            this.txt_email.Size = new System.Drawing.Size(278, 23);
            this.txt_email.TabIndex = 14;
            this.txt_email.UseSelectable = true;
            this.txt_email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel16.Location = new System.Drawing.Point(16, 348);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(60, 15);
            this.metroLabel16.TabIndex = 38;
            this.metroLabel16.Text = "Dirección";
            // 
            // txt_direccion
            // 
            this.txt_direccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txt_direccion.CustomButton.Image = null;
            this.txt_direccion.CustomButton.Location = new System.Drawing.Point(345, 2);
            this.txt_direccion.CustomButton.Name = "";
            this.txt_direccion.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.txt_direccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_direccion.CustomButton.TabIndex = 1;
            this.txt_direccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_direccion.CustomButton.UseSelectable = true;
            this.txt_direccion.CustomButton.Visible = false;
            this.txt_direccion.Lines = new string[0];
            this.txt_direccion.Location = new System.Drawing.Point(16, 364);
            this.txt_direccion.MaxLength = 100;
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.PasswordChar = '\0';
            this.txt_direccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_direccion.SelectedText = "";
            this.txt_direccion.SelectionLength = 0;
            this.txt_direccion.SelectionStart = 0;
            this.txt_direccion.ShortcutsEnabled = true;
            this.txt_direccion.Size = new System.Drawing.Size(389, 46);
            this.txt_direccion.TabIndex = 16;
            this.txt_direccion.UseSelectable = true;
            this.txt_direccion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_direccion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel17.Location = new System.Drawing.Point(19, 415);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(120, 15);
            this.metroLabel17.TabIndex = 40;
            this.metroLabel17.Text = "Provincia Residencia";
            // 
            // cb_provincia
            // 
            this.cb_provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_provincia.FormattingEnabled = true;
            this.cb_provincia.Location = new System.Drawing.Point(16, 431);
            this.cb_provincia.Name = "cb_provincia";
            this.cb_provincia.Size = new System.Drawing.Size(389, 23);
            this.cb_provincia.TabIndex = 17;
            // 
            // txt_celular
            // 
            this.txt_celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_celular.Location = new System.Drawing.Point(111, 474);
            this.txt_celular.Mask = "000-000-0000";
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.PromptChar = ' ';
            this.txt_celular.Size = new System.Drawing.Size(88, 23);
            this.txt_celular.TabIndex = 19;
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel18.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel18.Location = new System.Drawing.Point(110, 458);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(44, 15);
            this.metroLabel18.TabIndex = 44;
            this.metroLabel18.Text = "Calular";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.Location = new System.Drawing.Point(16, 474);
            this.txt_telefono.Mask = "000-000-0000";
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.PromptChar = ' ';
            this.txt_telefono.Size = new System.Drawing.Size(85, 23);
            this.txt_telefono.TabIndex = 18;
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel19.Location = new System.Drawing.Point(16, 458);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(56, 15);
            this.metroLabel19.TabIndex = 43;
            this.metroLabel19.Text = "Teléfono";
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel20.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel20.Location = new System.Drawing.Point(303, 305);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(82, 15);
            this.metroLabel20.TabIndex = 46;
            this.metroLabel20.Text = "Tipo Vivienda";
            // 
            // cb_tipo_vivienda
            // 
            this.cb_tipo_vivienda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipo_vivienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tipo_vivienda.FormattingEnabled = true;
            this.cb_tipo_vivienda.Items.AddRange(new object[] {
            "",
            "PROPIA",
            "ALQUILADA",
            "FAMILIAR",
            "OTRO"});
            this.cb_tipo_vivienda.Location = new System.Drawing.Point(300, 321);
            this.cb_tipo_vivienda.Name = "cb_tipo_vivienda";
            this.cb_tipo_vivienda.Size = new System.Drawing.Size(105, 23);
            this.cb_tipo_vivienda.TabIndex = 15;
            // 
            // ch_pep
            // 
            this.ch_pep.AutoSize = true;
            this.ch_pep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_pep.Location = new System.Drawing.Point(218, 477);
            this.ch_pep.Name = "ch_pep";
            this.ch_pep.Size = new System.Drawing.Size(50, 17);
            this.ch_pep.TabIndex = 20;
            this.ch_pep.Text = "PEP";
            this.ch_pep.UseVisualStyleBackColor = true;
            // 
            // ch_vinculado_pep
            // 
            this.ch_vinculado_pep.AutoSize = true;
            this.ch_vinculado_pep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_vinculado_pep.Location = new System.Drawing.Point(284, 477);
            this.ch_vinculado_pep.Name = "ch_vinculado_pep";
            this.ch_vinculado_pep.Size = new System.Drawing.Size(121, 17);
            this.ch_vinculado_pep.TabIndex = 21;
            this.ch_vinculado_pep.Text = "Vinculado a PEP";
            this.ch_vinculado_pep.UseVisualStyleBackColor = true;
            // 
            // FRM_CLIENTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(466, 641);
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
        private System.Windows.Forms.ComboBox cb_tipo_cliente;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ComboBox cb_estado;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_nombres;
        private MetroFramework.Controls.MetroTextBox txt_id;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.ComboBox cb_oficina;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private System.Windows.Forms.ComboBox cb_provincia;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox txt_direccion;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTextBox txt_email;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private System.Windows.Forms.ComboBox cb_ocupacion;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private System.Windows.Forms.ComboBox cb_sexo;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private System.Windows.Forms.ComboBox cb_estado_civil;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.ComboBox cb_pais_nacionalidad;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.DateTimePicker dt_fecha_nacimiento;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.ComboBox cb_lugar_nacimiento;
        private System.Windows.Forms.ComboBox cb_tipo_identificacion;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txt_apellido_mat;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_apellido_pat;
        private System.Windows.Forms.CheckBox ch_vinculado_pep;
        private System.Windows.Forms.CheckBox ch_pep;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private System.Windows.Forms.ComboBox cb_tipo_vivienda;
        private System.Windows.Forms.MaskedTextBox txt_celular;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private System.Windows.Forms.MaskedTextBox txt_telefono;
        private MetroFramework.Controls.MetroLabel metroLabel19;
    }
}
