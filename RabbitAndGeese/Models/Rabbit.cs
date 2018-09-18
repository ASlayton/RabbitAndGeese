using RabbitAndGeese.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitAndGeese
{
    public class Rabbit
    {
        public string Color { get; set; }
        public int MaxFeetPerSecond { get; set; }
        //Enum represented by integers by default
        public Earsize Earsize { get; set; }
        public Sex Sex {get; set; }
    }
}
