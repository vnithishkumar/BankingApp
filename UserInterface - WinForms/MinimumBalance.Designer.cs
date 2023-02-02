
namespace Banking.UserInterface
{
    partial class MinimumBalance
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
            this.minibalpanel = new System.Windows.Forms.Panel();
            this.miniballbl = new System.Windows.Forms.Label();
            this.minibalpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // minibalpanel
            // 
            this.minibalpanel.Controls.Add(this.miniballbl);
            this.minibalpanel.Location = new System.Drawing.Point(3, 3);
            this.minibalpanel.Name = "minibalpanel";
            this.minibalpanel.Size = new System.Drawing.Size(521, 354);
            this.minibalpanel.TabIndex = 0;
            // 
            // miniballbl
            // 
            this.miniballbl.AutoSize = true;
            this.miniballbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.miniballbl.ForeColor = System.Drawing.Color.Blue;
            this.miniballbl.Location = new System.Drawing.Point(46, 45);
            this.miniballbl.Name = "miniballbl";
            this.miniballbl.Size = new System.Drawing.Size(0, 17);
            this.miniballbl.TabIndex = 1;
            // 
            // MinimumBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.minibalpanel);
            this.Name = "MinimumBalance";
            this.Size = new System.Drawing.Size(524, 357);
            this.minibalpanel.ResumeLayout(false);
            this.minibalpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel minibalpanel;
        private System.Windows.Forms.Label miniballbl;
    }
}
