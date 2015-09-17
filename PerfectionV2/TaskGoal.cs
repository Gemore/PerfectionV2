using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectionV2
{
    /// <summary>
    /// A type of goal that has no children needed to be completed. Easiest to complete and worth the least experience.
    /// </summary>
    public class TaskGoal : Goal
    {
        /// <summary>
        /// Default constructor for TaskGoal. Sets values and takes in a name, description and category.
        /// </summary>
        /// <param name="name">String</param>
        /// <param name="desc">String</param>
        /// <param name="cate">Category</param>
        public TaskGoal(string name, string desc, GoalCategory cate)
            : base(name, desc, cate, 3)
        {
            ExpVal = 20;
        }

        /// <summary>
        /// A constructor for TaskGoal that takes in an int for estimated hours
        /// </summary>
        /// <param name="name">String</param>
        /// <param name="desc">String</param>
        /// <param name="cate">Category</param>
        /// <param name="estHours">Integer</param>
        public TaskGoal(string name, string desc, GoalCategory cate, int estHours)
            : base(name, desc, cate, estHours)
        {
            ExpVal = 20;
        }

        /// <summary>
        /// A override for the Complete method. Attempts to complete the goal and updates the exp if succesful. Returns a string explaining events.
        /// </summary>
        /// <param name="exp">Int</param>
        /// <returns>String</returns>
        public override string Complete(ref int exp)
        {
            if (!Completed)
            {
                exp = exp + ExpVal;
                Completed = true;
                return (Environment.NewLine + Name + " has now been completed! Success!");
            }
            else 
            {
                return (Environment.NewLine + Name + " has already been completed.");
            }
        }

        /// <summary>
        /// Override for the Save method, adding that this is a Task goal
        /// </summary>
        /// <param name="sw">StreamWriter</param>
        public override void Save(System.IO.StreamWriter sw)
        {
            sw.WriteLine("Task");
            base.Save(sw);
        }

        /// <summary>
        /// Override for the List method, returning a string that adds that this is a Task goal.
        /// </summary>
        /// <returns>string</returns>
        public override string List()
        {
            string result = Environment.NewLine + "Task";
            result += base.List();
            return result;
        }

    }
}
