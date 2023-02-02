
namespace Banking.UserInterface
{
    partial class Benefits
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.benefitlbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.benefitlbl);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 354);
            this.panel1.TabIndex = 0;
            // 
            // benefitlbl
            // 
            this.benefitlbl.AutoSize = true;
            this.benefitlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.benefitlbl.ForeColor = System.Drawing.Color.Blue;
            this.benefitlbl.Location = new System.Drawing.Point(46, 45);
            this.benefitlbl.Name = "benefitlbl";
            this.benefitlbl.Size = new System.Drawing.Size(0, 17);
            this.benefitlbl.TabIndex = 0;
            // 
            // Benefits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Benefits";
            this.Size = new System.Drawing.Size(524, 357);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label benefitlbl;
    }
}
