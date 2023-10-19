using Robots;

Console.WriteLine("Hello, World!");

Robot robot = new Robot("C2PO", 0, 0);
Console.WriteLine(robot.AfficherPosition());

RobotMobile robotMobile = new RobotMobile("R2D2", 0, 0, 10);
Console.WriteLine(robotMobile.demarrer());
robotMobile.nettoyer();
robotMobile.Avancer(10, 10);
Console.WriteLine($"{robotMobile.Name} : Ma vitesse est de {robotMobile.CalculerDuréeDeDéplacement(20, 20)}.");
Console.WriteLine(robotMobile.AfficherPosition());
robotMobile.nettoyer();
Console.WriteLine(robotMobile.arreter());