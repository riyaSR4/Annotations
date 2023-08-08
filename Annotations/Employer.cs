using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Annotations
{
    public class Employer
    {
        int id;
        string name;
        public Employer(int _id, string _name)
        {
            id = _id;
            name = _name;
        }
        [NewAttribute("Accessor", " Gives value of Employer Id")]
        public int GetId()
        {
            return id;
        }
        [NewAttribute("Accessor", " Gives value of Employer Name")]
        public string GetName()
        {
            return name;
        }
    }
    public class Employee
    {
        int id;
        string name;
        public Employee(int _id, string _name)
        {
            id = _id;
            name = _name;
        }
        [NewAttribute("1444", " 1444")]
        public int GetId()
        {
            return id;
        }
        [NewAttribute("Riya", " Riya Susan Reji")]
        public string GetName()
        {
            return name;
        }
    }
}

