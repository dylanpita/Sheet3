using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entities;
using BLL;

namespace Sheet3.Models
{
    public class Model
    {
        private Business BLL = new Business();

        public List<ContactRecord> GetList()
        {
            return BLL.getRecords();
        }
        public ContactRecord Details(int id)
        {
            return BLL.Details(id);
        }
        public void AddRecord(ContactRecord cR)
        {
            BLL.AddRecord(cR);
        }
        public void Delete(ContactRecord cR)
        {
            BLL.Detele(cR);
        }
        public void Update(ContactRecord cR)
        {
            BLL.Update(cR);
        }

    }
}