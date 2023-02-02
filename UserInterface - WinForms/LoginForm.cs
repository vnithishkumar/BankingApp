using System;
using System.Windows.Forms;
using Banking.Business;


namespace Banking.UserInterface
{
	public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            passwordTxt.PasswordChar = '*';
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (CusIdTxt.Text == "")
                MessageBox.Show("Please Enter the Customer ID");
            else if(passwordTxt.Text == "")
                MessageBox.Show("Please Enter the Password");

            if (CusIdTxt.Text != "" && passwordTxt.Text != "")
            {
                int cusId = int.Parse(CusIdTxt.Text);

                string password = passwordTxt.Text;

                LoginBll bll = new LoginBll();

                string result = bll.ValidateCredentials(cusId, password);

                if (result == "success")
                {
                    this.Hide();
                    DisplayAccountsForm disAccForm = new DisplayAccountsForm(cusId);
                    disAccForm.ShowDialog();
                }
                else
                    MessageBox.Show(result);
            }
        }

        private void CusIdTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '\b'))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numerics");
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

		private void LoginForm_Load(object sender, EventArgs e)
		{
            
            //this.WindowState = FormWindowState.Maximized;
        }
	}
}
