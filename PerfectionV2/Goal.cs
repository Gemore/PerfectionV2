using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectionV2
{
    /// <summary>
    /// A child of Identifiable, a goal has a category, an experience value, estimated hours to completed and can be completed.
    /// </summary>
    public abstract class Goal : Identifiable
    {
        private int _estHours, _expVal;
        private bool _completed;
        private GoalCategory _category;

        /// <summary>
        /// Constructor for a goal, takes in a name, description, category and estimated hours.
        /// </summary>
        /// <param name="name">Name of goal</param>
        /// <param name="desc">Description of goal</param>
        /// <param name="cate">Category of goal</param>
        /// <param name="estHours">Estimated hours to completion</param>
        public Goal(string name, string desc, GoalCategory cate, int estHours)
            : base(name, desc)
        {
            _category = cate;
            _estHours = estHours;
            _completed = false;
        }

        /// <summary>
        /// An abstract method that lets each child have its own implemntation. Returns a string explaining events, and may change the exp value.
        /// </summary>
        /// <param name="exp">Profile's exp</param>
        /// <returns>String explaining events</returns>
        public abstract string Complete(ref int exp);

        /// <summary>
        /// An override for the Save method (inherited from Identifiable). Writes the goal category, its completed state, its exp value and its estimated hours.
        /// </summary>
        /// <param name="sw">StreamWriter</param>
        public override void Save(System.IO.StreamWriter sw)
        {
            base.Save(sw);
            sw.WriteLine(_category);
            sw.WriteLine(_completed);
            sw.WriteLine(_expVal);
            sw.WriteLine(_estHours);
        }

        /// <summary>
        /// An override for the List method, adds the category and completed states to the list string.
        /// </summary>
        /// <returns>String with all important information about this object</returns>
        public override string List()
        {
            string result = base.List();
            result += Environment.NewLine + "Category: " + _category;
            result += Environment.NewLine + "Completed: " + _completed;
            return result; 
        }

        /// <summary>
        /// Gets or Sets the estimated hours.
        /// </summary>
        public int EstHours
        {
            get { return _estHours; }
            set { _estHours = value; }
        }

        /// <summary>
        /// Gets or Sets the experience value.
        /// </summary>
        public int ExpVal
        {
            get { return _expVal; }
            set { _expVal = value; }
        }

        /// <summary>
        /// Gets or Sets the completed status of this goal.
        /// </summary>
        public bool Completed
        {
            get { return _completed; }
            set { _completed = value; }
        }

        /// <summary>
        /// Gets or sets the Goal Category of this goal
        /// </summary>
        public GoalCategory Category
        {
            get { return _category; }
            set { _category = value; }
        }
    }
}
