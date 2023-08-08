using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Annotations
{
    public class NewAttribute : Attribute
    {
        private string title;
        private string description;
        public NewAttribute(string t, string d)
        {
            title = t;
            description = d;
        }
        public static void AttributeDisplay(Type classType)
        {
            Console.WriteLine("Method of class " + classType.Name);
            MethodInfo[] info = classType.GetMethods();
            for(int i = 0; i < info.Length; i++)
            {
                object[] attributes = info[i].GetCustomAttributes(true);
                foreach(var data in attributes)
                {
                    if(data is NewAttribute) 
                    {
                        NewAttribute attributeObject = (NewAttribute)data;
                        Console.WriteLine("{0} - {1},{2}", info[i].Name,
                        attributeObject.title,attributeObject.description);
                    }
                }
            }
        }
    }
}
