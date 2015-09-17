using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectionV2
{
    /// <summary>
    /// A type of goal that is of medium difficulty and has a medium exp reward. Inherits from Goal
    /// </summary>
    public class ShortTermGoal : Goal
    {
        List<TaskGoal> _reqTasks;

        /// <summary>
        /// Default constructor for a short term goal. Sets values and takes in a name, description, category and a list of required tasks
        /// </summary>
        /// <param name="name">String</param>
        /// <param name="desc">String</param>
        /// <param name="category">GoalCategory</param>
        /// <param name="reqTasks">List of required Task Goals</param>
        public ShortTermGoal(string name, string desc, GoalCategory category, List<TaskGoal> reqTasks)
            : base(name, desc, category, 10)
        {
            _reqTasks = reqTasks;
            ExpVal = 100;
        }


        /// <summary>
        /// A constructor for a short term goal. Sets values and takes in a name, description, category and a list of required tasks. Also takes in an int for estimated hours.
        /// </summary>
        /// <param name="name">String</param>
        /// <param name="desc">String</param>
        /// <param name="category">GoalCategory</param>
        /// <param name="reqTasks">List of required Task Goals</param>
        /// <param name="estTime">Integer</param>
        public ShortTermGoal(string name, string desc, GoalCategory category, List<TaskGoal> reqTasks, int estTime)
            : base(name, desc, category, estTime)
        {
            _reqTasks = reqTasks;
            ExpVal = 100;
        }

        /// <summary>
        /// Override of the Complete method. Checks that all required tasks have been completed, and then attempts to complete itself,
        /// updating the exp and returning a string explaining the events
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public override string Complete(ref int exp)
        {
            bool allDone = true;
            string result = "";

            if (!Completed)
            {
                foreach (TaskGoal t in _reqTasks)
                {
                    if (t.Completed == false)
                    {
                        allDone = false;
                        break;
                    }
                }

                if (allDone)
                {
                    result = (Environment.NewLine + Name + " has now been completed! Well Done");
                    Completed = true;
                    exp = exp + ExpVal;
                }
                else
                {
                    result = (Environment.NewLine + Name + " cannot be completed as there are unfinished Tasks");
                }
            }
            else 
            {
                result = (Environment.NewLine + Name + " has already been completed");
            }

            return result;
        }

        /// <summary>
        /// Overrides the Save method, saving the goal type and the name of each required task
        /// </summary>
        /// <param name="sw">StreanWriter</param>
        public override void Save(System.IO.StreamWriter sw)
        {
            sw.WriteLine("ShortTerm");
            base.Save(sw);
            sw.WriteLine(_reqTasks.Count);
            foreach (TaskGoal t in _reqTasks)
            {
                sw.WriteLine(t.Name);
            }
        }

        /// <summary>
        /// Override for the List Method, adding a line to explain this is a short term goal.
        /// </summary>
        /// <returns></returns>
        public override string List()
        {
            string result = Environment.NewLine + "Short-Term Goal";
            result += base.List();
            return result;
        }

        /// <summary>
        /// Gives read-only acces to the required tasks of this goal
        /// </summary>
        public List<TaskGoal> ReqTasks
        {
            get { return _reqTasks; }
        }
    }
}
