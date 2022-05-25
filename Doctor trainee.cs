using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Doctor_trainee : Doctor
    {
        public string universityName = "Minsk Medical University";
        public float premium()
        {
            return Money * 1.5f;
        }
    }
}
