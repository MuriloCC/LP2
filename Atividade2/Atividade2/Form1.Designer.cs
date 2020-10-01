namespace Atividade2
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
			this.txtNum1 = new System.Windows.Forms.TextBox();
			this.txtNum2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtRes = new System.Windows.Forms.TextBox();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnMult = new System.Windows.Forms.Button();
			this.btnSub = new System.Windows.Forms.Button();
			this.btnDiv = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(103, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Numero 1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(103, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Numero 2";
			// 
			// txtNum1
			// 
			this.txtNum1.Location = new System.Drawing.Point(158, 35);
			this.txtNum1.Name = "txtNum1";
			this.txtNum1.Size = new System.Drawing.Size(158, 20);
			this.txtNum1.TabIndex = 2;
			this.txtNum1.TextChanged += new System.EventHandler(this.txtNum1_TextChanged);
			// 
			// txtNum2
			// 
			this.txtNum2.Location = new System.Drawing.Point(158, 101);
			this.txtNum2.Name = "txtNum2";
			this.txtNum2.Size = new System.Drawing.Size(156, 20);
			this.txtNum2.TabIndex = 3;
			this.txtNum2.TextChanged += new System.EventHandler(this.txtNum2_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(101, 176);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Resultado";
			// 
			// txtRes
			// 
			this.txtRes.Location = new System.Drawing.Point(158, 173);
			this.txtRes.Name = "txtRes";
			this.txtRes.Size = new System.Drawing.Size(152, 20);
			this.txtRes.TabIndex = 5;
			this.txtRes.TextChanged += new System.EventHandler(this.txtRes_TextChanged);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(435, 38);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(126, 37);
			this.btnClear.TabIndex = 6;
			this.btnClear.Text = "Limpar";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(435, 104);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(126, 37);
			this.btnExit.TabIndex = 7;
			this.btnExit.Text = "Sair";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(109, 244);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(68, 35);
			this.btnAdd.TabIndex = 8;
			this.btnAdd.Text = "+";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnMult
			// 
			this.btnMult.Location = new System.Drawing.Point(265, 244);
			this.btnMult.Name = "btnMult";
			this.btnMult.Size = new System.Drawing.Size(68, 35);
			this.btnMult.TabIndex = 9;
			this.btnMult.Text = "*";
			this.btnMult.UseVisualStyleBackColor = true;
			this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
			// 
			// btnSub
			// 
			this.btnSub.Location = new System.Drawing.Point(188, 244);
			this.btnSub.Name = "btnSub";
			this.btnSub.Size = new System.Drawing.Size(68, 35);
			this.btnSub.TabIndex = 10;
			this.btnSub.Text = "-";
			this.btnSub.UseVisualStyleBackColor = true;
			this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
			// 
			// btnDiv
			// 
			this.btnDiv.Location = new System.Drawing.Point(343, 244);
			this.btnDiv.Name = "btnDiv";
			this.btnDiv.Size = new System.Drawing.Size(68, 35);
			this.btnDiv.TabIndex = 11;
			this.btnDiv.Text = "/";
			this.btnDiv.UseVisualStyleBackColor = true;
			this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnDiv);
			this.Controls.Add(this.btnSub);
			this.Controls.Add(this.btnMult);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.txtRes);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtNum2);
			this.Controls.Add(this.txtNum1);
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
		private System.Windows.Forms.TextBox txtNum1;
		private System.Windows.Forms.TextBox txtNum2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtRes;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnMult;
		private System.Windows.Forms.Button btnSub;
		private System.Windows.Forms.Button btnDiv;
	}
}

