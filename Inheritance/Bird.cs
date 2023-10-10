using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public bool hasFeathers { get; set; }
        public bool hasBeak {  get; set; }
        public bool hasWings { get; set; }
        public int numberOfWings { get; set; }
        public string type { get; set; }
        public Bird() 
        {
            this.numberOfLegs = 2;
            this.canMove = true;
            this.breathes = "air";
            this.eats = "insects, nuts, fruit, small animals, and berries";
            this.hasFeathers = true;
            this.hasBeak = true;
            this.hasWings = true;
            this.numberOfWings = 2;
            this.type = "Bird";
        }
    }
}
