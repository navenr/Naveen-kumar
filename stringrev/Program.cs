using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringrev
{
    class sample
    {
        static void Main()
        {
            // original string
            string str = "GOPAL Perumal";
            // reverse the string
            string rev = string.Join(" ", str.Split(' ').Select(s => new String(s.Reverse().ToArray())));
            Console.WriteLine(rev);
        } 
    }
}
