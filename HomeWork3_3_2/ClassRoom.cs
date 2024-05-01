using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_3_2 {
    internal class ClassRoom {

        public Pupil[] Pupils { get; private set; }

        public ClassRoom(Pupil pl1, Pupil pl2, Pupil pl3, Pupil pl4) {
            Pupils = new Pupil[] { pl1, pl2, pl3, pl4 };
        }

        public ClassRoom(Pupil pl1, Pupil pl2, Pupil pl3) {
            Pupils = new Pupil[] { pl1, pl2, pl3};
        }

        public ClassRoom(Pupil pl1, Pupil pl2) {
            Pupils = new Pupil[] { pl1, pl2};
        }

        internal void DisplayPupils() {
            for (int i = 0; i < Pupils.Length; i++) {
                Console.WriteLine($"Pupil #{i + 1}");
                var pl = Pupils[i];
                pl.Study();
                pl.Write();
                pl.Relax();
                pl.Read();
            }
        }
    }
}
