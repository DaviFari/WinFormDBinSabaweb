using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibraryDB
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        DBSMARTASPMyDBWPFEntities db = new DBSMARTASPMyDBWPFEntities();
        userInfo usinfo = new userInfo();

        public void usrinsert(string usname, string uspass)
        {
            usinfo.UsrName = usname;
            usinfo.UsrPassword = uspass;
            db.userInfoes.Add(usinfo);
            db.SaveChanges();
        }
        public void insert(string usrname, string usrpass, string country)
        {
            usinfo.UsrName = usrname;
            usinfo.UsrPassword = usrpass;
            usinfo.Country = country;
            db.userInfoes.Add(usinfo);
            db.SaveChanges();
        }

        public void insert(string usrname, string usrpass, string country, string city)
        {
            usinfo.UsrName = usrname;
            usinfo.UsrPassword = usrpass;
            usinfo.City = city;
            usinfo.Country = country;
            db.userInfoes.Add(usinfo);
            db.SaveChanges();
        }

        public void insert(string usrname, string usrpass, string country, string city, string phone)
        {
            usinfo.UsrName = usrname;
            usinfo.UsrPassword = usrpass;
            usinfo.City = city;
            usinfo.Country = country;
            usinfo.Phone = phone;
            db.userInfoes.Add(usinfo);
            db.SaveChanges();
        }

        public void insert(string usrname, string usrpass, string country, string city, string phone, string email)
        {
            usinfo.UsrName = usrname;
            usinfo.UsrPassword = usrpass;
            usinfo.City = city;
            usinfo.Country = country;
            usinfo.Phone = phone;
            usinfo.Email = email;
            db.userInfoes.Add(usinfo);
            db.SaveChanges();
        }

        public userInfo viewOne(string password)
        {
            return db.userInfoes.Single(p => p.UsrName == password);
        }

        public List<userInfo> viewAll()
        {
            return db.userInfoes.ToList();
        }
    }
}
