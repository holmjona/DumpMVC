using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DumpMVC.Models {
    public class User {
        private string _UserName;
        private string _Password;

        public string UserName {
            get { return _UserName; }
            set { _UserName = value; }
        }


        public string Password {
            get { return _Password; }
            set { _Password = value; }
        }

    }
}