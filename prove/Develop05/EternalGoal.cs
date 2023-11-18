using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eternal_Quest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points):base(name, description, points) { }

        public EternalGoal(string savedString) : base(savedString) { }
    }
}