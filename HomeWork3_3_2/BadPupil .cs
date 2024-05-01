using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_3_2 {
    internal class BadPupil:Pupil {
        public override void Read() {
            Console.WriteLine("I cant read");
        }

        public override void Write() {
            Console.WriteLine("I cant write");
        }

        public override void Relax() {
            Console.WriteLine("I relax all time");
        }

        public override void Study() {
            Console.WriteLine("I dont study");
        }
    }
}
