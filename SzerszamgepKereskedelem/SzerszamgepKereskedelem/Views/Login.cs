using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SzerszamgepKereskedelem.Presenters;
using SzerszamgepKereskedelem.ViewInterfaces;

namespace SzerszamgepKereskedelem.Views
{
    public partial class Login : Form, ILoginView
    {
        private LoginPresenter presenter;
        public Login()
        {
            InitializeComponent();
            presenter = new LoginPresenter(this);
        }

        public string ErrorMessage { set => errorProviderLogin.SetError(textBoxUserName, value); }

        public string UserName { get => textBoxUserName.Text;}

        public string Password  { get => textBoxPassword.Text; }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            presenter.Authenticate();
            if (presenter.LoginSucces)
            {
                var mw = new MainWindow();
                Hide();
                mw.ShowDialog();
                Close();
            }
        }

        private void textBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                buttonLogin.PerformClick();
            }
        }
    }
}
