
namespace Prueba1
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
            this.btnFormulario2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFormulario2
            // 
            this.btnFormulario2.Location = new System.Drawing.Point(221, 452);
            this.btnFormulario2.Name = "btnFormulario2";
            this.btnFormulario2.Size = new System.Drawing.Size(89, 41);
            this.btnFormulario2.TabIndex = 0;
            this.btnFormulario2.Text = "Formulario 2";
            this.btnFormulario2.UseVisualStyleBackColor = true;
            this.btnFormulario2.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 505);
            this.Controls.Add(this.btnFormulario2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormulario2;
    }
}

