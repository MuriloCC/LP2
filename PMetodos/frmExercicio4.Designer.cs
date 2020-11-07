namespace PMetodos
{
    partial class frmExercicio4
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
            this.rchTxt = new System.Windows.Forms.RichTextBox();
            this.btNumericos = new System.Windows.Forms.Button();
            this.btnEspaco = new System.Windows.Forms.Button();
            this.btnAlfabeticos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchTxt
            // 
            this.rchTxt.Location = new System.Drawing.Point(97, 56);
            this.rchTxt.Name = "rchTxt";
            this.rchTxt.Size = new System.Drawing.Size(426, 249);
            this.rchTxt.TabIndex = 0;
            this.rchTxt.Text = "";
            // 
            // btNumericos
            // 
            this.btNumericos.Location = new System.Drawing.Point(547, 56);
            this.btNumericos.Name = "btNumericos";
            this.btNumericos.Size = new System.Drawing.Size(112, 55);
            this.btNumericos.TabIndex = 1;
            this.btNumericos.Text = "Numéricos";
            this.btNumericos.UseVisualStyleBackColor = true;
            this.btNumericos.Click += new System.EventHandler(this.btNumericos_Click);
            // 
            // btnEspaco
            // 
            this.btnEspaco.Location = new System.Drawing.Point(547, 153);
            this.btnEspaco.Name = "btnEspaco";
            this.btnEspaco.Size = new System.Drawing.Size(112, 57);
            this.btnEspaco.TabIndex = 2;
            this.btnEspaco.Text = "Espaço em Branco";
            this.btnEspaco.UseVisualStyleBackColor = true;
            this.btnEspaco.Click += new System.EventHandler(this.btnEspaco_Click);
            // 
            // btnAlfabeticos
            // 
            this.btnAlfabeticos.Location = new System.Drawing.Point(547, 245);
            this.btnAlfabeticos.Name = "btnAlfabeticos";
            this.btnAlfabeticos.Size = new System.Drawing.Size(112, 60);
            this.btnAlfabeticos.TabIndex = 3;
            this.btnAlfabeticos.Text = "Alfabéticos";
            this.btnAlfabeticos.UseVisualStyleBackColor = true;
            this.btnAlfabeticos.Click += new System.EventHandler(this.btnAlfabeticos_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAlfabeticos);
            this.Controls.Add(this.btnEspaco);
            this.Controls.Add(this.btNumericos);
            this.Controls.Add(this.rchTxt);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTxt;
        private System.Windows.Forms.Button btNumericos;
        private System.Windows.Forms.Button btnEspaco;
        private System.Windows.Forms.Button btnAlfabeticos;
    }
}