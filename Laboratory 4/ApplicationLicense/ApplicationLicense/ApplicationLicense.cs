using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLicense
{
    internal class ApplicationLicense
    {
        public void AllowTrial()
        {
            Console.WriteLine("You have chosen Trial version");
        }

        public void AllowCommon()
        {
            Console.WriteLine("You have chosen the Free version");
        }

        public void AllowPro()
        {
            Console.WriteLine("You have chosen the Professional version");
        }
    }
}
