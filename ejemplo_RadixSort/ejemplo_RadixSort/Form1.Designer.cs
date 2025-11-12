namespace ejemplo_RadixSort
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOrdenar = new Button();
            lsbDatos = new ListBox();
            btnMostrarArrayDesordenado = new Button();
            lbDatos = new Label();
            SuspendLayout();
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(15, 125);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(112, 26);
            btnOrdenar.TabIndex = 0;
            btnOrdenar.Text = "Ordenar arreglo";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // lsbDatos
            // 
            lsbDatos.FormattingEnabled = true;
            lsbDatos.Location = new Point(176, 125);
            lsbDatos.Name = "lsbDatos";
            lsbDatos.Size = new Size(273, 124);
            lsbDatos.TabIndex = 1;
            // 
            // btnMostrarArrayDesordenado
            // 
            btnMostrarArrayDesordenado.Location = new Point(33, 66);
            btnMostrarArrayDesordenado.Name = "btnMostrarArrayDesordenado";
            btnMostrarArrayDesordenado.Size = new Size(75, 23);
            btnMostrarArrayDesordenado.TabIndex = 2;
            btnMostrarArrayDesordenado.Text = "Mostrar";
            btnMostrarArrayDesordenado.UseVisualStyleBackColor = true;
            btnMostrarArrayDesordenado.Click += btnMostrarArrayDesordenado_Click;
            // 
            // lbDatos
            // 
            lbDatos.AutoSize = true;
            lbDatos.Location = new Point(184, 70);
            lbDatos.Name = "lbDatos";
            lbDatos.Size = new Size(19, 15);
            lbDatos.TabIndex = 3;
            lbDatos.Text = "....";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 350);
            Controls.Add(lbDatos);
            Controls.Add(btnMostrarArrayDesordenado);
            Controls.Add(lsbDatos);
            Controls.Add(btnOrdenar);
            Font = new Font("Cambria", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejemplo Radix Sort";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOrdenar;
        private ListBox lsbDatos;
        private Button btnMostrarArrayDesordenado;
        private Label lbDatos;
    }
}
