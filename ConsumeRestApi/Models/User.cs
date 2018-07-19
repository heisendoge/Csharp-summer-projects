using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User
    {
        public User()
        {
            address = new Address();
            company = new Company();
        }
        public int  id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public Address address { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public Company company { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override string ToString()
        {
            String result = id.ToString()
                + "\n" + name
                + "\n" + username
                + "\n" + email
                + "\n" + address.ToString()
                + "\n" + phone
                + "\n" + website
                + "\n" + company.ToString();
            return result;
        }
    }
}
