using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eternal_Quest
{
    public class SimpleGoal : CompletableGoal
    {
        public SimpleGoal(string name, string description, int points) : base(name, description, points) { }
    
        public SimpleGoal(string savedString) : base(savedString) { }

        public override int RecordEvent()
        {
            _points = 0;
            return _points;
        }
    }
}