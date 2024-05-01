using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_3_2 {
    internal class ExcelentPupil : Pupil {
        public override void Read() {
            Console.WriteLine("I read very good!");
        }

        public override void Write() { 
            Console.WriteLine("I write very good");
        }

        public override void Relax() {
            Console.WriteLine("I have no time to relax");
        }

        public override void Study() {
            Console.WriteLine("I study all time");
        }
    }
}
