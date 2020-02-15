using CryptSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzerszamgepKereskedelem.Models;
using SzerszamgepKereskedelem.Properties;
using SzerszamgepKereskedelem.Services;
using SzerszamgepKereskedelem.ViewInterfaces;

namespace SzerszamgepKereskedelem.Presenters
{
    class LoginPresenter
    {
        private ILoginView view;
        private szerszamgepContext db = new szerszamgepContext();
        public bool LoginSucces;
        public LoginPresenter(ILoginView param)
        {
            view = param;
        }
        private bool ConnectionExist()
        {
            return db.Database.Exists();
        }
        public void Authenticate()
        {
            if (!ConnectionExist())
            {
                view.ErrorMessage = Resources.AdatHiba;
            }
            else
            {
                /*var user = db.felhasznalo.SingleOrDefault(x => x.felhasznalonev == view.UserName &&
                 x.jelszo == view.Password && x.modositas==true);*/
                var user = db.felhasznalo.SingleOrDefault(x => x.felhasznalonev == view.UserName);
                if (user!=null)
                {
                    //----------
                    //var salt = user.felhasznalonev;//ha simán sikerül próba salt 
                    //var hash = Hash.GetMD5(view.Password);//(view.Password + salt);
                    bool matchesPwd =Crypter.CheckPassword(view.Password, user.jelszo);
                    var hUser = db.
                        felhasznalo.SingleOrDefault(x =>
                        x.felhasznalonev == view.UserName &&
                           matchesPwd);//&& matchesPwd);//hashx.jelszo.Equals(hash)
                    if (hUser != null) 
                    
                    {
                        LoginSucces = true;
                        view.bejelentkezettFelhasznalo = user.vezeteknev + " " + user.keresztnev;//Bejelentkezett felhasználó megjelenítése a main formon 
                        view.felhasznaloJogosultsag = user.modositas;
                        view.UserId = user.Id;
                    }
                    else
                    {
                        view.ErrorMessage = Resources.LoginHiba;
                    }            
                }
                else
                {
                    view.ErrorMessage = Resources.UserHiba;
                }
            }
        }
    }
}
