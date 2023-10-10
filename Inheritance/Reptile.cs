using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public bool hasScales { get; set; }
        public bool isColdBlooded { get; set; }
        public int hasLungs { get; set; }
        public bool hasVertebrae { get; set; }
        public string type { get; set; }
        public Reptile() 
        {
            this.canMove = true;
            this.breathes = "Air";
            this.eats = "small animals, insects and eggs";
            this.hasScales = true;
            this.isColdBlooded = true;
            this.hasVertebrae = true;
            this.type = "Reptile";
        }
    }
}
