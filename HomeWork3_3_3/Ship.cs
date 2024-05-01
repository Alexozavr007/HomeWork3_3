namespace HomeWork3_3_3 {

    internal class Ship : Vehicle {
        public int PassangersCount { get; set; }
        public string Port { get; set; }

        public override void ShowDetails() {
            base.ShowDetails();
            Console.WriteLine($"Passangers: {PassangersCount}");
            Console.WriteLine($"Port: {Port}");
        }
    }

}