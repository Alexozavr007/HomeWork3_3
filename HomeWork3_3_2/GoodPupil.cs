using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_3_2 {
    internal class GoodPupil:Pupil {
        public override void Read() {
            Console.WriteLine("I read good!");
        }

        public override void Write() {
            Console.WriteLine("I write good");
        }

        public override void Relax() {
            Console.WriteLine("I have time to relax");
        }

        public override void Study() {
            Console.WriteLine("I study when I have free time");
        }
    }
}
