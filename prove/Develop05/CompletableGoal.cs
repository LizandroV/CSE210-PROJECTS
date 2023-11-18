using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Eternal_Quest
{
    public class CompletableGoal : Goal
    {
        protected bool isCompleted = false;

        protected CompletableGoal(string name, string description, int points) : base (name, description, points) { }

        protected CompletableGoal(string savedString) : base(savedString) { }

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
