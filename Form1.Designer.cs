namespace Recuperativa
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_PIN = new System.Windows.Forms.TextBox();
            this.btnIngresar_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese su PIN";
            // 
            // textBox_PIN
            // 
            this.textBox_PIN.Location = new System.Drawing.Point(61, 100);
            this.textBox_PIN.Name = "textBox_PIN";
            this.textBox_PIN.Size = new System.Drawing.Size(160, 22);
            this.textBox_PIN.TabIndex = 2;
            // 
            // btnIngresar_Click
            // 
            this.btnIngresar_Click.Location = new System.Drawing.Point(268, 86);
            this.btnIngresar_Click.Name = "btnIngresar_Click";
            this.btnIngresar_Click.Size = new System.Drawing.Size(140, 51);
            this.btnIngresar_Click.TabIndex = 3;
            this.btnIngresar_Click.Text = "Ingresar";
            this.btnIngresar_Click.UseVisualStyleBackColor = true;
            this.btnIngresar_Click.Click += new System.EventHandler(this.btnIngresar_Click_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 198);
            this.Controls.Add(this.btnIngresar_Click);
            this.Controls.Add(this.textBox_PIN);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_PIN;
        private System.Windows.Forms.Button btnIngresar_Click;
    }
}

