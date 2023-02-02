
namespace Banking.UserInterface
{
    partial class Menu
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
			this.selectoptionlbl = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.remittenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.withdrawalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.depositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.accountBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.miniStaementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.balanceInquiryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.otherInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fDInterestRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rDInterestRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.benefitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.minimumnBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainpanel = new System.Windows.Forms.Panel();
			this.toppanel = new System.Windows.Forms.Panel();
			this.menuStrip1.SuspendLayout();
			this.mainpanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// selectoptionlbl
			// 
			this.selectoptionlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.selectoptionlbl.AutoSize = true;
			this.selectoptionlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.selectoptionlbl.Location = new System.Drawing.Point(103, 0);
			this.selectoptionlbl.Name = "selectoptionlbl";
			this.selectoptionlbl.Size = new System.Drawing.Size(283, 17);
			this.selectoptionlbl.TabIndex = 24;
			this.selectoptionlbl.Text = "Select the above operation to be performed";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remittenceToolStripMenuItem,
            this.toolStripMenuItem1,
            this.balanceInquiryToolStripMenuItem,
            this.otherInfoToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(584, 24);
			this.menuStrip1.TabIndex = 28;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// remittenceToolStripMenuItem
			// 
			this.remittenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.withdrawalToolStripMenuItem,
            this.depositToolStripMenuItem});
			this.remittenceToolStripMenuItem.Name = "remittenceToolStripMenuItem";
			this.remittenceToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
			this.remittenceToolStripMenuItem.Text = "Remittence";
			// 
			// withdrawalToolStripMenuItem
			// 
			this.withdrawalToolStripMenuItem.Name = "withdrawalToolStripMenuItem";
			this.withdrawalToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.withdrawalToolStripMenuItem.Text = "Withdrawal";
			this.withdrawalToolStripMenuItem.Click += new System.EventHandler(this.withdrawalToolStripMenuItem_Click);
			// 
			// depositToolStripMenuItem
			// 
			this.depositToolStripMenuItem.Name = "depositToolStripMenuItem";
			this.depositToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.depositToolStripMenuItem.Text = "Deposit";
			this.depositToolStripMenuItem.Click += new System.EventHandler(this.depositToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountBalanceToolStripMenuItem,
            this.miniStaementToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(103, 20);
			this.toolStripMenuItem1.Text = "Balance Enquiry";
			// 
			// accountBalanceToolStripMenuItem
			// 
			this.accountBalanceToolStripMenuItem.Name = "accountBalanceToolStripMenuItem";
			this.accountBalanceToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.accountBalanceToolStripMenuItem.Text = "Account Balance";
			this.accountBalanceToolStripMenuItem.Click += new System.EventHandler(this.accountBalanceToolStripMenuItem_Click);
			// 
			// miniStaementToolStripMenuItem
			// 
			this.miniStaementToolStripMenuItem.Name = "miniStaementToolStripMenuItem";
			this.miniStaementToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.miniStaementToolStripMenuItem.Text = "Mini Staement";
			this.miniStaementToolStripMenuItem.Click += new System.EventHandler(this.miniStaementToolStripMenuItem_Click);
			// 
			// balanceInquiryToolStripMenuItem
			// 
			this.balanceInquiryToolStripMenuItem.Name = "balanceInquiryToolStripMenuItem";
			this.balanceInquiryToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
			this.balanceInquiryToolStripMenuItem.Text = "Fund Transfer";
			this.balanceInquiryToolStripMenuItem.Click += new System.EventHandler(this.FundTransferToolStripMenuItem_Click);
			// 
			// otherInfoToolStripMenuItem
			// 
			this.otherInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fDInterestRateToolStripMenuItem,
            this.rDInterestRateToolStripMenuItem,
            this.benefitsToolStripMenuItem,
            this.loanToolStripMenuItem,
            this.minimumnBalanceToolStripMenuItem});
			this.otherInfoToolStripMenuItem.Name = "otherInfoToolStripMenuItem";
			this.otherInfoToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
			this.otherInfoToolStripMenuItem.Text = "Other Info";
			// 
			// fDInterestRateToolStripMenuItem
			// 
			this.fDInterestRateToolStripMenuItem.Name = "fDInterestRateToolStripMenuItem";
			this.fDInterestRateToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.fDInterestRateToolStripMenuItem.Text = "FD Interest Rate";
			this.fDInterestRateToolStripMenuItem.Click += new System.EventHandler(this.fDInterestRateToolStripMenuItem_Click);
			// 
			// rDInterestRateToolStripMenuItem
			// 
			this.rDInterestRateToolStripMenuItem.Name = "rDInterestRateToolStripMenuItem";
			this.rDInterestRateToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.rDInterestRateToolStripMenuItem.Text = "RD Interest Rate";
			this.rDInterestRateToolStripMenuItem.Click += new System.EventHandler(this.rDInterestRateToolStripMenuItem_Click);
			// 
			// benefitsToolStripMenuItem
			// 
			this.benefitsToolStripMenuItem.Name = "benefitsToolStripMenuItem";
			this.benefitsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.benefitsToolStripMenuItem.Text = "Benefits";
			this.benefitsToolStripMenuItem.Click += new System.EventHandler(this.benefitsToolStripMenuItem_Click);
			// 
			// loanToolStripMenuItem
			// 
			this.loanToolStripMenuItem.Name = "loanToolStripMenuItem";
			this.loanToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.loanToolStripMenuItem.Text = "Loan";
			this.loanToolStripMenuItem.Click += new System.EventHandler(this.loanToolStripMenuItem_Click);
			// 
			// minimumnBalanceToolStripMenuItem
			// 
			this.minimumnBalanceToolStripMenuItem.Name = "minimumnBalanceToolStripMenuItem";
			this.minimumnBalanceToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.minimumnBalanceToolStripMenuItem.Text = "MinimumBalance";
			this.minimumnBalanceToolStripMenuItem.Click += new System.EventHandler(this.minimumnBalanceToolStripMenuItem_Click);
			// 
			// mainpanel
			// 
			this.mainpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mainpanel.AutoSize = true;
			this.mainpanel.Controls.Add(this.selectoptionlbl);
			this.mainpanel.Location = new System.Drawing.Point(29, 89);
			this.mainpanel.Name = "mainpanel";
			this.mainpanel.Size = new System.Drawing.Size(524, 357);
			this.mainpanel.TabIndex = 31;
			// 
			// toppanel
			// 
			this.toppanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.toppanel.AutoSize = true;
			this.toppanel.Location = new System.Drawing.Point(0, 27);
			this.toppanel.Name = "toppanel";
			this.toppanel.Size = new System.Drawing.Size(584, 35);
			this.toppanel.TabIndex = 30;
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 511);
			this.Controls.Add(this.mainpanel);
			this.Controls.Add(this.toppanel);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Menu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Menu";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.mainpanel.ResumeLayout(false);
			this.mainpanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label selectoptionlbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem remittenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balanceInquiryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.ToolStripMenuItem miniStaementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountBalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fDInterestRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rDInterestRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem benefitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimumnBalanceToolStripMenuItem;
	}
}