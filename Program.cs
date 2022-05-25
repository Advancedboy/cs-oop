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
            Person p = new Person();
            p.FirstName = "Pavel";

            Person p2 = new Person();
            p.FirstName = "Anastasia";

            var doctor = new Doctor();
            doctor.FirstName = "Alex";
            doctor.years = 10;
            doctor.m();

            var doctortrainee = new Doctor_trainee();
            doctortrainee.years = 1;
            doctortrainee.FirstName = "Denis";

            Console.WriteLine(doctortrainee.premium());

        }
    }
}
