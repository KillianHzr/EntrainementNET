using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Robots
{
    public class RobotMobile : Robot
    {
        int Vitesse { get; set; }

        public RobotMobile(string name, int posX, int posY, int vitesse) : base(name, posY, posX)
        {
            Vitesse = vitesse;
        }

        public int CalculerDistance(int posX, int posY)
        {
            return Math.Abs(posX - _PositionX) + Math.Abs(posY - _PositionY); ;
        }

        public int CalculerDuréeDeDéplacement(int posX, int posY)
        {
            return CalculerDistance(posX, posY) / Vitesse; ;
        }

        public override string AfficherPosition()
        {
            return $"{Name} : Je suis un robot mobile à la position {_PositionX}, {_PositionY}";
        }
    }
}
