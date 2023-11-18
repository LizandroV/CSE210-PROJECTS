using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eternal_Quest
{
    public class Goal
    {
        protected string _name = "";
        protected string _description = "";
        protected int _points = 0;

        private List<string> Goals = new List<string>();

        public Goal(string name, string description, int points)
        {
            _name = name;
            _description = description;
            _points = points;

            Goals.Add($"{_name},{_description},{_points}");
        }

        public Goal(string savedString)
        {
            _name = savedString;
        }

        public virtual int RecordEvent()
        {
            _points = 0;
            return _points;
        }

        public virtual string ToSavedString()
        {
            _name = "";
            return _name;
        }

        public override string ToString()
        {
            _name = "";
            return _name;
        }
    }
}