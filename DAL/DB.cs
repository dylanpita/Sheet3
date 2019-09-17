using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public static class DB
    {
        public static int LastID = 3;

        public static List<ContactRecord> contactList = new List<ContactRecord>()
        {
            new ContactRecord() {ID = 1, FirstName = "Dylan", LastName = "Pita",
                                 MobilePhoneNum = "5148862243", HomePhoneNum = "4507483141",
                                 BusinessPhoneNum = "18002672001", Address = "1540 Bissonnet",
                                 Active = true},
            new ContactRecord() {ID = 2, FirstName = "Amin", LastName = "Meslioui",
                                 MobilePhoneNum = "5148888888", HomePhoneNum = "4508888888",
                                 BusinessPhoneNum = "18002672001", Address = "4150 rue Cac",
                                 Active = true},
            new ContactRecord() {ID = 3, FirstName = "Fred", LastName = "Desautels",
                                 MobilePhoneNum = "5149019001", HomePhoneNum = "4506666969",
                                 BusinessPhoneNum = "18002672001", Address = "1540 Bell Street",
                                 Active = true},
        };
    }
}
