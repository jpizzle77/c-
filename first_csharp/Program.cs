using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace first_csharp
{
    class Program
    {

        static void Main(string[] args)
       {

           //string x = "my \"so called\" life";
           //string x ="what if i need \t a new line";
           //string x = string.Format("{0}!", "Bonzai");
           //string x = string.Format("Make: {0} \nModel: {1}\nCountry: {2}", "BMW", "760I", "Germany");
          // string x = string.Format("{0:C}", 123.45); //formats for $ and cents
           // string x = string.Format("{0:N}", 123456789); // adds commas
           //string x = string.Format("{0:P}", .0234);  //gives percentage %
          /* StringBuilder x = new StringBuilder();
           for (int i = 0; i < 100; i++)
           {
             x.Append("--")  ;
             x.Append(i);
           }*/

           string x = "  Mooma knock you out   "; // 2 opeong whitespaces, and 3 ending whitespaces
           //x = x.Substring(3,7); //slices from index 3 to 7
           //x = x.ToUpper(); //repalces with all uppercase letters
           //x= x.Replace("knock", "slap"); //replaces the words
           x = String.Format("Length before: {0} -- After: {1}", x.Length, x.Trim().Length);// trims off any beginning or ending whitespaces
           
           
            Console.WriteLine(x);
        }
        
    }
}
