namespace Atividade3
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
			this.peso = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPeso = new System.Windows.Forms.MaskedTextBox();
			this.txtAltura = new System.Windows.Forms.MaskedTextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioFem = new System.Windows.Forms.RadioButton();
			this.radioMasc = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSit = new System.Windows.Forms.TextBox();
			this.btnCalc = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// peso
			// 
			this.peso.AutoSize = true;
			this.peso.Location = new System.Drawing.Point(140, 34);
			this.peso.Name = "peso";
			this.peso.Size = new System.Drawing.Size(31, 13);
			this.peso.TabIndex = 0;
			this.peso.Text = "Peso";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(347, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Altura";
			// 
			// txtPeso
			// 
			this.txtPeso.Location = new System.Drawing.Point(199, 31);
			this.txtPeso.Mask = "000.0";
			this.txtPeso.Name = "txtPeso";
			this.txtPeso.Size = new System.Drawing.Size(100, 20);
			this.txtPeso.TabIndex = 2;
			this.txtPeso.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtPeso_MaskInputRejected);
			// 
			// txtAltura
			// 
			this.txtAltura.Location = new System.Drawing.Point(406, 31);
			this.txtAltura.Mask = "0.00";
			this.txtAltura.Name = "txtAltura";
			this.txtAltura.Size = new System.Drawing.Size(100, 20);
			this.txtAltura.TabIndex = 3;
			this.txtAltura.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtAltura_MaskInputRejected);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioMasc);
			this.groupBox1.Controls.Add(this.radioFem);
			this.groupBox1.Location = new System.Drawing.Point(143, 99);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(264, 109);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Sexo";
			// 
			// radioFem
			// 
			this.radioFem.AutoSize = true;
			this.radioFem.Location = new System.Drawing.Point(41, 53);
			this.radioFem.Name = "radioFem";
			this.radioFem.Size = new System.Drawing.Size(67, 17);
			this.radioFem.TabIndex = 0;
			this.radioFem.TabStop = true;
			this.radioFem.Text = "Feminino";
			this.radioFem.UseVisualStyleBackColor = true;
			this.radioFem.CheckedChanged += new System.EventHandler(this.radioFem_CheckedChanged);
			// 
			// radioMasc
			// 
			this.radioMasc.AutoSize = true;
			this.radioMasc.Location = new System.Drawing.Point(165, 53);
			this.radioMasc.Name = "radioMasc";
			this.radioMasc.Size = new System.Drawing.Size(73, 17);
			this.radioMasc.TabIndex = 1;
			this.radioMasc.TabStop = true;
			this.radioMasc.Text = "Masculino";
			this.radioMasc.UseVisualStyleBackColor = true;
			this.radioMasc.CheckedChanged += new System.EventHandler(this.radioMasc_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(141, 243);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Situação";
			// 
			// txtSit
			// 
			this.txtSit.Location = new System.Drawing.Point(199, 240);
			this.txtSit.Name = "txtSit";
			this.txtSit.Size = new System.Drawing.Size(240, 20);
			this.txtSit.TabIndex = 6;
			this.txtSit.TextChanged += new System.EventHandler(this.txtSit_TextChanged);
			// 
			// btnCalc
			// 
			this.btnCalc.Location = new System.Drawing.Point(140, 318);
			this.btnCalc.Name = "btnCalc";
			this.btnCalc.Size = new System.Drawing.Size(127, 46);
			this.btnCalc.TabIndex = 7;
			this.btnCalc.Text = "Calcular";
			this.btnCalc.UseVisualStyleBackColor = true;
			this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(296, 318);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(127, 46);
			this.btnClear.TabIndex = 8;
			this.btnClear.Text = "Limpar";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(456, 318);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(127, 46);
			this.btnExit.TabIndex = 9;
			this.btnExit.Text = "Sair";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(653, 450);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnCalc);
			this.Controls.Add(this.txtSit);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtAltura);
			this.Controls.Add(this.txtPeso);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.peso);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label peso;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MaskedTextBox txtPeso;
		private System.Windows.Forms.MaskedTextBox txtAltura;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioMasc;
		private System.Windows.Forms.RadioButton radioFem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtSit;
		private System.Windows.Forms.Button btnCalc;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnExit;
	}
}

