using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BLL
{
    public class Business
    {
        public List<ContactRecord> getRecords()
        {
            return DB.contactList;
        }
        public ContactRecord Details(int id)
        {
            return DB.contactList.Where(x => x.ID == id).Single();
        }
        public void Update(ContactRecord cR)
        {
            DB.contactList[DB.contactList.FindIndex(x => x.ID == cR.ID)] = cR;
        }
        public void Detele(ContactRecord cR)
        {
            DB.contactList[DB.contactList.FindIndex(x => x.ID == cR.ID)].Active = false;
        }
        public void AddRecord(ContactRecord cR)
        {
            cR.ID = DB.LastID++;
            DB.contactList.Add(cR);
        }
    }
}
