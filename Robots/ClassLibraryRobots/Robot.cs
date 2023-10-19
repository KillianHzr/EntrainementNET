namespace Robots
{
    public class Robot : RobotAbstrait, IRobotNettoyage
    {

        protected int _PositionX { get; set; }
        protected int _PositionY { get; set; }


        public Robot(string name, int posX, int posY) : base(name)
        {
            Name = name;
            _PositionX = posX;
            _PositionY = posY;
        }

        public virtual string AfficherPosition()
        {
            return $"{Name} : Je suis à la position {_PositionX}, {_PositionY}";
        }

        public void Avancer(int PosX, int PosY)
        {
            _PositionX += PosX;
            _PositionY += PosY;
        }

        public override string demarrer()
        {
            return $"Robot {Name} démarré";
        }

        public void nettoyer()
        {
            Console.WriteLine($"{Name} : Je nettoie le sol maître.");
        }

    }


}