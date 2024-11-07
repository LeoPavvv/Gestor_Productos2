namespace Gestor_Productos2
{
    partial class Frm_principal
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
            grilla = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)grilla).BeginInit();
            SuspendLayout();
            // 
            // grilla
            // 
            grilla.AllowUserToAddRows = false;
            grilla.AllowUserToDeleteRows = false;
            grilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grilla.Location = new Point(58, 27);
            grilla.Name = "grilla";
            grilla.ReadOnly = true;
            grilla.Size = new Size(466, 145);
            grilla.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(83, 223);
            button1.Name = "button1";
            button1.Size = new Size(75, 41);
            button1.TabIndex = 1;
            button1.Text = "Agregar Producto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(251, 223);
            button2.Name = "button2";
            button2.Size = new Size(75, 41);
            button2.TabIndex = 2;
            button2.Text = "Modificar Producto";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(424, 223);
            button3.Name = "button3";
            button3.Size = new Size(75, 41);
            button3.TabIndex = 3;
            button3.Text = "Eliminar producto";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Frm_principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(grilla);
            Name = "Frm_principal";
            Text = "Form2";
            Load += Frm_principal_Load_1;
            ((System.ComponentModel.ISupportInitialize)grilla).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grilla;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}