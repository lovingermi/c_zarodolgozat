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
    public partial class NewUserWindow : Form, INewUserView
    {
        private NewUserPresenter newUserPresenter;
        private bool save = false; 
        public NewUserWindow()
        {
            InitializeComponent();
            newUserPresenter = new NewUserPresenter(this);
            this.MaximizeBox = false;
        }

        public string userName
        {
            get
            {
                return textBoxUserName.Text;
            }
        }

        public string firstName
        {
            get
            {
                return textBoxFirstName.Text;
            }
        }

        public string lastName
        {
            get
            {
                return textBoxLastName.Text;
            }
        }

        public string newPassword
        {
            get
            {
                return textBoxNewPassword.Text;
            }
        }

        public string confirmPassword
        {
            get
            {
                return textBoxConfirmPassword.Text;            }
        }

        public bool modificationRight
        {
            get
            {
                if (checkBoxModositas.Checked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            errorProviderNewPassword.Clear();
            errorProviderUserName.Clear();
            try
            {
                if (!save)
                {
                    newUserPresenter.SaveNewUser();
                    save = true;
                    textBoxConfirmPassword.Enabled = false;
                    textBoxNewPassword.Enabled = false;
                    textBoxLastName.Enabled = false;
                    textBoxFirstName.Enabled = false;
                    textBoxUserName.Enabled = false;
                    checkBoxModositas.Enabled = false;
                }           
            }
            catch (UserNamePresenterException une)
            {
                errorProviderUserName.SetError(textBoxUserName, une.Message);
            }

            catch (newPasswordPresenterException npe)
            {
                errorProviderNewPassword.SetError(textBoxNewPassword, npe.Message);
            }
            catch (confirmPasswordPresenterException cpe)
            {
                errorProviderNewPassword.SetError(textBoxConfirmPassword, cpe.Message);
            }
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (!save)
            {
                DialogResult myResult;//Ha nincs elmentve rákérdez a bezárás elött
                myResult = MessageBox.Show("Elveti a módosításokat?", "Módosítások visszavonása", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (myResult == DialogResult.OK)
                {
                    this.Close();
                }

            }
            else
            {
                this.Close();
            }
        }
    }
}
