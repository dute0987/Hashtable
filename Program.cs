using System;

namespace HashTableProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to the Hashtable programs");

            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "be");
            hash.Add("1", "u");
            hash.Add("2", "nick");
            hash.Add("3", "stay");
            hash.Add("4", "u");
            hash.Add("5", "nick");

            Console.WriteLine(hash.GetV("5"));
            Console.WriteLine(hash.GetV("0"));
            Console.ReadLine();
        }
    }
}
