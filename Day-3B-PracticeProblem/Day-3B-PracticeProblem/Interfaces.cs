using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3B_PracticeProblem
{
    public interface Interfaces
    {
        void Novels();
    }
    class Two : Interfaces
    {
        public void Novels()
        {
            Console.WriteLine("Two States Novel By Chetan Bhagat");
        }
    }
}

