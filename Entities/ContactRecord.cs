using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entities
{
    public class ContactRecord
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobilePhoneNum { get; set; }
        public string HomePhoneNum { get; set; }
        public string BusinessPhoneNum { get; set; }
        public string Address { get; set; }
        public string Notes { get; set; }
        public Boolean Active { get; set; }

    }
}