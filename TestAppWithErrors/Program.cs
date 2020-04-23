using System;
using System.Threading.Tasks;

namespace TestAppWithErrors
{
    class Program
    {
        static void Main(string[] args)
        { 
            int x = "abc";
        }

        public async Task<int> Test ()
        {
            return 1;
        }
    }
}
