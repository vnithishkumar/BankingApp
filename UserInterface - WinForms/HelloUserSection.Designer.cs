
namespace Banking.UserInterface
{
    partial class HelloUserSection
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
			this.Hellopanel = new System.Windows.Forms.Panel();
			this.namelbl = new System.Windows.Forms.Label();
			this.hellolbl = new System.Windows.Forms.Label();
			this.logoutlink = new System.Windows.Forms.LinkLabel();
			this.backbtn = new System.Windows.Forms.Button();
			this.Hellopanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// Hellopanel
			// 
			this.Hellopanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Hellopanel.AutoSize = true;
			this.Hellopanel.Controls.Add(this.backbtn);
			this.Hellopanel.Controls.Add(this.namelbl);
			this.Hellopanel.Controls.Add(this.hellolbl);
			this.Hellopanel.Controls.Add(this.logoutlink);
			this.Hellopanel.Location = new System.Drawing.Point(0, 0);
			this.Hellopanel.Name = "Hellopanel";
			this.Hellopanel.Size = new System.Drawing.Size(553, 35);
			this.Hellopanel.TabIndex = 0;
			// 
			// namelbl
			// 
			this.namelbl.AutoSize = true;
			this.namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.namelbl.ForeColor = System.Drawing.Color.Blue;
			this.namelbl.Location = new System.Drawing.Point(60, 14);
			this.namelbl.Name = "namelbl";
			this.namelbl.Size = new System.Drawing.Size(45, 17);
			this.namelbl.TabIndex = 28;
			this.namelbl.Text = "Name";
			// 
			// hellolbl
			// 
			this.hellolbl.AutoSize = true;
			this.hellolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.hellolbl.Location = new System.Drawing.Point(14, 14);
			this.hellolbl.Name = "hellolbl";
			this.hellolbl.Size = new System.Drawing.Size(40, 17);
			this.hellolbl.TabIndex = 27;
			this.hellolbl.Text = "Hello";
			// 
			// logoutlink
			// 
			this.logoutlink.AutoSize = true;
			this.logoutlink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.logoutlink.LinkColor = System.Drawing.Color.Red;
			this.logoutlink.Location = new System.Drawing.Point(498, 14);
			this.logoutlink.Name = "logoutlink";
			this.logoutlink.Size = new System.Drawing.Size(52, 17);
			this.logoutlink.TabIndex = 26;
			this.logoutlink.TabStop = true;
			this.logoutlink.Text = "Logout";
			this.logoutlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutlink_LinkClicked);
			// 
			// backbtn
			// 
			this.backbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.backbtn.AutoSize = true;
			this.backbtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.backbtn.Location = new System.Drawing.Point(430, 9);
			this.backbtn.Name = "backbtn";
			this.backbtn.Size = new System.Drawing.Size(42, 23);
			this.backbtn.TabIndex = 33;
			this.backbtn.Text = "Back";
			this.backbtn.UseVisualStyleBackColor = true;
			this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
			// 
			// HelloUserSection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.Controls.Add(this.Hellopanel);
			this.Name = "HelloUserSection";
			this.Size = new System.Drawing.Size(568, 38);
			this.Hellopanel.ResumeLayout(false);
			this.Hellopanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Hellopanel;
        private System.Windows.Forms.LinkLabel logoutlink;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label hellolbl;
		private System.Windows.Forms.Button backbtn;
	}
}
