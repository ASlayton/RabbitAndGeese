using RabbitAndGeese.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitAndGeese
{
    public class Rabbit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int MaxFeetPerSecond { get; set; }
        //Enum represented by integers by default
        public Size Earsize { get; set; }
        public Sex Sex {get; set; }
        public List<Goose> OwnedGeese { get; set; } = new List<Goose>();
        public List<Saddle> OwnedSaddles { get; set; } = new List<Saddle>();
    }
}
