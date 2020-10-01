namespace Atividade4
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
			this.txtLadoA = new System.Windows.Forms.TextBox();
			this.txtLadoB = new System.Windows.Forms.TextBox();
			this.txtLadoC = new System.Windows.Forms.TextBox();
			this.btnCalc = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txtRes = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(185, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Lado A";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(185, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Lado B";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(185, 139);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Lado C";
			// 
			// txtLadoA
			// 
			this.txtLadoA.Location = new System.Drawing.Point(243, 25);
			this.txtLadoA.Name = "txtLadoA";
			this.txtLadoA.Size = new System.Drawing.Size(152, 20);
			this.txtLadoA.TabIndex = 3;
			// 
			// txtLadoB
			// 
			this.txtLadoB.Location = new System.Drawing.Point(243, 75);
			this.txtLadoB.Name = "txtLadoB";
			this.txtLadoB.Size = new System.Drawing.Size(152, 20);
			this.txtLadoB.TabIndex = 4;
			// 
			// txtLadoC
			// 
			this.txtLadoC.Location = new System.Drawing.Point(243, 136);
			this.txtLadoC.Name = "txtLadoC";
			this.txtLadoC.Size = new System.Drawing.Size(152, 20);
			this.txtLadoC.TabIndex = 5;
			// 
			// btnCalc
			// 
			this.btnCalc.Location = new System.Drawing.Point(155, 283);
			this.btnCalc.Name = "btnCalc";
			this.btnCalc.Size = new System.Drawing.Size(84, 62);
			this.btnCalc.TabIndex = 6;
			this.btnCalc.Text = "Calcular";
			this.btnCalc.UseVisualStyleBackColor = true;
			this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(264, 283);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(84, 62);
			this.btnClear.TabIndex = 7;
			this.btnClear.Text = "Limpar";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(381, 283);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(84, 62);
			this.btnExit.TabIndex = 8;
			this.btnExit.Text = "Sair";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(185, 205);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Triangulo";
			// 
			// txtRes
			// 
			this.txtRes.Location = new System.Drawing.Point(243, 202);
			this.txtRes.Name = "txtRes";
			this.txtRes.Size = new System.Drawing.Size(152, 20);
			this.txtRes.TabIndex = 10;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(621, 450);
			this.Controls.Add(this.txtRes);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnCalc);
			this.Controls.Add(this.txtLadoC);
			this.Controls.Add(this.txtLadoB);
			this.Controls.Add(this.txtLadoA);
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
		private System.Windows.Forms.TextBox txtLadoA;
		private System.Windows.Forms.TextBox txtLadoB;
		private System.Windows.Forms.TextBox txtLadoC;
		private System.Windows.Forms.Button btnCalc;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtRes;
	}
}

