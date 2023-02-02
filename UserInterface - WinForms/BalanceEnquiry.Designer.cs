
namespace Banking.UserInterface
{
    partial class BalanceEnquiry
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
			this.balancepanel = new System.Windows.Forms.Panel();
			this.balenqavailablebaltbx = new System.Windows.Forms.TextBox();
			this.balenqaccountnotbx = new System.Windows.Forms.TextBox();
			this.availballbl = new System.Windows.Forms.Label();
			this.accnolbl = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.balancepanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// balancepanel
			// 
			this.balancepanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.balancepanel.Controls.Add(this.balenqavailablebaltbx);
			this.balancepanel.Controls.Add(this.balenqaccountnotbx);
			this.balancepanel.Controls.Add(this.availballbl);
			this.balancepanel.Controls.Add(this.accnolbl);
			this.balancepanel.Controls.Add(this.label1);
			this.balancepanel.Location = new System.Drawing.Point(3, 0);
			this.balancepanel.Name = "balancepanel";
			this.balancepanel.Size = new System.Drawing.Size(518, 354);
			this.balancepanel.TabIndex = 0;
			// 
			// balenqavailablebaltbx
			// 
			this.balenqavailablebaltbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.balenqavailablebaltbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.balenqavailablebaltbx.Location = new System.Drawing.Point(190, 147);
			this.balenqavailablebaltbx.MaxLength = 11;
			this.balenqavailablebaltbx.Name = "balenqavailablebaltbx";
			this.balenqavailablebaltbx.ReadOnly = true;
			this.balenqavailablebaltbx.Size = new System.Drawing.Size(225, 23);
			this.balenqavailablebaltbx.TabIndex = 58;
			// 
			// balenqaccountnotbx
			// 
			this.balenqaccountnotbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.balenqaccountnotbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.balenqaccountnotbx.Location = new System.Drawing.Point(190, 97);
			this.balenqaccountnotbx.MaxLength = 11;
			this.balenqaccountnotbx.Name = "balenqaccountnotbx";
			this.balenqaccountnotbx.ReadOnly = true;
			this.balenqaccountnotbx.Size = new System.Drawing.Size(225, 23);
			this.balenqaccountnotbx.TabIndex = 57;
			// 
			// availballbl
			// 
			this.availballbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.availballbl.AutoSize = true;
			this.availballbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.availballbl.Location = new System.Drawing.Point(29, 147);
			this.availballbl.Name = "availballbl";
			this.availballbl.Size = new System.Drawing.Size(120, 17);
			this.availballbl.TabIndex = 56;
			this.availballbl.Text = "Available Balance";
			// 
			// accnolbl
			// 
			this.accnolbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.accnolbl.AutoSize = true;
			this.accnolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.accnolbl.Location = new System.Drawing.Point(29, 97);
			this.accnolbl.Name = "accnolbl";
			this.accnolbl.Size = new System.Drawing.Size(113, 17);
			this.accnolbl.TabIndex = 54;
			this.accnolbl.Text = "Account Number";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(29, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 18);
			this.label1.TabIndex = 46;
			this.label1.Text = "Balance Enquiry";
			// 
			// BalanceEnquiry
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.balancepanel);
			this.Name = "BalanceEnquiry";
			this.Size = new System.Drawing.Size(524, 357);
			this.balancepanel.ResumeLayout(false);
			this.balancepanel.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel balancepanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label availballbl;
        private System.Windows.Forms.Label accnolbl;
        private System.Windows.Forms.TextBox balenqavailablebaltbx;
        private System.Windows.Forms.TextBox balenqaccountnotbx;
    }
}
