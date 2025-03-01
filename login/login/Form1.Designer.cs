namespace login
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonL = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Usertxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Passtxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonL
            // 
            this.buttonL.Location = new System.Drawing.Point(85, 359);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(299, 41);
            this.buttonL.TabIndex = 0;
            this.buttonL.Text = "Log in";
            this.buttonL.UseVisualStyleBackColor = true;
            this.buttonL.Click += new System.EventHandler(this.buttonL_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.panel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(88, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 10);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(187, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 103);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(200, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "LOGIN";
            // 
            // Usertxt
            // 
            this.Usertxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Usertxt.Depth = 0;
            this.Usertxt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usertxt.ForeColor = System.Drawing.Color.Cyan;
            this.Usertxt.Hint = "Usuario";
            this.Usertxt.Location = new System.Drawing.Point(85, 206);
            this.Usertxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.Usertxt.Name = "Usertxt";
            this.Usertxt.PasswordChar = '\0';
            this.Usertxt.SelectedText = "";
            this.Usertxt.SelectionLength = 0;
            this.Usertxt.SelectionStart = 0;
            this.Usertxt.Size = new System.Drawing.Size(308, 23);
            this.Usertxt.TabIndex = 12;
            this.Usertxt.UseSystemPasswordChar = false;
            // 
            // Passtxt
            // 
            this.Passtxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Passtxt.Depth = 0;
            this.Passtxt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passtxt.ForeColor = System.Drawing.Color.Cyan;
            this.Passtxt.Hint = "Contraseña";
            this.Passtxt.Location = new System.Drawing.Point(85, 285);
            this.Passtxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.Passtxt.Name = "Passtxt";
            this.Passtxt.PasswordChar = '\0';
            this.Passtxt.SelectedText = "";
            this.Passtxt.SelectionLength = 0;
            this.Passtxt.SelectionStart = 0;
            this.Passtxt.Size = new System.Drawing.Size(308, 23);
            this.Passtxt.TabIndex = 14;
            this.Passtxt.UseSystemPasswordChar = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.panel2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Location = new System.Drawing.Point(88, 301);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 10);
            this.panel2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(466, 477);
            this.Controls.Add(this.Passtxt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Usertxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField Usertxt;
        private MaterialSkin.Controls.MaterialSingleLineTextField Passtxt;
        private System.Windows.Forms.Panel panel2;
    }
}

