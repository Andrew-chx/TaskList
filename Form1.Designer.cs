namespace TaskList
{
    partial class TaskForm
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new MaterialSkin.Controls.MaterialFlatButton();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.tbTask = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbDescription = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(45, 29);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(97, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "TaskList App";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Task,
            this.Description,
            this.EstadoTarea});
            this.dataGridView1.Location = new System.Drawing.Point(399, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 221);
            this.dataGridView1.TabIndex = 5;
            // 
            // Task
            // 
            this.Task.HeaderText = "Tarea";
            this.Task.Name = "Task";
            // 
            // Description
            // 
            this.Description.HeaderText = "Descripción";
            this.Description.Name = "Description";
            // 
            // EstadoTarea
            // 
            this.EstadoTarea.HeaderText = "Estado";
            this.EstadoTarea.Name = "EstadoTarea";
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Depth = 0;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Location = new System.Drawing.Point(120, 303);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = false;
            this.btnAdd.Size = new System.Drawing.Size(61, 36);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.ItemHeight = 16;
            this.cbStatus.Items.AddRange(new object[] {
            "Completado",
            "En curso",
            "Sin completar"});
            this.cbStatus.Location = new System.Drawing.Point(49, 241);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(205, 24);
            this.cbStatus.TabIndex = 3;
            // 
            // tbTask
            // 
            this.tbTask.BackColor = System.Drawing.Color.White;
            this.tbTask.Depth = 0;
            this.tbTask.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTask.ForeColor = System.Drawing.SystemColors.Control;
            this.tbTask.Hint = "Nombre de la tarea";
            this.tbTask.Location = new System.Drawing.Point(49, 105);
            this.tbTask.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbTask.Name = "tbTask";
            this.tbTask.PasswordChar = '\0';
            this.tbTask.SelectedText = "";
            this.tbTask.SelectionLength = 0;
            this.tbTask.SelectionStart = 0;
            this.tbTask.Size = new System.Drawing.Size(205, 23);
            this.tbTask.TabIndex = 1;
            this.tbTask.UseSystemPasswordChar = false;
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.Color.White;
            this.tbDescription.Depth = 0;
            this.tbDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbDescription.Hint = "Descripción";
            this.tbDescription.Location = new System.Drawing.Point(49, 168);
            this.tbDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.PasswordChar = '\0';
            this.tbDescription.SelectedText = "";
            this.tbDescription.SelectionLength = 0;
            this.tbDescription.SelectionStart = 0;
            this.tbDescription.Size = new System.Drawing.Size(205, 23);
            this.tbDescription.TabIndex = 2;
            this.tbDescription.UseSystemPasswordChar = false;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbTask);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.materialLabel1);
            this.Name = "TaskForm";
            this.Text = "Your personal task list";
            this.Load += new System.EventHandler(this.TaskForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialFlatButton btnAdd;
        private System.Windows.Forms.ComboBox cbStatus;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbTask;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoTarea;
    }
}

