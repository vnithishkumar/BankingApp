
namespace Banking.UserInterface
{
    partial class Deposit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.availballbl = new System.Windows.Forms.Label();
			this.accnolbl = new System.Windows.Forms.Label();
			this.depositbtn = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.deposittbx = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.depositavailablebaltbx = new System.Windows.Forms.TextBox();
			this.depositaccountnotbx = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// availballbl
			// 
			this.availballbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.availballbl.AutoSize = true;
			this.availballbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.availballbl.Location = new System.Drawing.Point(15, 119);
			this.availballbl.Name = "availballbl";
			this.availballbl.Size = new System.Drawing.Size(120, 17);
			this.availballbl.TabIndex = 52;
			this.availballbl.Text = "Available Balance";
			// 
			// accnolbl
			// 
			this.accnolbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.accnolbl.AutoSize = true;
			this.accnolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.accnolbl.Location = new System.Drawing.Point(15, 69);
			this.accnolbl.Name = "accnolbl";
			this.accnolbl.Size = new System.Drawing.Size(113, 17);
			this.accnolbl.TabIndex = 50;
			this.accnolbl.Text = "Account Number";
			// 
			// depositbtn
			// 
			this.depositbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.depositbtn.Location = new System.Drawing.Point(167, 234);
			this.depositbtn.Name = "depositbtn";
			this.depositbtn.Size = new System.Drawing.Size(187, 40);
			this.depositbtn.TabIndex = 48;
			this.depositbtn.Text = "Deposit";
			this.depositbtn.UseVisualStyleBackColor = true;
			this.depositbtn.Click += new System.EventHandler(this.depositbtn_Click);
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.label5.Location = new System.Drawing.Point(15, 178);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(117, 17);
			this.label5.TabIndex = 47;
			this.label5.Text = "Enter the amount";
			// 
			// deposittbx
			// 
			this.deposittbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.deposittbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.deposittbx.Location = new System.Drawing.Point(163, 175);
			this.deposittbx.Name = "deposittbx";
			this.deposittbx.Size = new System.Drawing.Size(265, 23);
			this.deposittbx.TabIndex = 46;
			this.deposittbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deposittbx_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(15, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 23);
			this.label1.TabIndex = 45;
			this.label1.Text = "Deposit";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// depositavailablebaltbx
			// 
			this.depositavailablebaltbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.depositavailablebaltbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.depositavailablebaltbx.Location = new System.Drawing.Point(163, 119);
			this.depositavailablebaltbx.MaxLength = 11;
			this.depositavailablebaltbx.Name = "depositavailablebaltbx";
			this.depositavailablebaltbx.ReadOnly = true;
			this.depositavailablebaltbx.Size = new System.Drawing.Size(265, 23);
			this.depositavailablebaltbx.TabIndex = 54;
			// 
			// depositaccountnotbx
			// 
			this.depositaccountnotbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.depositaccountnotbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.depositaccountnotbx.Location = new System.Drawing.Point(163, 69);
			this.depositaccountnotbx.MaxLength = 11;
			this.depositaccountnotbx.Name = "depositaccountnotbx";
			this.depositaccountnotbx.ReadOnly = true;
			this.depositaccountnotbx.Size = new System.Drawing.Size(265, 23);
			this.depositaccountnotbx.TabIndex = 53;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.depositavailablebaltbx);
			this.panel1.Controls.Add(this.depositaccountnotbx);
			this.panel1.Controls.Add(this.availballbl);
			this.panel1.Controls.Add(this.accnolbl);
			this.panel1.Controls.Add(this.depositbtn);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.deposittbx);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(3, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(518, 354);
			this.panel1.TabIndex = 55;
			// 
			// Deposit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Name = "Deposit";
			this.Size = new System.Drawing.Size(524, 357);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label availballbl;
        private System.Windows.Forms.Label accnolbl;
        private System.Windows.Forms.Button depositbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox deposittbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox depositavailablebaltbx;
        private System.Windows.Forms.TextBox depositaccountnotbx;
		private System.Windows.Forms.Panel panel1;
	}
}
