using CryptSharp;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzerszamgepKereskedelem.Models;
using SzerszamgepKereskedelem.Validations;
using SzerszamgepKereskedelem.ViewInterfaces;

namespace SzerszamgepKereskedelem.Presenters
{
    class NewUserPresenter
    {
        private szerszamgepContext db;
        private INewUserView newUserView;
        private felhasznalo _felhasznalo;
        private UserValidation userValidation;
        public NewUserPresenter(INewUserView param)
        {
            newUserView = param;
            
        }
        public void SaveNewUser()
        {
            db = new szerszamgepContext();
            try
            {
                int fId = db.felhasznalo.Select(f => f.Id).DefaultIfEmpty(0).Max() + 1;
                userValidation = new UserValidation(newUserView.userName, newUserView.newPassword, newUserView.confirmPassword);
                userValidation.userNameValidation();
                userValidation.newPasswordValidation();
                userValidation.confirmPasswordValidation();
                string encryptedPassword = Crypter.Blowfish.Crypt(newUserView.newPassword);//Titkosított jelszó létrehozása
                _felhasznalo = new felhasznalo(
                    fId, 
                    newUserView.userName,
                    newUserView.firstName,
                    newUserView.lastName,
                    encryptedPassword,
                    newUserView.modificationRight);
                db.felhasznalo.Add(_felhasznalo);
                db.SaveChanges();
            }
            catch (UserNameValidationException une)
            {
                throw new UserNamePresenterException(une.Message);
            }
            catch (newPasswordValidationException npe)
            {
                throw new newPasswordPresenterException(npe.Message);
            }
            catch (confirmPasswordValidationException cpe)
            {
                throw new confirmPasswordPresenterException(cpe.Message);
            }
            catch (DbUpdateException)
            {
                throw new UserNamePresenterException("A megadott felhasználónév már létezik!");
            }
        }
    }
}
