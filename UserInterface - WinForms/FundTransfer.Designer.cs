
namespace Banking.UserInterface
{
    partial class FundTransfer
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
			this.fundtransferpanel = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.ftavailablebaltbx = new System.Windows.Forms.TextBox();
			this.beneaccountnotbx = new System.Windows.Forms.TextBox();
			this.availballbl = new System.Windows.Forms.Label();
			this.accnolbl = new System.Windows.Forms.Label();
			this.transferbtn = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.ftamounttbx = new System.Windows.Forms.TextBox();
			this.fundtransferpanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// fundtransferpanel
			// 
			this.fundtransferpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fundtransferpanel.Controls.Add(this.label1);
			this.fundtransferpanel.Controls.Add(this.ftavailablebaltbx);
			this.fundtransferpanel.Controls.Add(this.beneaccountnotbx);
			this.fundtransferpanel.Controls.Add(this.availballbl);
			this.fundtransferpanel.Controls.Add(this.accnolbl);
			this.fundtransferpanel.Controls.Add(this.transferbtn);
			this.fundtransferpanel.Controls.Add(this.label5);
			this.fundtransferpanel.Controls.Add(this.ftamounttbx);
			this.fundtransferpanel.Location = new System.Drawing.Point(3, 3);
			this.fundtransferpanel.Name = "fundtransferpanel";
			this.fundtransferpanel.Size = new System.Drawing.Size(518, 351);
			this.fundtransferpanel.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(44, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 23);
			this.label1.TabIndex = 54;
			this.label1.Text = "Fund Transfer";
			// 
			// ftavailablebaltbx
			// 
			this.ftavailablebaltbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ftavailablebaltbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.ftavailablebaltbx.Location = new System.Drawing.Point(192, 91);
			this.ftavailablebaltbx.MaxLength = 11;
			this.ftavailablebaltbx.Name = "ftavailablebaltbx";
			this.ftavailablebaltbx.ReadOnly = true;
			this.ftavailablebaltbx.Size = new System.Drawing.Size(225, 23);
			this.ftavailablebaltbx.TabIndex = 53;
			// 
			// beneaccountnotbx
			// 
			this.beneaccountnotbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.beneaccountnotbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.beneaccountnotbx.Location = new System.Drawing.Point(192, 143);
			this.beneaccountnotbx.MaxLength = 8;
			this.beneaccountnotbx.Name = "beneaccountnotbx";
			this.beneaccountnotbx.Size = new System.Drawing.Size(225, 23);
			this.beneaccountnotbx.TabIndex = 52;
			this.beneaccountnotbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.beneaccountnotbx_KeyPress);
			// 
			// availballbl
			// 
			this.availballbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.availballbl.AutoSize = true;
			this.availballbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.availballbl.Location = new System.Drawing.Point(44, 91);
			this.availballbl.Name = "availballbl";
			this.availballbl.Size = new System.Drawing.Size(120, 17);
			this.availballbl.TabIndex = 51;
			this.availballbl.Text = "Available Balance";
			// 
			// accnolbl
			// 
			this.accnolbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.accnolbl.AutoSize = true;
			this.accnolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.accnolbl.Location = new System.Drawing.Point(44, 146);
			this.accnolbl.Name = "accnolbl";
			this.accnolbl.Size = new System.Drawing.Size(138, 17);
			this.accnolbl.TabIndex = 50;
			this.accnolbl.Text = "Beneficiary Acc Num";
			// 
			// transferbtn
			// 
			this.transferbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.transferbtn.Location = new System.Drawing.Point(196, 257);
			this.transferbtn.Name = "transferbtn";
			this.transferbtn.Size = new System.Drawing.Size(147, 36);
			this.transferbtn.TabIndex = 49;
			this.transferbtn.Text = "Transfer";
			this.transferbtn.UseVisualStyleBackColor = true;
			this.transferbtn.Click += new System.EventHandler(this.transferbtn_Click);
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.label5.Location = new System.Drawing.Point(44, 201);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(117, 17);
			this.label5.TabIndex = 48;
			this.label5.Text = "Enter the amount";
			// 
			// ftamounttbx
			// 
			this.ftamounttbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ftamounttbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.ftamounttbx.Location = new System.Drawing.Point(192, 198);
			this.ftamounttbx.MaxLength = 11;
			this.ftamounttbx.Name = "ftamounttbx";
			this.ftamounttbx.Size = new System.Drawing.Size(225, 23);
			this.ftamounttbx.TabIndex = 47;
			this.ftamounttbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ftamounttbx_KeyPress);
			// 
			// FundTransfer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.fundtransferpanel);
			this.Name = "FundTransfer";
			this.Size = new System.Drawing.Size(524, 357);
			this.fundtransferpanel.ResumeLayout(false);
			this.fundtransferpanel.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel fundtransferpanel;
        private System.Windows.Forms.TextBox ftavailablebaltbx;
        private System.Windows.Forms.TextBox beneaccountnotbx;
        private System.Windows.Forms.Label availballbl;
        private System.Windows.Forms.Label accnolbl;
        private System.Windows.Forms.Button transferbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ftamounttbx;
        private System.Windows.Forms.Label label1;
    }
}
