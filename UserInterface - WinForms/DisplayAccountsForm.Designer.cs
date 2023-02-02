
namespace Banking.UserInterface
{
    partial class DisplayAccountsForm
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
			this.dgv1 = new System.Windows.Forms.DataGridView();
			this.accountnolbl = new System.Windows.Forms.Label();
			this.accountnotxt = new System.Windows.Forms.TextBox();
			this.proceedbtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.toppanel2 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv1
			// 
			this.dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv1.Location = new System.Drawing.Point(65, 97);
			this.dgv1.Name = "dgv1";
			this.dgv1.Size = new System.Drawing.Size(424, 117);
			this.dgv1.TabIndex = 0;
			// 
			// accountnolbl
			// 
			this.accountnolbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.accountnolbl.AutoSize = true;
			this.accountnolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.accountnolbl.Location = new System.Drawing.Point(62, 342);
			this.accountnolbl.Name = "accountnolbl";
			this.accountnolbl.Size = new System.Drawing.Size(81, 17);
			this.accountnolbl.TabIndex = 1;
			this.accountnolbl.Text = "Account No";
			// 
			// accountnotxt
			// 
			this.accountnotxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.accountnotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.accountnotxt.Location = new System.Drawing.Point(169, 339);
			this.accountnotxt.MaxLength = 8;
			this.accountnotxt.Name = "accountnotxt";
			this.accountnotxt.Size = new System.Drawing.Size(304, 23);
			this.accountnotxt.TabIndex = 2;
			this.accountnotxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.accountnotxt_KeyPress);
			// 
			// proceedbtn
			// 
			this.proceedbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.proceedbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.proceedbtn.Location = new System.Drawing.Point(169, 391);
			this.proceedbtn.Name = "proceedbtn";
			this.proceedbtn.Size = new System.Drawing.Size(241, 33);
			this.proceedbtn.TabIndex = 3;
			this.proceedbtn.Text = "Proceed";
			this.proceedbtn.UseVisualStyleBackColor = true;
			this.proceedbtn.Click += new System.EventHandler(this.proceedbtn_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.label1.Location = new System.Drawing.Point(62, 296);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(400, 18);
			this.label1.TabIndex = 4;
			this.label1.Text = "Enter the account number you want to make the transaction";
			// 
			// toppanel2
			// 
			this.toppanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.toppanel2.Location = new System.Drawing.Point(1, 12);
			this.toppanel2.Name = "toppanel2";
			this.toppanel2.Size = new System.Drawing.Size(584, 32);
			this.toppanel2.TabIndex = 6;
			// 
			// DisplayAccountsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 561);
			this.Controls.Add(this.toppanel2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.proceedbtn);
			this.Controls.Add(this.accountnotxt);
			this.Controls.Add(this.accountnolbl);
			this.Controls.Add(this.dgv1);
			this.Name = "DisplayAccountsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AccountDetails";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DisplayAccountsForm_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label accountnolbl;
        private System.Windows.Forms.TextBox accountnotxt;
        private System.Windows.Forms.Button proceedbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel toppanel2;
    }
}