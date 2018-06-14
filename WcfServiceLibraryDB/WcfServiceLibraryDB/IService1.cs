using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServiceLibraryDB;
using System.Data.Entity;

namespace WcfServiceLibraryDB
{

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
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
        [OperationContract]
        userInfo viewOne(string password);
        [OperationContract]
        List<userInfo> viewAll();

    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
}
