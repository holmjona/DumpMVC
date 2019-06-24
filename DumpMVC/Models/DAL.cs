using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DumpMVC.Models {
    public static class DAL {
        private static List<User> _Users = new List<User>() {
            new User {UserName = "Bob", Password = "yes i am"}
            ,new User {UserName = "Harry", Password = "test"}
            ,new User {UserName = "Lisa", Password = "test"}
            ,new User {UserName = "Percival", Password = "test"}
            ,new User {UserName = "Bartholamew", Password = "test"}
            ,new User {UserName = "Nina", Password = "test"}
        };

        public static User Get(string uname,string pass) {
            return _Users.FirstOrDefault(u => u.UserName.ToLower() == uname.ToLower() 
                                        && u.Password == pass);
        }
    }
}