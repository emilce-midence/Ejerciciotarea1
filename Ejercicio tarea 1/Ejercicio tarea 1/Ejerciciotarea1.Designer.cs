
namespace Ejercicio_tarea_1
{
    partial class Ejerciciotarea1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IngresoBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultadoBox1 = new System.Windows.Forms.TextBox();
            this.Calcularbutton1 = new System.Windows.Forms.Button();
            this.Vaciarbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Determinar si un valor es par o impar, positivo o negativo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese un valor:";
            // 
            // IngresoBox1
            // 
            this.IngresoBox1.Location = new System.Drawing.Point(267, 155);
            this.IngresoBox1.Name = "IngresoBox1";
            this.IngresoBox1.Size = new System.Drawing.Size(120, 20);
            this.IngresoBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Resultado:";
            // 
            // ResultadoBox1
            // 
            this.ResultadoBox1.Location = new System.Drawing.Point(267, 244);
            this.ResultadoBox1.Name = "ResultadoBox1";
            this.ResultadoBox1.Size = new System.Drawing.Size(170, 20);
            this.ResultadoBox1.TabIndex = 4;
            // 
            // Calcularbutton1
            // 
            this.Calcularbutton1.Location = new System.Drawing.Point(282, 181);
            this.Calcularbutton1.Name = "Calcularbutton1";
            this.Calcularbutton1.Size = new System.Drawing.Size(75, 23);
            this.Calcularbutton1.TabIndex = 5;
            this.Calcularbutton1.Text = "Calcular";
            this.Calcularbutton1.UseVisualStyleBackColor = true;
            this.Calcularbutton1.Click += new System.EventHandler(this.Calcularbutton1_Click);
            // 
            // Vaciarbutton1
            // 
            this.Vaciarbutton1.Location = new System.Drawing.Point(282, 270);
            this.Vaciarbutton1.Name = "Vaciarbutton1";
            this.Vaciarbutton1.Size = new System.Drawing.Size(75, 23);
            this.Vaciarbutton1.TabIndex = 6;
            this.Vaciarbutton1.Text = "Vaciar";
            this.Vaciarbutton1.UseVisualStyleBackColor = true;
            this.Vaciarbutton1.Click += new System.EventHandler(this.Vaciarbutton1_Click);
            // 
            // Ejerciciotarea1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 432);
            this.Controls.Add(this.Vaciarbutton1);
            this.Controls.Add(this.Calcularbutton1);
            this.Controls.Add(this.ResultadoBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IngresoBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejerciciotarea1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IngresoBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ResultadoBox1;
        private System.Windows.Forms.Button Calcularbutton1;
        private System.Windows.Forms.Button Vaciarbutton1;
    }
}

