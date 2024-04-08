
namespace ejemplo1
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
            this.lblTexto = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.cbLista = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(104, 202);
            this.lblTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(95, 17);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.Text = "Elija la opcion";
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatAppearance.BorderSize = 2;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.Red;
            this.btnAceptar.Location = new System.Drawing.Point(465, 264);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(120, 44);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(244, 337);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 17);
            this.lblMensaje.TabIndex = 3;
            // 
            // cbLista
            // 
            this.cbLista.FormattingEnabled = true;
            this.cbLista.Items.AddRange(new object[] {
            "Rojo",
            "Verde",
            "Azul",
            "Amarillo"});
            this.cbLista.Location = new System.Drawing.Point(236, 202);
            this.cbLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbLista.Name = "cbLista";
            this.cbLista.Size = new System.Drawing.Size(159, 106);
            this.cbLista.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cbLista);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblTexto);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.CheckedListBox cbLista;
    }
}

