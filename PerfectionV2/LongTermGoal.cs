using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectionV2
{
    /// <summary>
    /// A type of goal that takes the most time to complete. Can have short term goal's that are needed to be completed.
    /// </summary>
    public class LongTermGoal : Goal
    {
        private List<ShortTermGoal> _reqShort;

        /// <summary>
        /// Default constructor for long term goal. takes in a name, description, a category and a list of short term goals
        /// </summary>
        /// <param name="name">String</param>
        /// <param name="desc">String </param>
        /// <param name="category">GoalCategory</param>
        /// <param name="reqShort">List of Short term Goals</param>
        public LongTermGoal(string name, string desc, GoalCategory category, List<ShortTermGoal> reqShort)
            : base(name, desc, category, 50)
        {
            _reqShort = reqShort;
            ExpVal = 1000;
        }

        /// <summary>
        /// A constructor for long term goal that also takes in an estimated hours for the completion of the goal
        /// </summary>
        /// <param name="name">String</param>
        /// <param name="desc">String </param>
        /// <param name="category">GoalCategory</param>
        /// <param name="reqShort">List of Short term Goals</param>
        /// <param name="estHours">Int</param>
        public LongTermGoal(string name, string desc, GoalCategory category, List<ShortTermGoal> reqShort, int estHours)
            :base (name, desc, category, estHours)
        {
            _reqShort = reqShort;
            ExpVal = 1000;
        }

        /// <summary>
        /// Attempts to complete this goal, returns a string explaining the events and updates the exp if succesful
        /// </summary>
        /// <param name="exp">User Exp Int</param>
        /// <returns></returns>
        public override string Complete(ref int exp)
        {
            bool allDone = true;
            string result = "";

            if (!Completed)
            {
                foreach (ShortTermGoal s in _reqShort)
                {
                    if (s.Completed == false)
                    {
                        allDone = false;
                        break;
                    }
                }

                if (allDone)
                {
                    result = (Environment.NewLine + Name + " has been completed! Fantastic!");
                    Completed = true;
                    exp = exp + ExpVal;
                }
                else
                {
                    result = Environment.NewLine + Name + " cannot be completed as there are unfinished Short-Term goals.";
                }
            }
            else
            {
                result = Environment.NewLine + Name + " has already been completed";
            }

            return result;
        }

        /// <summary>
        /// Overrides the save method, making it save the name of every attached short term goal
        /// </summary>
        /// <param name="sw">StreamWriter</param>
        public override void Save(System.IO.StreamWriter sw)
        {
            sw.WriteLine("LongTerm");
            base.Save(sw);
            sw.WriteLine(_reqShort.Count);
            foreach (ShortTermGoal s in _reqShort)
            {
                sw.WriteLine(s.Name);
            }
        }

        /// <summary>
        /// Returns the required short term goals for this goal
        /// </summary>
        public List<ShortTermGoal> ReqShort
        {
            get { return _reqShort; }
        }

        /// <summary>
        /// Overrides the List method adding the line that describes this as a long term goal
        /// </summary>
        /// <returns></returns>
        public override string List()
        {
            string result = Environment.NewLine + "Long-Term Goal";
            result += base.List();
            return result;
        }
    }
}
