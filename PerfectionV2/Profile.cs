using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectionV2
{
    /// <summary>
    /// The profile class. Inherits from identifiable and stores exp and a list of goals. Can earn exp and level up.
    /// </summary>
    public class Profile : Identifiable
    {
        private const int DIFFICULTY = 50;
        private const int MAX_LEVEL = 100;

        private List<Goal> _goals;
        private int _level, _exp, _expReq;

        /// <summary>
        /// Constructor for Profile. Takes in a name and description, sets default values.
        /// </summary>
        /// <param name="name">String</param>
        /// <param name="desc">String</param>
        public Profile(string name, string desc)
            : base(name, desc)
        {
            _goals = new List<Goal>();
            _level = 0;
            _exp = 0;
            _expReq = 100;
        }

        /// <summary>
        /// Adds a goal and all its children to this profile. If a child goal is already part of the profile, it is not added.
        /// </summary>
        /// <param name="toAdd">Goal</param>
        public void AddGoal(Goal toAdd)
        {
            if (toAdd is LongTermGoal)
            {
                LongTermGoal tempLong = toAdd as LongTermGoal;
                foreach (ShortTermGoal s in tempLong.ReqShort)
                {
                    if (!(_goals.Contains(s)))
                    {
                        AddGoal(s);
                    }
                }
            }
            else if (toAdd is ShortTermGoal)
            {
                ShortTermGoal tempShort = toAdd as ShortTermGoal;
                foreach (TaskGoal t in tempShort.ReqTasks)
                {
                    if (!(_goals.Contains(t)))
                    {
                        AddGoal(t);
                    }
                }
            }
            _goals.Add(toAdd);
        }

        /// <summary>
        /// Removes the inputed goal from the profile and all it's children. Also, the inputed goal is disconnected form any parent goals
        /// </summary>
        /// <param name="toRem">Goal</param>
        public void RemoveGoal(Goal toRem)
        {
            if (toRem is LongTermGoal)
            {
                LongTermGoal tempLong = toRem as LongTermGoal;
                while(tempLong.ReqShort.Count > 0)
                {
                    RemoveGoal(tempLong.ReqShort[0]);
                }
            }
            else if (toRem is ShortTermGoal)
            {
                ShortTermGoal tempShort = toRem as ShortTermGoal;
                foreach (Goal g in _goals)
                {
                    if (g is LongTermGoal)
                    {
                        LongTermGoal tempG = g as LongTermGoal;
                        if (tempG.ReqShort.Contains(tempShort))
                        {
                            tempG.ReqShort.Remove(tempShort);
                        }
                    }
                }
                while(tempShort.ReqTasks.Count > 0)
                {
                    RemoveGoal(tempShort.ReqTasks[0]);
                }
            }
            else
            {
                TaskGoal tempTask = toRem as TaskGoal;
                foreach(Goal g in _goals)
                {
                    if (g is ShortTermGoal)
                    {
                        ShortTermGoal tempShort = g as ShortTermGoal;
                        if (tempShort.ReqTasks.Contains(tempTask))
                        {
                            tempShort.ReqTasks.Remove(tempTask);
                        }
                    }
                }
            }
            _goals.Remove(toRem);
        }

        /// <summary>
        /// Removes this goal but NOT its children from the profile. Does disconnect it from any parent goals.
        /// </summary>
        /// <param name="toRem">Goal</param>
        public void RemoveGoalSolo(Goal toRem)
        {
            _goals.Remove(toRem);
            if (toRem is ShortTermGoal)
            {
                ShortTermGoal tempShort = toRem as ShortTermGoal;
                foreach (Goal g in _goals)
                {
                    if (g is LongTermGoal)
                    {
                        LongTermGoal tempG = g as LongTermGoal;
                        if (tempG.ReqShort.Contains(tempShort))
                        {
                            tempG.ReqShort.Remove(tempShort);
                        }
                    }
                }
            } else if (toRem is TaskGoal)
            {
                TaskGoal tempTask = toRem as TaskGoal;
                foreach(Goal g in _goals)
                {
                    if (g is ShortTermGoal)
                    {
                        ShortTermGoal tempShort = g as ShortTermGoal;
                        if (tempShort.ReqTasks.Contains(tempTask))
                        {
                            tempShort.ReqTasks.Remove(tempTask);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Attempts to complete the inputed goal and returns a string explaining the events
        /// </summary>
        /// <param name="toComp">Goal</param>
        /// <returns>String</returns>
        public string CompleteGoal(Goal toComp)
        {
            string result = "";

            foreach (Goal g in _goals)
            {
                if (g == toComp)
                {
                    result = g.Complete(ref _exp);
                }
            }

            if (result == "")
            {
                result = Environment.NewLine + "No goal was found";
            }

            while ((_exp >= _expReq) && (_level < MAX_LEVEL))
            {
                result += LevelUp();
            }
            return result;
        }

        /// <summary>
        /// Overrides the List method and returns profile as well as the List of every goal part of this profile
        /// </summary>
        /// <returns>String</returns>
        public override string List()
        {
            string result = Environment.NewLine +  "Profile";
            result += base.List();
            result += Environment.NewLine;
            result += Environment.NewLine + "Goals: " + Environment.NewLine;
            foreach (Goal g in _goals)
            {
                result += g.List();
                result += Environment.NewLine;
            }
            return result;            
        }

        /// <summary>
        /// Returns a string list of goals based on the inputed category
        /// </summary>
        /// <param name="cat">GoalCategory</param>
        /// <returns>String</returns>
        public string ListCategory(GoalCategory cat)
        {
            string result = "";
            switch (cat)
            {
                case GoalCategory.Career:
                    foreach (Goal g in CareerGoals)
                    {
                        result += g.List();
                    }
                    break;

                case GoalCategory.Health:
                    foreach (Goal g in HealthGoals)
                    {
                        result += g.List();
                    }
                    break;

                case GoalCategory.Hobby:
                    foreach (Goal g in HobbyGoals)
                    {
                        result += g.List();
                    }
                    break;

                default:
                    foreach (Goal g in InterGoals)
                    {
                        result += g.List();
                    }
                    break;
            }
            return result;
        }

        /// <summary>
        /// Returns a string list of all goals based on the inputed type
        /// </summary>
        /// <param name="t">Goal Type (short,long, task)</param>
        /// <returns>String</returns>
        public string ListType(Type t)
        {
            string result = "";
            if (t == typeof(LongTermGoal))
            {
                foreach (LongTermGoal lg in LongGoals)
                {
                    result += lg.List();
                }
            }
            else if (t == typeof(ShortTermGoal))
            {
                foreach (ShortTermGoal sg in ShortGoals)
                {
                    result += sg.List();
                }
            }
            else 
            {
                foreach (TaskGoal tg in Tasks)
                {
                    result += tg.List();
                }
            }

            return result;
        }

        /// <summary>
        /// Saves the profile via the intputed stream writer
        /// </summary>
        /// <param name="sw">Stream Writer</param>
        public override void Save(System.IO.StreamWriter sw)
        {
            base.Save(sw);
            sw.WriteLine(Exp);
            sw.WriteLine(ExpReq);
            sw.WriteLine(Level);
            sw.WriteLine(Tasks.Count);
            sw.WriteLine(ShortGoals.Count);
            sw.WriteLine(LongGoals.Count);
            foreach (TaskGoal tg in Tasks)
            {
                tg.Save(sw);
            }
            foreach (ShortTermGoal sg in ShortGoals)
            {
                sg.Save(sw);
            }
            foreach (LongTermGoal lg in LongGoals)
            {
                lg.Save(sw);
            }
        }

        /// <summary>
        /// Levels up the profile and returns a string that adds a congradulations
        /// </summary>
        /// <returns>String</returns>
        private string LevelUp()
        {
            _exp = _exp - _expReq;
            _level++;
            _expReq = _expReq + DIFFICULTY;
            return Environment.NewLine + "!!!! LEVEL UP !!!!" + Environment.NewLine + 
                "You are now level " + _level + Environment.NewLine;
        }

        /// <summary>
        /// Gets or sets the current Exp on this profile
        /// </summary>
        public int Exp
        {
            get { return _exp; }
            set { _exp = value; }
        }

        /// <summary>
        /// Gets or sets the experience required to level up
        /// </summary>
        public int ExpReq
        {
            get { return _expReq; }
            set { _expReq = value; }
        }

        /// <summary>
        /// Gets or sets the level of this profile
        /// </summary>
        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }

        /// <summary>
        /// Gives direct acces to the _goals field. Read-Only
        /// </summary>
        public List<Goal> Goals
        {
            get { return _goals; }
        }

        /// <summary>
        /// Gives a deep copy of the list of all goals that have the goal category of health
        /// </summary>
        public List<Goal> HealthGoals
        {
            get { return _goals.Where(g => g.Category == GoalCategory.Health).ToList(); }
        }

        /// <summary>
        /// Gives a deep copy of the list of all goals that have the goal category of career
        /// </summary>
        public List<Goal> CareerGoals
        {
            get { return _goals.Where(g => g.Category == GoalCategory.Career).ToList(); }
        }

        /// <summary>
        /// Gives a deep copy of the list of all goals that have the goal category of Interpersonal
        /// </summary>
        public List<Goal> InterGoals
        {
            get { return _goals.Where(g => g.Category == GoalCategory.Interpersonal).ToList(); }
        }

        /// <summary>
        /// Gives a deep copy of the list of all goals that have the goal category of hobby
        /// </summary>
        public List<Goal> HobbyGoals
        {
            get { return _goals.Where(g => g.Category == GoalCategory.Hobby).ToList(); }
        }

        /// <summary>
        /// Gives a deep copy of the list of all goals that have the goal type of Long-Term
        /// </summary>
        public List<LongTermGoal> LongGoals
        {
            get { return _goals.Where(g => g.GetType() == typeof(LongTermGoal)).Cast<LongTermGoal>().ToList(); }
        }

        /// <summary>
        /// Gives a deep copy of the list of all goals that have the goal type of Short-Term
        /// </summary>
        public List<ShortTermGoal> ShortGoals
        {
            get { return _goals.Where(g => g.GetType() == typeof(ShortTermGoal)).Cast<ShortTermGoal>().ToList();  }
        }

        /// <summary>
        /// Gives a deep copy of the list of all goals that have the goal type of Task
        /// </summary>
        public List<TaskGoal> Tasks
        {
            get { return _goals.Where(g => g.GetType() == typeof(TaskGoal)).Cast<TaskGoal>().ToList(); }
        }
    }
}
