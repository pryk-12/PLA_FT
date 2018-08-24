namespace CAPA_PRESENTACION.FORMULARIOS
{
    partial class FRM_PERMISOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PERMISOS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DG_PERMISO = new System.Windows.Forms.DataGridView();
            this.PANTALLA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACCESO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AGREGAR = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EDITAR = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.DG_MENU = new System.Windows.Forms.DataGridView();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cb_usuario = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACCESO1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_PERMISO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_MENU)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_PERMISO
            // 
            this.DG_PERMISO.AllowUserToAddRows = false;
            this.DG_PERMISO.AllowUserToDeleteRows = false;
            this.DG_PERMISO.AllowUserToResizeColumns = false;
            this.DG_PERMISO.AllowUserToResizeRows = false;
            this.DG_PERMISO.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_PERMISO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_PERMISO.ColumnHeadersHeight = 25;
            this.DG_PERMISO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PANTALLA,
            this.ACCESO,
            this.AGREGAR,
            this.EDITAR});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_PERMISO.DefaultCellStyle = dataGridViewCellStyle2;
            this.DG_PERMISO.EnableHeadersVisualStyles = false;
            this.DG_PERMISO.GridColor = System.Drawing.Color.Gray;
            this.DG_PERMISO.Location = new System.Drawing.Point(18, 262);
            this.DG_PERMISO.MultiSelect = false;
            this.DG_PERMISO.Name = "DG_PERMISO";
            this.DG_PERMISO.ReadOnly = true;
            this.DG_PERMISO.RowHeadersVisible = false;
            this.DG_PERMISO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_PERMISO.Size = new System.Drawing.Size(567, 303);
            this.DG_PERMISO.TabIndex = 22;
            // 
            // PANTALLA
            // 
            this.PANTALLA.DataPropertyName = "PANTALLA";
            this.PANTALLA.HeaderText = "PANTALLA";
            this.PANTALLA.Name = "PANTALLA";
            this.PANTALLA.ReadOnly = true;
            this.PANTALLA.Width = 300;
            // 
            // ACCESO
            // 
            this.ACCESO.DataPropertyName = "ACCESO";
            this.ACCESO.HeaderText = "ACCESO";
            this.ACCESO.Name = "ACCESO";
            this.ACCESO.ReadOnly = true;
            this.ACCESO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ACCESO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ACCESO.Width = 80;
            // 
            // AGREGAR
            // 
            this.AGREGAR.DataPropertyName = "AGREGAR";
            this.AGREGAR.HeaderText = "AGREGAR";
            this.AGREGAR.Name = "AGREGAR";
            this.AGREGAR.ReadOnly = true;
            this.AGREGAR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AGREGAR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AGREGAR.Width = 80;
            // 
            // EDITAR
            // 
            this.EDITAR.DataPropertyName = "EDITAR";
            this.EDITAR.HeaderText = "EDITAR";
            this.EDITAR.Name = "EDITAR";
            this.EDITAR.ReadOnly = true;
            this.EDITAR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EDITAR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EDITAR.Width = 80;
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
            this.btn_agregar.Location = new System.Drawing.Point(18, 569);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(101, 43);
            this.btn_agregar.TabIndex = 23;
            this.btn_agregar.Text = "  Guardar";
            this.btn_agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_agregar.UseVisualStyleBackColor = false;
            // 
            // DG_MENU
            // 
            this.DG_MENU.AllowUserToAddRows = false;
            this.DG_MENU.AllowUserToDeleteRows = false;
            this.DG_MENU.AllowUserToResizeColumns = false;
            this.DG_MENU.AllowUserToResizeRows = false;
            this.DG_MENU.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_MENU.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DG_MENU.ColumnHeadersHeight = 25;
            this.DG_MENU.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.ACCESO1});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_MENU.DefaultCellStyle = dataGridViewCellStyle4;
            this.DG_MENU.EnableHeadersVisualStyles = false;
            this.DG_MENU.GridColor = System.Drawing.Color.Gray;
            this.DG_MENU.Location = new System.Drawing.Point(17, 124);
            this.DG_MENU.MultiSelect = false;
            this.DG_MENU.Name = "DG_MENU";
            this.DG_MENU.ReadOnly = true;
            this.DG_MENU.RowHeadersVisible = false;
            this.DG_MENU.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_MENU.Size = new System.Drawing.Size(568, 101);
            this.DG_MENU.TabIndex = 24;
            this.DG_MENU.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_MENU_CellClick);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(25, 67);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(60, 19);
            this.metroLabel4.TabIndex = 26;
            this.metroLabel4.Text = "Usuario";
            // 
            // cb_usuario
            // 
            this.cb_usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_usuario.FormattingEnabled = true;
            this.cb_usuario.Items.AddRange(new object[] {
            "",
            "ACTIVO",
            "INACTIVO"});
            this.cb_usuario.Location = new System.Drawing.Point(90, 65);
            this.cb_usuario.Name = "cb_usuario";
            this.cb_usuario.Size = new System.Drawing.Size(218, 23);
            this.cb_usuario.TabIndex = 25;
            this.cb_usuario.SelectedIndexChanged += new System.EventHandler(this.cb_usuario_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(433, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 28);
            this.button2.TabIndex = 85;
            this.button2.Text = "          Quitar Selección";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(280, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 28);
            this.button1.TabIndex = 84;
            this.button1.Text = "   Seleccionar Todo";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(21, 241);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(146, 19);
            this.metroLabel1.TabIndex = 86;
            this.metroLabel1.Text = "Permisos a Pantallas";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(23, 102);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(133, 19);
            this.metroLabel2.TabIndex = 87;
            this.metroLabel2.Text = "Opciones de Menu";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MENU";
            this.dataGridViewTextBoxColumn2.HeaderText = "MENU";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // ACCESO1
            // 
            this.ACCESO1.DataPropertyName = "ACCESO";
            this.ACCESO1.HeaderText = "ACCESO";
            this.ACCESO1.Name = "ACCESO1";
            this.ACCESO1.ReadOnly = true;
            this.ACCESO1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ACCESO1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ACCESO1.Width = 80;
            // 
            // FRM_PERMISOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(607, 635);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.cb_usuario);
            this.Controls.Add(this.DG_MENU);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.DG_PERMISO);
            this.Name = "FRM_PERMISOS";
            this.Text = "Permisos";
            ((System.ComponentModel.ISupportInitialize)(this.DG_PERMISO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_MENU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_PERMISO;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView DG_MENU;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ComboBox cb_usuario;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PANTALLA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ACCESO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AGREGAR;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EDITAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ACCESO1;
    }
}
