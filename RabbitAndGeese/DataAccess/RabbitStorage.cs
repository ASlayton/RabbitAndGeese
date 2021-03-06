﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RabbitAndGeese.Models;

namespace RabbitAndGeese.DataAccess
{
    public class RabbitStorage
    {
        static List<Rabbit> _hutch = new List<Rabbit>();

        public void Add(Rabbit rabbit)
        {
            //Are there any rabbits in the hutch? If yes, give it an id incremented by 1, otherwise, the id is 1
            rabbit.Id = _hutch.Any() ? _hutch.Max(r => r.Id) + 1 : 1;
            _hutch.Add(rabbit);
        }

        public Rabbit GetById(int id)
        {
            return _hutch.FirstOrDefault(rabbit => rabbit.Id == id);
        }
    }
}
