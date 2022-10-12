namespace Bloco_de_Notas
{
    partial class frmLocalizar
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocalizar = new System.Windows.Forms.TextBox();
            this.btnLocalizaProxima = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Localizar: ";
            // 
            // txtLocalizar
            // 
            this.txtLocalizar.Location = new System.Drawing.Point(85, 36);
            this.txtLocalizar.Name = "txtLocalizar";
            this.txtLocalizar.Size = new System.Drawing.Size(299, 23);
            this.txtLocalizar.TabIndex = 1;
            // 
            // btnLocalizaProxima
            // 
            this.btnLocalizaProxima.Location = new System.Drawing.Point(85, 65);
            this.btnLocalizaProxima.Name = "btnLocalizaProxima";
            this.btnLocalizaProxima.Size = new System.Drawing.Size(148, 36);
            this.btnLocalizaProxima.TabIndex = 2;
            this.btnLocalizaProxima.Text = "Localizar";
            this.btnLocalizaProxima.UseVisualStyleBackColor = true;
            this.btnLocalizaProxima.Click += new System.EventHandler(this.btnLocalizaProxima_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(239, 65);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(145, 36);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmLocalizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 260);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLocalizaProxima);
            this.Controls.Add(this.txtLocalizar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmLocalizar";
            this.Text = "Localizar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocalizar;
        private System.Windows.Forms.Button btnLocalizaProxima;
        private System.Windows.Forms.Button btnCancelar;
    }
}