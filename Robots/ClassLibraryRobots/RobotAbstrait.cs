using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public abstract class RobotAbstrait
    {
        public string Name { get; set; }

        protected RobotAbstrait(string name)
        {
            Name = name;
        }
        public abstract string demarrer();

        public string arreter()
        {
            return $"Robot {Name} arrêté";
        }
    }
}
