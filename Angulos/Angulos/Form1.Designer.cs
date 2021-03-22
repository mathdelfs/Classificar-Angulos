
namespace Angulos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btmClassificar = new System.Windows.Forms.Button();
            this.txtangulo2 = new System.Windows.Forms.TextBox();
            this.txtangulo3 = new System.Windows.Forms.TextBox();
            this.txtangulo1 = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ângulo 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ângulo 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ângulo 3";
            // 
            // btmClassificar
            // 
            this.btmClassificar.Location = new System.Drawing.Point(357, 215);
            this.btmClassificar.Name = "btmClassificar";
            this.btmClassificar.Size = new System.Drawing.Size(75, 23);
            this.btmClassificar.TabIndex = 5;
            this.btmClassificar.Text = "Classificar";
            this.btmClassificar.UseVisualStyleBackColor = true;
            this.btmClassificar.Click += new System.EventHandler(this.btmClassificar_Click);
            // 
            // txtangulo2
            // 
            this.txtangulo2.Location = new System.Drawing.Point(243, 163);
            this.txtangulo2.Name = "txtangulo2";
            this.txtangulo2.Size = new System.Drawing.Size(100, 20);
            this.txtangulo2.TabIndex = 7;
            this.txtangulo2.Text = "0";
            this.txtangulo2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtangulo2_KeyPress);
            // 
            // txtangulo3
            // 
            this.txtangulo3.Location = new System.Drawing.Point(445, 163);
            this.txtangulo3.Name = "txtangulo3";
            this.txtangulo3.Size = new System.Drawing.Size(100, 20);
            this.txtangulo3.TabIndex = 8;
            this.txtangulo3.Text = "0";
            this.txtangulo3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtangulo3_KeyPress);
            // 
            // txtangulo1
            // 
            this.txtangulo1.Location = new System.Drawing.Point(344, 66);
            this.txtangulo1.Name = "txtangulo1";
            this.txtangulo1.Size = new System.Drawing.Size(100, 20);
            this.txtangulo1.TabIndex = 9;
            this.txtangulo1.Text = "0";
            this.txtangulo1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtangulo1_KeyPress);
            // 
            // txtresultado
            // 
            this.txtresultado.Enabled = false;
            this.txtresultado.Location = new System.Drawing.Point(344, 244);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(100, 20);
            this.txtresultado.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtangulo1);
            this.Controls.Add(this.txtangulo3);
            this.Controls.Add(this.txtangulo2);
            this.Controls.Add(this.btmClassificar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btmClassificar;
        private System.Windows.Forms.TextBox txtangulo2;
        private System.Windows.Forms.TextBox txtangulo3;
        private System.Windows.Forms.TextBox txtangulo1;
        private System.Windows.Forms.TextBox txtresultado;
    }
}

