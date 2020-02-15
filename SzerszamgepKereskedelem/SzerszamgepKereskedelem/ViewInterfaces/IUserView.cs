using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzerszamgepKereskedelem.ViewInterfaces
{
    interface IUserView
    {
        string userName { get; set; }
        string firstName { get; set; }
        string lastName { get; set; }
        string oldPassword { get; set; }
        string newPassword { get; set; }
        string confirmPassword { get; set; }
    }
}
