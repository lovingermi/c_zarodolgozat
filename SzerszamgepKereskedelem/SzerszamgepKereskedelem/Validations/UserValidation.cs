using CryptSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzerszamgepKereskedelem.Models;

namespace SzerszamgepKereskedelem.Validations
{
    class UserValidation
    {
        private string UserName;
        private string OldPassword;
        private string NewPassword;
        private string ConfirmPassword;
        private int fId;
        private szerszamgepContext db;
        private felhasznalo _felhasznalo;
        public UserValidation(string userName, string oldPassword, string newPassword, string confirmPassword, int id)
        {
            this.UserName = userName;
            this.OldPassword = oldPassword;
            this.NewPassword = newPassword;
            this.ConfirmPassword = confirmPassword;
            this.fId = id;
            db = new szerszamgepContext();
            _felhasznalo = db.felhasznalo.SingleOrDefault(f => f.Id == (fId));
        }
        public UserValidation(string userName)
        {
            this.UserName = userName;
        }
        public void userNameValidation()
        {

            if (userNameIsempty())
            {
                throw new UserNameValidationException("A felhasználónév mező nem lehet üres!");
            }
        }
        public void oldPasswordValidation()
        {
            if (oldPasswordIsFalse())
            {
                throw new UserOldPasswordValidationException("A régi jelszó nem megfelelő!");
            }
        }
        public void confirmPasswordValidation()
        {
            if (confirmPasswordIsFalse())
            {
                throw new confirmPasswordValidationException("A két jelszó nem egyezik!");
            }
        }
        public void newPasswordValidation()
        {
            if (newPasswordIsFalse())
            {
                throw new newPasswordValidationException("A jelszónak legalább 8 karaker hószúnak kell lennie!");
            }
        }
        private bool userNameIsempty()
        {
            if (UserName == string.Empty) //Nem lett kitöltve a user mező
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool oldPasswordIsFalse()
        {
            bool matchesPwd = Crypter.CheckPassword(OldPassword, _felhasznalo.jelszo);//jelszó összehasonlítása a titkosított jelszóval
            if (!matchesPwd) //Nem lett kitöltve a user mező
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool newPasswordIsFalse()
        {
            if (NewPassword.Length<8 || String.IsNullOrWhiteSpace(NewPassword))//Rövid a jelszó vagy üres
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool confirmPasswordIsFalse()
        {
            if (!NewPassword.Equals(ConfirmPassword))//Két jelszó nem egyezik
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
