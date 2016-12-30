using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace day6
{
    interface IDisposable
    { 
       void dispose();
    }

    public class disposeee : IDisposable
    {
        TextReader tr = null;
       public void dispose()
        {
            try
            {           
                tr = new StreamReader(@"C:\Users\Ritesh\Documents\matter.tx");

                string s = tr.ReadToEnd();

                Console.WriteLine(s);
            }
            catch (Exception ex)
            {
                Console.WriteLine("no file");
            }
            finally
            {
              
                if (tr != null)
                {
                    tr.Dispose();
                    Console.WriteLine("no file");

                }
            }
        }

        static void Main(string[] args)
        {
            disposeee d1 = new disposeee();
            d1.dispose();
           
        }
    }
}
