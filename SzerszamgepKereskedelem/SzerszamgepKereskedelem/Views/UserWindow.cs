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

namespace SzerszamgepKereskedelem
{
    public partial class UserWindow : Form ,IUserView
    {
        private UserPresenter userPresenter;
        private bool modify = false;
        public UserWindow( int userId)
        {
            userPresenter = new UserPresenter(this);
            InitializeComponent();
            userPresenter.userData(userId);
            this.MaximizeBox = false;
        }

        public string userName
        {
            get
            {
                return textBoxUserName.Text;
            }
            set
            {
                textBoxUserName.Text = value;
            }
        }
        public string firstName
        {
            get
            {
                return textBoxFirstName.Text;
            }
            set
            {
                textBoxFirstName.Text = value;
            }
        }
        public string lastName
        {
            get
            {
                return textBoxLastName.Text;
            }
            set
            {
                textBoxLastName.Text = value;
            }
        }

        public string oldPassword
        {
            get
            {
                return textBoxOldPassword.Text;
            }
            set
            {
                textBoxOldPassword.Text = value;
            }
        }
            
        public string newPassword
        {
            get
            {
                return textBoxNewPassword.Text;
            }
            set
            {
                textBoxNewPassword.Text = value;
            }
        }
        public string confirmPassword
        {
            get
            {
                return textBoxConfirmPassword.Text;
            }
            set
            {
                textBoxConfirmPassword.Text = value;
            }
        }

        private void buttonModifyUser_Click(object sender, EventArgs e)
        {
            textBoxFirstName.ReadOnly = false;
            textBoxLastName.ReadOnly = false;
            textBoxUserName.ReadOnly = false;
            checkBoxPassword.Enabled = true;
            modify = true;
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPassword.Checked)
            {
                textBoxOldPassword.ReadOnly = false;
                textBoxNewPassword.ReadOnly = false;
                textBoxConfirmPassword.ReadOnly = false;
            }
            else
            {
                textBoxOldPassword.ReadOnly = true;
                textBoxNewPassword.ReadOnly = true;
                textBoxConfirmPassword.ReadOnly = true;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxPassword.Checked&& modify)
                {
                    userPresenter.modifyUser();
                    textBoxAndErrorProviderClear();
                }
                else
                if(modify)
                {
                    userPresenter.modifyUserWithoutPassword();
                    textBoxAndErrorProviderClear();
                }
                modify = false;
            }
            catch (UserNamePresenterException une)
            {
                errorProviderUserName.SetError(textBoxUserName, une.Message);
            }
            catch (UserOldPasswordPresenterException uoe)
            {
                errorProviderOldPassword.SetError(textBoxOldPassword, uoe.Message);
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
        public void textBoxAndErrorProviderClear()
        {
            errorProviderOldPassword.Clear();
            errorProviderUserName.Clear();
            errorProviderNewPassword.Clear();
            textBoxFirstName.ReadOnly = true;
            textBoxLastName.ReadOnly = true;
            textBoxUserName.ReadOnly = true;
            checkBoxPassword.Enabled = false;
            checkBoxPassword.Checked = false;
            textBoxOldPassword.ReadOnly = true;
            textBoxNewPassword.ReadOnly = true;
            textBoxConfirmPassword.ReadOnly = true;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (modify)
            {
                DialogResult myResult;//Ha módosítás van rákérdez a bezárás elött
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
