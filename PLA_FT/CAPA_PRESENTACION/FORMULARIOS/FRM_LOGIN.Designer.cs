namespace CAPA_PRESENTACION.FORMULARIOS
{
    partial class FRM_LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_LOGIN));
            this.button1 = new System.Windows.Forms.Button();
            this.btn_mant_oficina = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_clave = new MetroFramework.Controls.MetroTextBox();
            this.txt_usuario = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(301, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 40);
            this.button1.TabIndex = 24;
            this.button1.Text = "  Cerrar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_mant_oficina
            // 
            this.btn_mant_oficina.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_mant_oficina.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_mant_oficina.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_mant_oficina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_mant_oficina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mant_oficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mant_oficina.ForeColor = System.Drawing.Color.White;
            this.btn_mant_oficina.Image = ((System.Drawing.Image)(resources.GetObject("btn_mant_oficina.Image")));
            this.btn_mant_oficina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mant_oficina.Location = new System.Drawing.Point(149, 170);
            this.btn_mant_oficina.Name = "btn_mant_oficina";
            this.btn_mant_oficina.Size = new System.Drawing.Size(147, 40);
            this.btn_mant_oficina.TabIndex = 23;
            this.btn_mant_oficina.Text = "  Aceptar";
            this.btn_mant_oficina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_mant_oficina.UseVisualStyleBackColor = false;
            this.btn_mant_oficina.Click += new System.EventHandler(this.btn_mant_oficina_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_clave);
            this.panel2.Controls.Add(this.txt_usuario);
            this.panel2.Location = new System.Drawing.Point(149, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 102);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clave";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // txt_clave
            // 
            // 
            // 
            // 
            this.txt_clave.CustomButton.Image = null;
            this.txt_clave.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.txt_clave.CustomButton.Name = "";
            this.txt_clave.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_clave.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_clave.CustomButton.TabIndex = 1;
            this.txt_clave.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_clave.CustomButton.UseSelectable = true;
            this.txt_clave.CustomButton.Visible = false;
            this.txt_clave.Lines = new string[0];
            this.txt_clave.Location = new System.Drawing.Point(76, 53);
            this.txt_clave.MaxLength = 32767;
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.PasswordChar = '●';
            this.txt_clave.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_clave.SelectedText = "";
            this.txt_clave.SelectionLength = 0;
            this.txt_clave.SelectionStart = 0;
            this.txt_clave.ShortcutsEnabled = true;
            this.txt_clave.Size = new System.Drawing.Size(199, 23);
            this.txt_clave.TabIndex = 1;
            this.txt_clave.UseSelectable = true;
            this.txt_clave.UseSystemPasswordChar = true;
            this.txt_clave.WaterMark = "Ingrese la Clave";
            this.txt_clave.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_clave.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_usuario
            // 
            this.txt_usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txt_usuario.CustomButton.Image = null;
            this.txt_usuario.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.txt_usuario.CustomButton.Name = "";
            this.txt_usuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_usuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_usuario.CustomButton.TabIndex = 1;
            this.txt_usuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_usuario.CustomButton.UseSelectable = true;
            this.txt_usuario.CustomButton.Visible = false;
            this.txt_usuario.Lines = new string[0];
            this.txt_usuario.Location = new System.Drawing.Point(76, 28);
            this.txt_usuario.MaxLength = 32767;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.PasswordChar = '\0';
            this.txt_usuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_usuario.SelectedText = "";
            this.txt_usuario.SelectionLength = 0;
            this.txt_usuario.SelectionStart = 0;
            this.txt_usuario.ShortcutsEnabled = true;
            this.txt_usuario.Size = new System.Drawing.Size(199, 23);
            this.txt_usuario.TabIndex = 0;
            this.txt_usuario.UseSelectable = true;
            this.txt_usuario.WaterMark = "Ingrese el Usuario";
            this.txt_usuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_usuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(8, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 147);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FRM_LOGIN
            // 
            this.AcceptButton = this.btn_mant_oficina;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(460, 225);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_mant_oficina);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_LOGIN";
            this.Text = "Acceso al Sistema";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTextBox txt_usuario;
        private MetroFramework.Controls.MetroTextBox txt_clave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_mant_oficina;
        private System.Windows.Forms.Button button1;
    }
}
