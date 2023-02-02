
using System.Windows.Forms;

namespace Banking.UserInterface
{
    partial class Withdraw
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
			this.withdrawuc = new System.Windows.Forms.Panel();
			this.withdrawavailablebaltbx = new System.Windows.Forms.TextBox();
			this.withdrawaccountnotbx = new System.Windows.Forms.TextBox();
			this.availballbl = new System.Windows.Forms.Label();
			this.accnolbl = new System.Windows.Forms.Label();
			this.withdrawbtn = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.withdrawamounttbx = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.withdrawuc.SuspendLayout();
			this.SuspendLayout();
			// 
			// withdrawuc
			// 
			this.withdrawuc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.withdrawuc.Controls.Add(this.withdrawavailablebaltbx);
			this.withdrawuc.Controls.Add(this.withdrawaccountnotbx);
			this.withdrawuc.Controls.Add(this.availballbl);
			this.withdrawuc.Controls.Add(this.accnolbl);
			this.withdrawuc.Controls.Add(this.withdrawbtn);
			this.withdrawuc.Controls.Add(this.label5);
			this.withdrawuc.Controls.Add(this.withdrawamounttbx);
			this.withdrawuc.Controls.Add(this.label1);
			this.withdrawuc.Location = new System.Drawing.Point(3, 3);
			this.withdrawuc.Name = "withdrawuc";
			this.withdrawuc.Size = new System.Drawing.Size(524, 357);
			this.withdrawuc.TabIndex = 0;
			// 
			// withdrawavailablebaltbx
			// 
			this.withdrawavailablebaltbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.withdrawavailablebaltbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.withdrawavailablebaltbx.Location = new System.Drawing.Point(177, 141);
			this.withdrawavailablebaltbx.MaxLength = 11;
			this.withdrawavailablebaltbx.Name = "withdrawavailablebaltbx";
			this.withdrawavailablebaltbx.ReadOnly = true;
			this.withdrawavailablebaltbx.Size = new System.Drawing.Size(225, 23);
			this.withdrawavailablebaltbx.TabIndex = 46;
			// 
			// withdrawaccountnotbx
			// 
			this.withdrawaccountnotbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.withdrawaccountnotbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.withdrawaccountnotbx.Location = new System.Drawing.Point(177, 91);
			this.withdrawaccountnotbx.MaxLength = 11;
			this.withdrawaccountnotbx.Name = "withdrawaccountnotbx";
			this.withdrawaccountnotbx.ReadOnly = true;
			this.withdrawaccountnotbx.Size = new System.Drawing.Size(225, 23);
			this.withdrawaccountnotbx.TabIndex = 45;
			// 
			// availballbl
			// 
			this.availballbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.availballbl.AutoSize = true;
			this.availballbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.availballbl.Location = new System.Drawing.Point(29, 141);
			this.availballbl.Name = "availballbl";
			this.availballbl.Size = new System.Drawing.Size(120, 17);
			this.availballbl.TabIndex = 44;
			this.availballbl.Text = "Available Balance";
			// 
			// accnolbl
			// 
			this.accnolbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.accnolbl.AutoSize = true;
			this.accnolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.accnolbl.Location = new System.Drawing.Point(29, 91);
			this.accnolbl.Name = "accnolbl";
			this.accnolbl.Size = new System.Drawing.Size(113, 17);
			this.accnolbl.TabIndex = 42;
			this.accnolbl.Text = "Account Number";
			// 
			// withdrawbtn
			// 
			this.withdrawbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.withdrawbtn.Location = new System.Drawing.Point(181, 256);
			this.withdrawbtn.Name = "withdrawbtn";
			this.withdrawbtn.Size = new System.Drawing.Size(147, 36);
			this.withdrawbtn.TabIndex = 40;
			this.withdrawbtn.Text = "Withdraw";
			this.withdrawbtn.UseVisualStyleBackColor = true;
			this.withdrawbtn.Click += new System.EventHandler(this.withdrawbtn_Click);
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.label5.Location = new System.Drawing.Point(29, 200);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(117, 17);
			this.label5.TabIndex = 39;
			this.label5.Text = "Enter the amount";
			// 
			// withdrawamounttbx
			// 
			this.withdrawamounttbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.withdrawamounttbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.withdrawamounttbx.Location = new System.Drawing.Point(177, 197);
			this.withdrawamounttbx.MaxLength = 11;
			this.withdrawamounttbx.Name = "withdrawamounttbx";
			this.withdrawamounttbx.Size = new System.Drawing.Size(225, 23);
			this.withdrawamounttbx.TabIndex = 38;
			this.withdrawamounttbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.withdrawamounttxt_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(29, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Withdrawal";
			// 
			// Withdraw
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.withdrawuc);
			this.Name = "Withdraw";
			this.Size = new System.Drawing.Size(530, 363);
			this.withdrawuc.ResumeLayout(false);
			this.withdrawuc.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private Panel withdrawuc;
        private Label label1;
        private Label availballbl;
        private Label accnolbl;
        private Button withdrawbtn;
        private Label label5;
        private TextBox withdrawamounttbx;
        private TextBox withdrawavailablebaltbx;
        private TextBox withdrawaccountnotbx;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
