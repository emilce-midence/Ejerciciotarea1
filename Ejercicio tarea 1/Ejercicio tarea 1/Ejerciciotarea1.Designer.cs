﻿
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
            this.Mostrarbutton1 = new System.Windows.Forms.Button();
            this.Borrarbutton1 = new System.Windows.Forms.Button();
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
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese un numero:";
            // 
            // IngresoBox1
            // 
            this.IngresoBox1.Location = new System.Drawing.Point(267, 155);
            this.IngresoBox1.Name = "IngresoBox1";
            this.IngresoBox1.Size = new System.Drawing.Size(120, 20);
            this.IngresoBox1.TabIndex = 2;
            // 
            // Mostrarbutton1
            // 
            this.Mostrarbutton1.Location = new System.Drawing.Point(209, 245);
            this.Mostrarbutton1.Name = "Mostrarbutton1";
            this.Mostrarbutton1.Size = new System.Drawing.Size(75, 23);
            this.Mostrarbutton1.TabIndex = 7;
            this.Mostrarbutton1.Text = "Mostrar";
            this.Mostrarbutton1.UseVisualStyleBackColor = true;
            this.Mostrarbutton1.Click += new System.EventHandler(this.Mostrarbutton1_Click);
            // 
            // Borrarbutton1
            // 
            this.Borrarbutton1.Location = new System.Drawing.Point(324, 245);
            this.Borrarbutton1.Name = "Borrarbutton1";
            this.Borrarbutton1.Size = new System.Drawing.Size(75, 23);
            this.Borrarbutton1.TabIndex = 8;
            this.Borrarbutton1.Text = "Borrar";
            this.Borrarbutton1.UseVisualStyleBackColor = true;
            this.Borrarbutton1.Click += new System.EventHandler(this.Borrarbutton1_Click);
            // 
            // Ejerciciotarea1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 432);
            this.Controls.Add(this.Borrarbutton1);
            this.Controls.Add(this.Mostrarbutton1);
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
        private System.Windows.Forms.Button Mostrarbutton1;
        private System.Windows.Forms.Button Borrarbutton1;
    }
}

