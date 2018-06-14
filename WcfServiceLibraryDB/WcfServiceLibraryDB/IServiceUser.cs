using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibraryDB
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceUser" in both code and config file together.
    [ServiceContract]
    public interface IServiceUser
    {
        [OperationContract]
        void usrinsert(string usname, string uspass);
        [OperationContract]
        void insert(string usrname, string usrpass, string country);
        [OperationContract]
        void insert(string usrname, string usrpass, string country, string city);
        [OperationContract]
        void insert(string usrname, string usrpass, string country, string city, string phone);
        [OperationContract]
        void insert(string usrname, string usrpass, string country, string city, string phone, string email);
        // TODO: Add your service operations here
        //[OperationContract]
        //userInfo viewOne(string password);
        //[OperationContract]
        //List<userInfo> viewAll();

    }
}
