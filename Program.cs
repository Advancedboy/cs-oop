using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var doctor = new Doctor();
            doctor.FirstName = "Sergey";
            Console.WriteLine(doctor.FirstName);
            Console.WriteLine(doctor.Specialization);


            Person p = doctor;

            Console.WriteLine(p.FirstName);

            Doctor dd = (Doctor)p;

            Console.WriteLine(dd.Specialization);

        }
    }
}
