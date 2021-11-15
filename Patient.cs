using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDNA
{
    public class Patient
    {
        
        private string username = "";
        private string userFirstname = "";
        private string userLastname = "";
        private int userAge = 0;
        private string userAdress = "";

        public Patient(string username, string userFirstname, string userLastname, int userAge, string userAddress)
        {

        }

        public string getUsername()
        {
            return username;
        }
        public void setUsername(string UserName)
        {
            UserName = username;
        }
       
        public string getFirstName()
        {
            return userFirstname;
        }
        public void setFirstName(string FirstName)
        {
            FirstName = userFirstname;
        }

        public string getLastName()
        {
            return userLastname;
        }
        public void setLastName(string LastName)
        {
            LastName = userLastname;
        }

        public int getAge()
        {
            return userAge;
        }
        public void setAge(int Age)
        {
            Age = userAge;
        }

        public string getAdress()
        {
            return userAdress;
        }
        public void setAdress(string Adress)
        {
            Adress = userAdress;
        }
    }
}
