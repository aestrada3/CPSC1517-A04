using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp
{
    public class Class1
    {
        private string _StreetAddress2;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2
        {
            get
            {
                return _StreetAddress2;
            }
            set
            {
                _StreetAddress2 = string.IsNullOrEmpty(value) ? null : value;
            }

        }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string EmailAddress { get; set; }
        public Class1(string firstname, string lastname, string streetaddress1, string streetaddress2)
        {
            FirstName = firstname;
            LastName = lastname;
            StreetAddress1 = streetaddress1;
            StreetAddress2 = streetaddress2;
        }
    }
    }