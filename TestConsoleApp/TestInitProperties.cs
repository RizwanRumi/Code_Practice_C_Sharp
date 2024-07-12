using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsoleApp;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Test Init Properties");

        Member memberObj = new Member() { Id = 1 };
        memberObj.Name = "Rizwan";
        memberObj.Address = "Chemnitz";

        Console.WriteLine(memberObj);

        Member memberObj2 = new Member() { Id = 2 };
        memberObj2.Name = "Rumi";
        memberObj2.Address = "Leipzig";

        Console.WriteLine(memberObj2);
    }
}

namespace TestConsoleApp
{
    public class Member
    {
        // init allows to set properties during the object initialization phase, but it prevents changes after the object has been constructed. (immutable properties) 
        public int Id { get; init; }
        public string Name { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $" ID: {Id} \n Name: {Name} \n Address: {Address}";
        }
    }
}
