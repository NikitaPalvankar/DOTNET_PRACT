using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Employee
{
    internal class Emp
    {
        public int EId { get; set; }
        public string EName { get; set; }
        public string Address { get; set; }

        public Emp()
        {
           EId = 0;
           EName = " ";
           Address = " ";
        }

        public Emp(int eid, string ename, string address)
        {
            EId= eid;
            EName = ename;
            Address = address;
        }

        public void Display()
        {
            Console.WriteLine($"Employee Id: {EId}");
            Console.WriteLine($"Employee Name: {EName}");
            Console.WriteLine($"Employee Address: {Address}");
        }
    }
}
