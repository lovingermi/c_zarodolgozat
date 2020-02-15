using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzerszamgepKereskedelem.ViewInterfaces
{
    interface INewUserView
    {
        string userName { get;  }
        string firstName { get;  }
        string lastName { get;  }
        string newPassword { get;  }
        string confirmPassword { get; }
        bool modificationRight { get; }
    }
}
