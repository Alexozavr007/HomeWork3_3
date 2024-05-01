namespace HomeWork3_3_3 {

    internal class Plane : Vehicle {
        public int PassangersCount { get; set; }

        public override void ShowDetails() {
            base.ShowDetails();
            Console.WriteLine($"Passangers: {PassangersCount}");
        }
    }

}
