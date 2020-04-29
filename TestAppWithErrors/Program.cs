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
            return ((1)+(2));
        }
    }

    class Person
    {
        private int test;

        //private string comment;
        
        private void Test1 ()
        {

        }

        public void Test2 ()
        {

        }
    }
}
