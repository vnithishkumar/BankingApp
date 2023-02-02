
namespace Banking.UserInterface
{
    partial class Loan
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
            this.loanpanel = new System.Windows.Forms.Panel();
            this.loanlbl = new System.Windows.Forms.Label();
            this.loanpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loanpanel
            // 
            this.loanpanel.Controls.Add(this.loanlbl);
            this.loanpanel.Location = new System.Drawing.Point(3, 3);
            this.loanpanel.Name = "loanpanel";
            this.loanpanel.Size = new System.Drawing.Size(512, 348);
            this.loanpanel.TabIndex = 0;
            // 
            // loanlbl
            // 
            this.loanlbl.AutoSize = true;
            this.loanlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.loanlbl.ForeColor = System.Drawing.Color.Blue;
            this.loanlbl.Location = new System.Drawing.Point(46, 45);
            this.loanlbl.Name = "loanlbl";
            this.loanlbl.Size = new System.Drawing.Size(46, 17);
            this.loanlbl.TabIndex = 1;
            this.loanlbl.Text = "label1";
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loanpanel);
            this.Name = "Loan";
            this.Size = new System.Drawing.Size(518, 354);
            this.loanpanel.ResumeLayout(false);
            this.loanpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loanpanel;
        private System.Windows.Forms.Label loanlbl;
    }
}
