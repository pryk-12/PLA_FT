namespace CAPA_PRESENTACION.FORMULARIOS
{
    partial class FRM_VER_OBSERVACIONES
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
            this.DG = new System.Windows.Forms.DataGridView();
            this.ID_EVALUACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_OBSERVACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_observacion = new MetroFramework.Controls.MetroTextBox();
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
            this.ID_OBSERVACION,
            this.DESCRIPCION,
            this.FECHA,
            this.USUARIO});
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
            this.DG.Location = new System.Drawing.Point(15, 63);
            this.DG.MultiSelect = false;
            this.DG.Name = "DG";
            this.DG.ReadOnly = true;
            this.DG.RowHeadersVisible = false;
            this.DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG.Size = new System.Drawing.Size(843, 289);
            this.DG.TabIndex = 27;
            this.DG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_CellClick);
            // 
            // ID_EVALUACION
            // 
            this.ID_EVALUACION.DataPropertyName = "ID_EVALUACION";
            this.ID_EVALUACION.HeaderText = "ID_EVALUACION";
            this.ID_EVALUACION.Name = "ID_EVALUACION";
            this.ID_EVALUACION.ReadOnly = true;
            this.ID_EVALUACION.Visible = false;
            // 
            // ID_OBSERVACION
            // 
            this.ID_OBSERVACION.DataPropertyName = "ID_OBSERVACION";
            this.ID_OBSERVACION.HeaderText = "ID";
            this.ID_OBSERVACION.Name = "ID_OBSERVACION";
            this.ID_OBSERVACION.ReadOnly = true;
            this.ID_OBSERVACION.Width = 50;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.DataPropertyName = "DESCRIPCION";
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            this.DESCRIPCION.Width = 570;
            // 
            // FECHA
            // 
            this.FECHA.DataPropertyName = "FECHA";
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            // 
            // USUARIO
            // 
            this.USUARIO.DataPropertyName = "USUARIO";
            this.USUARIO.HeaderText = "USUARIO";
            this.USUARIO.Name = "USUARIO";
            this.USUARIO.ReadOnly = true;
            // 
            // txt_observacion
            // 
            this.txt_observacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txt_observacion.CustomButton.Image = null;
            this.txt_observacion.CustomButton.Location = new System.Drawing.Point(769, 1);
            this.txt_observacion.CustomButton.Name = "";
            this.txt_observacion.CustomButton.Size = new System.Drawing.Size(73, 73);
            this.txt_observacion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_observacion.CustomButton.TabIndex = 1;
            this.txt_observacion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_observacion.CustomButton.UseSelectable = true;
            this.txt_observacion.CustomButton.Visible = false;
            this.txt_observacion.Enabled = false;
            this.txt_observacion.Lines = new string[0];
            this.txt_observacion.Location = new System.Drawing.Point(15, 358);
            this.txt_observacion.MaxLength = 4000;
            this.txt_observacion.Multiline = true;
            this.txt_observacion.Name = "txt_observacion";
            this.txt_observacion.PasswordChar = '\0';
            this.txt_observacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_observacion.SelectedText = "";
            this.txt_observacion.SelectionLength = 0;
            this.txt_observacion.SelectionStart = 0;
            this.txt_observacion.ShortcutsEnabled = true;
            this.txt_observacion.Size = new System.Drawing.Size(843, 75);
            this.txt_observacion.TabIndex = 40;
            this.txt_observacion.UseSelectable = true;
            this.txt_observacion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_observacion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FRM_VER_OBSERVACIONES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(874, 456);
            this.Controls.Add(this.txt_observacion);
            this.Controls.Add(this.DG);
            this.Name = "FRM_VER_OBSERVACIONES";
            this.Text = "Ver Observaciones";
            this.Load += new System.EventHandler(this.FRM_VER_OBSERVACIONES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_EVALUACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_OBSERVACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO;
        private MetroFramework.Controls.MetroTextBox txt_observacion;
    }
}
