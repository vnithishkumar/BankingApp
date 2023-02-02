
namespace Banking.UserInterface
{
	partial class LoginForm
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.CusIdTxt = new System.Windows.Forms.TextBox();
			this.passwordTxt = new System.Windows.Forms.TextBox();
			this.loginbtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(228, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(143, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "BANK OF EMIS";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.label2.Location = new System.Drawing.Point(107, 140);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "CustomerId";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.label3.Location = new System.Drawing.Point(107, 207);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Password";
			// 
			// CusIdTxt
			// 
			this.CusIdTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CusIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.CusIdTxt.Location = new System.Drawing.Point(208, 137);
			this.CusIdTxt.Name = "CusIdTxt";
			this.CusIdTxt.Size = new System.Drawing.Size(269, 23);
			this.CusIdTxt.TabIndex = 3;
			this.CusIdTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CusIdTxt_KeyPress);
			// 
			// passwordTxt
			// 
			this.passwordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.passwordTxt.Location = new System.Drawing.Point(209, 207);
			this.passwordTxt.Name = "passwordTxt";
			this.passwordTxt.Size = new System.Drawing.Size(268, 23);
			this.passwordTxt.TabIndex = 4;
			// 
			// loginbtn
			// 
			this.loginbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.loginbtn.Location = new System.Drawing.Point(209, 291);
			this.loginbtn.Name = "loginbtn";
			this.loginbtn.Size = new System.Drawing.Size(200, 36);
			this.loginbtn.TabIndex = 5;
			this.loginbtn.Text = "Login";
			this.loginbtn.UseVisualStyleBackColor = true;
			this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 511);
			this.Controls.Add(this.loginbtn);
			this.Controls.Add(this.passwordTxt);
			this.Controls.Add(this.CusIdTxt);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
			this.Load += new System.EventHandler(this.LoginForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox CusIdTxt;
		private System.Windows.Forms.TextBox passwordTxt;
		private System.Windows.Forms.Button loginbtn;
	}
}

