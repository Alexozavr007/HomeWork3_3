namespace HomeWork3_3_3 {
    internal class Vehicle {
        public float CoordinateLongitude { get; set; }
        public float CoordinateLatitude { get; set; }
        public float CoordinateAltitude { get; set; }
        public float Price { get; set;  }
        public int Speed { get; set;  }
        public int Year { get; set;  }

        public virtual void ShowDetails() {
            Console.WriteLine($"Lat: {CoordinateLatitude}");
            //..
        }
    }
}
