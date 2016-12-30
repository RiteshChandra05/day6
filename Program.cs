using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constuctor
{
    class Program
    {
        string xyz;
        string abc;

        public Program(string XYZ, string ABC)
        {
            this.xyz = XYZ;
            this.abc = ABC;
            
        }
        public void print()
        {
            Console.WriteLine(this.xyz + " " + this.abc);
        }
        static void Main(string[] args)
        {
            Program p1 = new Program("ritesh", "chandra");
            p1.print();


        }
    }
}
