
namespace Banking.UserInterface
{
    partial class Mini_Statement
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
			this.ministmtpanel = new System.Windows.Forms.Panel();
			this.ministmtdgv = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.ministmtpanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ministmtdgv)).BeginInit();
			this.SuspendLayout();
			// 
			// ministmtpanel
			// 
			this.ministmtpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ministmtpanel.Controls.Add(this.label1);
			this.ministmtpanel.Controls.Add(this.ministmtdgv);
			this.ministmtpanel.Location = new System.Drawing.Point(3, 3);
			this.ministmtpanel.Name = "ministmtpanel";
			this.ministmtpanel.Size = new System.Drawing.Size(521, 351);
			this.ministmtpanel.TabIndex = 0;
			// 
			// ministmtdgv
			// 
			this.ministmtdgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ministmtdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.ministmtdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ministmtdgv.Location = new System.Drawing.Point(3, 29);
			this.ministmtdgv.Name = "ministmtdgv";
			this.ministmtdgv.Size = new System.Drawing.Size(515, 319);
			this.ministmtdgv.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(156, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(203, 26);
			this.label1.TabIndex = 2;
			this.label1.Text = "Mini Statement";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Mini_Statement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ministmtpanel);
			this.Name = "Mini_Statement";
			this.Size = new System.Drawing.Size(524, 357);
			this.ministmtpanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ministmtdgv)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ministmtpanel;
        private System.Windows.Forms.DataGridView ministmtdgv;
		private System.Windows.Forms.Label label1;
	}
}
