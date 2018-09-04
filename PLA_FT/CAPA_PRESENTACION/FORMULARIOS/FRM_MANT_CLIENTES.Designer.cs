namespace CAPA_PRESENTACION.FORMULARIOS
{
    partial class FRM_MANT_CLIENTES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_MANT_CLIENTES));
            this.DG = new System.Windows.Forms.DataGridView();
            this.btn_editar = new System.Windows.Forms.Button();
            this.lbl_total = new MetroFramework.Controls.MetroLabel();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_buscar = new MetroFramework.Controls.MetroTextBox();
            this.ID_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDO_PAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDO_MAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_TIPO_IDENTIFICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_IDENTIFICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDENTIFICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_OFICINA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFICINA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_LUGAR_NACIMIENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LUGAR_NACIMIENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_NACIMIENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_NACIONALIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NACIONALIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO_CIVIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEXO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_OCUPACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OCUPACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECCION_RESIDENCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PROVINCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CELULAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_VIVIENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ES_PEP = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.VINCULADO_PEP = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.APELLIDO_PAT,
            this.APELLIDO_MAT,
            this.TIPO_CLIENTE,
            this.ID_TIPO_IDENTIFICACION,
            this.TIPO_IDENTIFICACION,
            this.IDENTIFICACION,
            this.ID_OFICINA,
            this.OFICINA,
            this.ID_LUGAR_NACIMIENTO,
            this.LUGAR_NACIMIENTO,
            this.FECHA_NACIMIENTO,
            this.ID_NACIONALIDAD,
            this.NACIONALIDAD,
            this.ESTADO_CIVIL,
            this.SEXO,
            this.ID_OCUPACION,
            this.OCUPACION,
            this.EMAIL,
            this.DIRECCION_RESIDENCIAL,
            this.ID_PROVINCIA,
            this.TELEFONO,
            this.CELULAR,
            this.TIPO_VIVIENDA,
            this.ES_PEP,
            this.VINCULADO_PEP,
            this.ESTADO});
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
            this.DG.Location = new System.Drawing.Point(12, 87);
            this.DG.MultiSelect = false;
            this.DG.Name = "DG";
            this.DG.ReadOnly = true;
            this.DG.RowHeadersVisible = false;
            this.DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG.Size = new System.Drawing.Size(950, 439);
            this.DG.TabIndex = 11;
            this.DG.DoubleClick += new System.EventHandler(this.DG_DoubleClick);
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
            this.btn_editar.Location = new System.Drawing.Point(116, 532);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(101, 43);
            this.btn_editar.TabIndex = 10;
            this.btn_editar.Text = "  Editar";
            this.btn_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_total.Location = new System.Drawing.Point(443, 410);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(377, 25);
            this.lbl_total.TabIndex = 8;
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
            this.btn_agregar.Location = new System.Drawing.Point(12, 532);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(101, 43);
            this.btn_agregar.TabIndex = 9;
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
            this.txt_buscar.Location = new System.Drawing.Point(12, 58);
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
            this.txt_buscar.TabIndex = 7;
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
            this.NOMBRES.HeaderText = "NOMBRES";
            this.NOMBRES.Name = "NOMBRES";
            this.NOMBRES.ReadOnly = true;
            this.NOMBRES.Width = 250;
            // 
            // APELLIDO_PAT
            // 
            this.APELLIDO_PAT.DataPropertyName = "APELLIDO_PAT";
            this.APELLIDO_PAT.HeaderText = "APE PAT";
            this.APELLIDO_PAT.Name = "APELLIDO_PAT";
            this.APELLIDO_PAT.ReadOnly = true;
            // 
            // APELLIDO_MAT
            // 
            this.APELLIDO_MAT.DataPropertyName = "APELLIDO_MAT";
            this.APELLIDO_MAT.HeaderText = "APE MAT";
            this.APELLIDO_MAT.Name = "APELLIDO_MAT";
            this.APELLIDO_MAT.ReadOnly = true;
            // 
            // TIPO_CLIENTE
            // 
            this.TIPO_CLIENTE.DataPropertyName = "TIPO_CLIENTE";
            this.TIPO_CLIENTE.HeaderText = "TIPO_CLIENTE";
            this.TIPO_CLIENTE.Name = "TIPO_CLIENTE";
            this.TIPO_CLIENTE.ReadOnly = true;
            // 
            // ID_TIPO_IDENTIFICACION
            // 
            this.ID_TIPO_IDENTIFICACION.DataPropertyName = "ID_TIPO_IDENTIFICACION";
            this.ID_TIPO_IDENTIFICACION.HeaderText = "ID_TIPO_IDENTIFICACION";
            this.ID_TIPO_IDENTIFICACION.Name = "ID_TIPO_IDENTIFICACION";
            this.ID_TIPO_IDENTIFICACION.ReadOnly = true;
            this.ID_TIPO_IDENTIFICACION.Visible = false;
            // 
            // TIPO_IDENTIFICACION
            // 
            this.TIPO_IDENTIFICACION.DataPropertyName = "TIPO_IDENTIFICACION";
            this.TIPO_IDENTIFICACION.HeaderText = "TIPO_IDENTIFICACION";
            this.TIPO_IDENTIFICACION.Name = "TIPO_IDENTIFICACION";
            this.TIPO_IDENTIFICACION.ReadOnly = true;
            this.TIPO_IDENTIFICACION.Width = 150;
            // 
            // IDENTIFICACION
            // 
            this.IDENTIFICACION.DataPropertyName = "IDENTIFICACION";
            this.IDENTIFICACION.HeaderText = "IDENTIFICACION";
            this.IDENTIFICACION.Name = "IDENTIFICACION";
            this.IDENTIFICACION.ReadOnly = true;
            this.IDENTIFICACION.Width = 150;
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
            this.OFICINA.Width = 300;
            // 
            // ID_LUGAR_NACIMIENTO
            // 
            this.ID_LUGAR_NACIMIENTO.DataPropertyName = "ID_LUGAR_NACIMIENTO";
            this.ID_LUGAR_NACIMIENTO.HeaderText = "ID_LUGAR_NACIMIENTO";
            this.ID_LUGAR_NACIMIENTO.Name = "ID_LUGAR_NACIMIENTO";
            this.ID_LUGAR_NACIMIENTO.ReadOnly = true;
            this.ID_LUGAR_NACIMIENTO.Visible = false;
            // 
            // LUGAR_NACIMIENTO
            // 
            this.LUGAR_NACIMIENTO.DataPropertyName = "LUGAR_NACIMIENTO";
            this.LUGAR_NACIMIENTO.HeaderText = "LUGAR_NACIMIENTO";
            this.LUGAR_NACIMIENTO.Name = "LUGAR_NACIMIENTO";
            this.LUGAR_NACIMIENTO.ReadOnly = true;
            this.LUGAR_NACIMIENTO.Visible = false;
            // 
            // FECHA_NACIMIENTO
            // 
            this.FECHA_NACIMIENTO.DataPropertyName = "FECHA_NACIMIENTO";
            this.FECHA_NACIMIENTO.HeaderText = "FECHA_NACIMIENTO";
            this.FECHA_NACIMIENTO.Name = "FECHA_NACIMIENTO";
            this.FECHA_NACIMIENTO.ReadOnly = true;
            this.FECHA_NACIMIENTO.Visible = false;
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
            // ESTADO_CIVIL
            // 
            this.ESTADO_CIVIL.DataPropertyName = "ESTADO_CIVIL";
            this.ESTADO_CIVIL.HeaderText = "ESTADO_CIVIL";
            this.ESTADO_CIVIL.Name = "ESTADO_CIVIL";
            this.ESTADO_CIVIL.ReadOnly = true;
            this.ESTADO_CIVIL.Visible = false;
            // 
            // SEXO
            // 
            this.SEXO.DataPropertyName = "SEXO";
            this.SEXO.HeaderText = "SEXO";
            this.SEXO.Name = "SEXO";
            this.SEXO.ReadOnly = true;
            this.SEXO.Visible = false;
            // 
            // ID_OCUPACION
            // 
            this.ID_OCUPACION.DataPropertyName = "ID_OCUPACION";
            this.ID_OCUPACION.HeaderText = "ID_OCUPACION";
            this.ID_OCUPACION.Name = "ID_OCUPACION";
            this.ID_OCUPACION.ReadOnly = true;
            this.ID_OCUPACION.Visible = false;
            // 
            // OCUPACION
            // 
            this.OCUPACION.DataPropertyName = "OCUPACION";
            this.OCUPACION.HeaderText = "OCUPACION";
            this.OCUPACION.Name = "OCUPACION";
            this.OCUPACION.ReadOnly = true;
            this.OCUPACION.Visible = false;
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "EMAIL";
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.ReadOnly = true;
            this.EMAIL.Visible = false;
            // 
            // DIRECCION_RESIDENCIAL
            // 
            this.DIRECCION_RESIDENCIAL.DataPropertyName = "DIRECCION_RESIDENCIAL";
            this.DIRECCION_RESIDENCIAL.HeaderText = "DIRECCION_RESIDENCIAL";
            this.DIRECCION_RESIDENCIAL.Name = "DIRECCION_RESIDENCIAL";
            this.DIRECCION_RESIDENCIAL.ReadOnly = true;
            this.DIRECCION_RESIDENCIAL.Visible = false;
            // 
            // ID_PROVINCIA
            // 
            this.ID_PROVINCIA.DataPropertyName = "ID_PROVINCIA";
            this.ID_PROVINCIA.HeaderText = "ID_PROVINCIA";
            this.ID_PROVINCIA.Name = "ID_PROVINCIA";
            this.ID_PROVINCIA.ReadOnly = true;
            this.ID_PROVINCIA.Visible = false;
            // 
            // TELEFONO
            // 
            this.TELEFONO.DataPropertyName = "TELEFONO";
            this.TELEFONO.HeaderText = "TELEFONO";
            this.TELEFONO.Name = "TELEFONO";
            this.TELEFONO.ReadOnly = true;
            this.TELEFONO.Visible = false;
            // 
            // CELULAR
            // 
            this.CELULAR.DataPropertyName = "CELULAR";
            this.CELULAR.HeaderText = "CELULAR";
            this.CELULAR.Name = "CELULAR";
            this.CELULAR.ReadOnly = true;
            this.CELULAR.Visible = false;
            // 
            // TIPO_VIVIENDA
            // 
            this.TIPO_VIVIENDA.DataPropertyName = "TIPO_VIVIENDA";
            this.TIPO_VIVIENDA.HeaderText = "TIPO_VIVIENDA";
            this.TIPO_VIVIENDA.Name = "TIPO_VIVIENDA";
            this.TIPO_VIVIENDA.ReadOnly = true;
            this.TIPO_VIVIENDA.Visible = false;
            // 
            // ES_PEP
            // 
            this.ES_PEP.DataPropertyName = "ES_PEP";
            this.ES_PEP.HeaderText = "ES_PEP";
            this.ES_PEP.Name = "ES_PEP";
            this.ES_PEP.ReadOnly = true;
            this.ES_PEP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ES_PEP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ES_PEP.Visible = false;
            // 
            // VINCULADO_PEP
            // 
            this.VINCULADO_PEP.DataPropertyName = "VINCULADO_PEP";
            this.VINCULADO_PEP.HeaderText = "VINCULADO_PEP";
            this.VINCULADO_PEP.Name = "VINCULADO_PEP";
            this.VINCULADO_PEP.ReadOnly = true;
            this.VINCULADO_PEP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VINCULADO_PEP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.VINCULADO_PEP.Visible = false;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "ESTADO";
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            // 
            // FRM_MANT_CLIENTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(977, 598);
            this.Controls.Add(this.DG);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_buscar);
            this.Name = "FRM_MANT_CLIENTES";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FRM_MANT_CLIENTES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG;
        private System.Windows.Forms.Button btn_editar;
        private MetroFramework.Controls.MetroLabel lbl_total;
        private System.Windows.Forms.Button btn_agregar;
        private MetroFramework.Controls.MetroTextBox txt_buscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO_PAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO_MAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TIPO_IDENTIFICACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_IDENTIFICACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDENTIFICACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_OFICINA;
        private System.Windows.Forms.DataGridViewTextBoxColumn OFICINA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_LUGAR_NACIMIENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn LUGAR_NACIMIENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_NACIMIENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_NACIONALIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NACIONALIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO_CIVIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEXO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_OCUPACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn OCUPACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCION_RESIDENCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PROVINCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CELULAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_VIVIENDA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ES_PEP;
        private System.Windows.Forms.DataGridViewCheckBoxColumn VINCULADO_PEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
    }
}
