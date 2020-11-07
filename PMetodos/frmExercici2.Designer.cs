namespace PMetodos
{
    partial class frmExercici2
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
            this.txtPal1 = new System.Windows.Forms.TextBox();
            this.txtPal2 = new System.Windows.Forms.TextBox();
            this.btnComparar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInserir1 = new System.Windows.Forms.Button();
            this.btnInserir2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPal1
            // 
            this.txtPal1.Location = new System.Drawing.Point(254, 62);
            this.txtPal1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPal1.Name = "txtPal1";
            this.txtPal1.Size = new System.Drawing.Size(148, 26);
            this.txtPal1.TabIndex = 0;
            // 
            // txtPal2
            // 
            this.txtPal2.Location = new System.Drawing.Point(254, 102);
            this.txtPal2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPal2.Name = "txtPal2";
            this.txtPal2.Size = new System.Drawing.Size(148, 26);
            this.txtPal2.TabIndex = 1;
            // 
            // btnComparar
            // 
            this.btnComparar.Location = new System.Drawing.Point(75, 210);
            this.btnComparar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(116, 43);
            this.btnComparar.TabIndex = 2;
            this.btnComparar.Text = "Comparar";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Palavra 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Palavra 2";
            // 
            // btnInserir1
            // 
            this.btnInserir1.Location = new System.Drawing.Point(218, 210);
            this.btnInserir1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInserir1.Name = "btnInserir1";
            this.btnInserir1.Size = new System.Drawing.Size(129, 43);
            this.btnInserir1.TabIndex = 5;
            this.btnInserir1.Text = "Inserir";
            this.btnInserir1.UseVisualStyleBackColor = true;
            this.btnInserir1.Click += new System.EventHandler(this.btnInserir1_Click);
            // 
            // btnInserir2
            // 
            this.btnInserir2.Location = new System.Drawing.Point(374, 210);
            this.btnInserir2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInserir2.Name = "btnInserir2";
            this.btnInserir2.Size = new System.Drawing.Size(128, 43);
            this.btnInserir2.TabIndex = 6;
            this.btnInserir2.Text = "*";
            this.btnInserir2.UseVisualStyleBackColor = true;
            this.btnInserir2.Click += new System.EventHandler(this.btnInserir2_Click);
            // 
            // frmExercici2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 388);
            this.Controls.Add(this.btnInserir2);
            this.Controls.Add(this.btnInserir1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.txtPal2);
            this.Controls.Add(this.txtPal1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmExercici2";
            this.Text = "frmExercici2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPal1;
        private System.Windows.Forms.TextBox txtPal2;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInserir1;
        private System.Windows.Forms.Button btnInserir2;
    }
}