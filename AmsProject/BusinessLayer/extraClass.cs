using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
  public class extraClass
    {
        public static string autogenId() {

            hasten_AMSEntities db = new hasten_AMSEntities();

           
          

            string mystring = "34234234d124";
            string res = mystring.Substring(mystring.Length - 3);
            return res;

        }
        
    }
}
