using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerComplainUserDefined
{
    class Customer
    {
        public string name;
        public string complain;
        public int serial;

        public Customer(int serial, string name, string complain)
        {
            this.serial = serial;
            this.name = name;
            this.complain = complain;
        }

        public int getSerial()
        {
            return serial;
        }

        public string getName()
        {
            return name;
        }

        public string getComplain()
        {
            return complain;
        }

        public void setSerial()
        {
            this.serial = serial;
        }

        public void setName()
        {
            this.name = name;
        }

        public void setComplain()
        {
            this.complain = complain;
        }

        
    }
}
