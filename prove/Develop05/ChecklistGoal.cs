using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eternal_Quest
{
    public class ChecklistGoal : CompletableGoal
    {

        private int _bonusAmount;
        private int _timesCompleted;
        private int _timesToComplete;
        
        public ChecklistGoal(string name, string description, int points, int timesToComplete, int bonusAmount) : base(name, description, points) 
        {
            _bonusAmount = bonusAmount;
            _timesCompleted = timesToComplete;
        }

        public ChecklistGoal(string savedString) : base(savedString) { }

        public override int RecordEvent()
        {
            _points = 0;
            return _points;
        }

        public override string ToSavedString()
        {
            return "";
        }

        public override string ToString()
        {
            return "";
        }

    }
}