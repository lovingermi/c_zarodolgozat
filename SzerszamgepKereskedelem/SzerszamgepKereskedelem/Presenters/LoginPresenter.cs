using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzerszamgepKereskedelem.Models;
using SzerszamgepKereskedelem.Properties;
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
                var user = db.felhasznalo.SingleOrDefault(x => x.felhasznalonev == view.UserName &&
                 x.jelszo == view.Password && x.modositas==true);

                if (user!=null)
                {
                    LoginSucces = true;
                }
                else
                {
                    view.ErrorMessage = Resources.LoginHiba;
                }
            }
        }
    }
}
