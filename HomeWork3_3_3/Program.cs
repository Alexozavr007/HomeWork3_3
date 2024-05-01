using HomeWork3_3_3;

var ship = new Ship();
ship.CoordinateLatitude = 21.4f;
ship.CoordinateLongitude = -45.2f;
ship.Speed = 123;
ship.Price = 100000;
ship.Port = "Odesa, UA";
ship.PassangersCount = 23;
Console.WriteLine("SHIP");
ship.ShowDetails();

var plane = new Plane();
plane.CoordinateLatitude = 30.4f;
plane.CoordinateLongitude = -32.3f;
plane.CoordinateAltitude = 20.4f;
plane.Speed = 400;
plane.Price = 3500000;
plane.PassangersCount = 45;
Console.WriteLine("\r\nPLANE");
plane.ShowDetails();

var car  = new Car();
//...
Console.WriteLine("\r\nCAR");
car.ShowDetails();