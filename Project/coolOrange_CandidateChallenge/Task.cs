using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace coolOrange_CandidateChallenge
{
    internal class Task : IPriority, IComplexity, IComparable
    {
        Priority priority;
        string name;
        int complexity;

        public enum Priority
        {
            MIN_PRIORITY=1, 
            MED_PRIORITY=5, 
            MAX_PRIORITY=10
        }

        public Task(string name)
        {
            this.name = name;
            this.priority = Priority.MED_PRIORITY;
        }

        public void SetComplexity(int value)
        {
            if (value >= 0) {
            this.complexity = value;
            }
        }

        public int GetComplexity()
        {
            return (this.complexity);
        }

        public int CompareTo(object obj)
        {
            if(!(obj.GetType() == typeof(Task))) 
            {
                throw new ArgumentException("Not type of Task");
            }
            return this.priority - ((Task)obj).priority;
            
        }

        public void SetPriority(Priority priority)
        {
            this.priority = priority;
        }

        public Priority GetPriority()
        {
            return this.priority;
        }
        public string GetName()
        {
            return this.name;
        }

        
    }
}
