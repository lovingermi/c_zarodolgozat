using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzerszamgepKereskedelem.Models;
using SzerszamgepKereskedelem.Services;
using SzerszamgepKereskedelem.Validations;
using SzerszamgepKereskedelem.ViewInterfaces;
using CryptSharp;
namespace SzerszamgepKereskedelem.Presenters
{
    class UserPresenter
    {
        private szerszamgepContext db;
        private IUserView userView;
        private felhasznalo _felhasznalo;
        private UserValidation userValidation;
        public UserPresenter(IUserView param)
        {
            userView = param;
            db = new szerszamgepContext();
        }
        public void userData(int fId)
        {
            _felhasznalo = db.felhasznalo.SingleOrDefault(f => f.Id == (fId));
            userView.userName = _felhasznalo.felhasznalonev;
            userView.firstName = _felhasznalo.vezeteknev;
            userView.lastName = _felhasznalo.keresztnev;
        }
        public void modifyUser() //validáció
        {

            try
            {
                if (_felhasznalo != null)
                {
                    userValidation = new UserValidation(userView.userName, userView.oldPassword, userView.newPassword, userView.confirmPassword, _felhasznalo.Id);
                    userValidation.userNameValidation();
                    userValidation.oldPasswordValidation();
                    userValidation.newPasswordValidation();
                    userValidation.confirmPasswordValidation();
                    _felhasznalo.felhasznalonev = userView.userName;
                    _felhasznalo.vezeteknev = userView.firstName;
                    _felhasznalo.keresztnev = userView.lastName;
                    _felhasznalo.jelszo = Crypter.Blowfish.Crypt(userView.newPassword);//Titkosított jelszó létrehozása
                    db.Entry(_felhasznalo).State = EntityState.Detached;
                    db.Entry(_felhasznalo).State = EntityState.Modified;
                    db.SaveChanges();
                }

            }
            catch (UserNameValidationException une)
            {
                throw new UserNamePresenterException(une.Message);
            }
            catch (UserOldPasswordValidationException uoe)
            {
                throw new UserOldPasswordPresenterException(uoe.Message);
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
        public void modifyUserWithoutPassword() //validáció csak felhasználónévre
        {

            try
            {
                if (_felhasznalo != null)
                {
                    userValidation = new UserValidation(userView.userName);
                    userValidation.userNameValidation();
                    _felhasznalo.felhasznalonev = userView.userName;
                    _felhasznalo.vezeteknev = userView.firstName;
                    _felhasznalo.keresztnev = userView.lastName;
                    db.Entry(_felhasznalo).State = EntityState.Detached;
                    db.Entry(_felhasznalo).State = EntityState.Modified;
                    db.SaveChanges();
                }

            }
            catch (UserNameValidationException une)
            {
                throw new UserNamePresenterException(une.Message);
            }
            catch (DbUpdateException)
            {
                throw new UserNamePresenterException("A megadott felhasználónév már létezik!");
            }
        }
       /* public void getOldData()//mégsem gomb megnyomásakor beolvassa az eredeti adatokat
        {
            userView.lastName = _felhasznalo.keresztnev;
            userView.firstName = _felhasznalo.vezeteknev;
            userView.userName = _felhasznalo.felhasznalonev;
        }*/
    }
}
