using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1.Properties
{
    public class Encapsulation
    {
        private String empID;
        private String empName;
        private String empDesignation;

        public void setempID(String input)
        {
            empID = input;
        }
        public void setempName(String input)
        {
            empName = input;
        }
        public void setempDesignation(String input)
        {
            empDesignation = input;
        }
        public String getempID()
        {
            return empID;
        }
        public String getempName()
        {
            return empName;
        }
        public String getempDesignation()
        {
            return empDesignation;
        }
    }
}
