﻿namespace CAPA_PRESENTACION.FORMULARIOS
{
    partial class FRM_PUESTO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PUESTO));
            this.btn_agregar = new System.Windows.Forms.Button();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cb_departamento = new System.Windows.Forms.ComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cb_oficina = new System.Windows.Forms.ComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_descripcion = new MetroFramework.Controls.MetroTextBox();
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
            this.btn_agregar.Location = new System.Drawing.Point(17, 216);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(101, 43);
            this.btn_agregar.TabIndex = 9;
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
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.cb_departamento);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.cb_oficina);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.cb_estado);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.txt_descripcion);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(17, 57);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(518, 156);
            this.metroPanel1.TabIndex = 8;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(24, 54);
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
            this.cb_departamento.Location = new System.Drawing.Point(116, 50);
            this.cb_departamento.Name = "cb_departamento";
            this.cb_departamento.Size = new System.Drawing.Size(368, 23);
            this.cb_departamento.TabIndex = 1;
            this.cb_departamento.SelectedIndexChanged += new System.EventHandler(this.cb_departamento_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(67, 29);
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
            this.cb_oficina.Location = new System.Drawing.Point(116, 24);
            this.cb_oficina.Name = "cb_oficina";
            this.cb_oficina.Size = new System.Drawing.Size(368, 23);
            this.cb_oficina.TabIndex = 0;
            this.cb_oficina.SelectedIndexChanged += new System.EventHandler(this.cb_oficina_SelectedIndexChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(70, 105);
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
            this.cb_estado.Location = new System.Drawing.Point(116, 102);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(121, 23);
            this.cb_estado.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(68, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 15);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Puesto";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txt_descripcion.CustomButton.Image = null;
            this.txt_descripcion.CustomButton.Location = new System.Drawing.Point(347, 1);
            this.txt_descripcion.CustomButton.Name = "";
            this.txt_descripcion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_descripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_descripcion.CustomButton.TabIndex = 1;
            this.txt_descripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_descripcion.CustomButton.UseSelectable = true;
            this.txt_descripcion.CustomButton.Visible = false;
            this.txt_descripcion.Lines = new string[0];
            this.txt_descripcion.Location = new System.Drawing.Point(116, 76);
            this.txt_descripcion.MaxLength = 100;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.PasswordChar = '\0';
            this.txt_descripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_descripcion.SelectedText = "";
            this.txt_descripcion.SelectionLength = 0;
            this.txt_descripcion.SelectionStart = 0;
            this.txt_descripcion.ShortcutsEnabled = true;
            this.txt_descripcion.Size = new System.Drawing.Size(369, 23);
            this.txt_descripcion.TabIndex = 2;
            this.txt_descripcion.UseSelectable = true;
            this.txt_descripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_descripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txt_id.Location = new System.Drawing.Point(474, 34);
            this.txt_id.MaxLength = 100;
            this.txt_id.Name = "txt_id";
            this.txt_id.PasswordChar = '\0';
            this.txt_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_id.SelectedText = "";
            this.txt_id.SelectionLength = 0;
            this.txt_id.SelectionStart = 0;
            this.txt_id.ShortcutsEnabled = true;
            this.txt_id.Size = new System.Drawing.Size(64, 23);
            this.txt_id.TabIndex = 10;
            this.txt_id.UseSelectable = true;
            this.txt_id.Visible = false;
            this.txt_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FRM_PUESTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(553, 277);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.txt_id);
            this.Name = "FRM_PUESTO";
            this.Load += new System.EventHandler(this.FRM_PUESTO_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_agregar;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ComboBox cb_oficina;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ComboBox cb_estado;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_descripcion;
        private MetroFramework.Controls.MetroTextBox txt_id;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ComboBox cb_departamento;
    }
}
