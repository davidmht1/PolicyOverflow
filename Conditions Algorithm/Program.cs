using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions_Algorithm
{
    internal class Program
    {
        int policy;
        int overflow;

        public Program(int p, int o) 
        {
            this.policy = p;
            this.overflow = o;
        }
        static void Main(string[] args)
        {
            int overflow1 = 0;
            int overflow2 = 0;
            int policy2 = 0;

            Program p1 = new Program(16, 15);
            Program p2 = new Program(12, -1);
            Program p3 = new Program(15, 12);
            Program selectedPolicy = p2;

            Program[] list = { p1, p2, p3 };

            
            if(selectedPolicy.overflow == -1)
            {
                Console.WriteLine("added policy: " + selectedPolicy.policy);
            }
            else if(selectedPolicy.overflow != -1)
            {
                Console.WriteLine("added policy: " + selectedPolicy.policy);

                overflow1 = selectedPolicy.overflow;
                
                foreach(Program p in list)
                {
                    if(overflow1 == p.policy)
                    {
 
                        overflow2 = p.overflow;
                        policy2 = p.policy;
                    }
                }
            }
            if(overflow2 == -1)
            {
                Console.WriteLine("added policy: " + policy2);

            }
            else if(selectedPolicy.overflow != -1)
            {
                Console.WriteLine("added policy: " + policy2);
                foreach (Program k in list)
                {
                    if (overflow2 == k.policy)
                    {
                        Console.WriteLine("added policy:" + k.policy);
                    }
                }
            }
            

            

        }
    }
}
