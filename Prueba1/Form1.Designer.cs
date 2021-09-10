
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.boxCedula = new System.Windows.Forms.TextBox();
            this.boxNombre = new System.Windows.Forms.TextBox();
            this.boxFecha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFormulario2
            // 
            this.btnFormulario2.Location = new System.Drawing.Point(125, 179);
            this.btnFormulario2.Name = "btnFormulario2";
            this.btnFormulario2.Size = new System.Drawing.Size(89, 41);
            this.btnFormulario2.TabIndex = 0;
            this.btnFormulario2.Text = "Formulario 2";
            this.btnFormulario2.UseVisualStyleBackColor = true;
            this.btnFormulario2.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cedula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha de Nacimiento";
            // 
            // boxCedula
            // 
            this.boxCedula.Location = new System.Drawing.Point(218, 23);
            this.boxCedula.Name = "boxCedula";
            this.boxCedula.Size = new System.Drawing.Size(100, 20);
            this.boxCedula.TabIndex = 4;
            // 
            // boxNombre
            // 
            this.boxNombre.Location = new System.Drawing.Point(218, 56);
            this.boxNombre.Name = "boxNombre";
            this.boxNombre.Size = new System.Drawing.Size(100, 20);
            this.boxNombre.TabIndex = 5;
            // 
            // boxFecha
            // 
            this.boxFecha.Location = new System.Drawing.Point(218, 88);
            this.boxFecha.Name = "boxFecha";
            this.boxFecha.Size = new System.Drawing.Size(100, 20);
            this.boxFecha.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 244);
            this.Controls.Add(this.boxFecha);
            this.Controls.Add(this.boxNombre);
            this.Controls.Add(this.boxCedula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFormulario2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFormulario2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxCedula;
        private System.Windows.Forms.TextBox boxNombre;
        private System.Windows.Forms.TextBox boxFecha;
    }
}

