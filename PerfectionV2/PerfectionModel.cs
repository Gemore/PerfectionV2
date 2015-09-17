using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectionV2
{
    /// <summary>
    /// The model for Perfection that handels all the back-end
    /// </summary>
    public class PerfectionModel
    {
        Profile _user;
        string _path;
        Loader _loader;

        /// <summary>
        /// Constructor for Perfection Model. Creates a loader and sets user to null.
        /// </summary>
        public PerfectionModel()
        {
            _user = null;
            _loader = new Loader();
        }

        /// <summary>
        /// Takes in a name and description and uses that to make a profile. Sets a path for the loader based on the name. Returns a string explaining the events
        /// </summary>
        /// <param name="name">string</param>
        /// <param name="desc">string</param>
        /// <returns>string</returns>
        public string NewUser(string name, string desc)
        {
            _user = new Profile(name, desc);
            _path = @"profile" + _user.Name + ".txt";

            return Environment.NewLine + name + " was created!";
        }

        /// <summary>
        /// Attempts to load a profile based on the inputed sting name, returns a string explaining the events. If a profile is loaded, sets it to _user
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string LoadProfile(string name)
        {
            _path = @"profile" + name + ".txt";
            if (!File.Exists(_path))
            {
                return Environment.NewLine + name + " profile doesn't exist.";

            } else 
            {
                using (StreamReader sr = new StreamReader (_path))
                {
                    _user = _loader.LoadProfile(sr);
                    sr.Close();
                }
                
            }

            return Environment.NewLine + _user.Name + " was succesfully loaded.";
        }

        /// <summary>
        /// Saves the profile and returns a string explaining the events.
        /// </summary>
        /// <returns></returns>
        public string SaveProfile()
        {
            StreamWriter sw = new StreamWriter(_path);
            _user.Save(sw);
            sw.Close();
            return Environment.NewLine + _user.Name + " was saved.";
        }

        /// <summary>
        /// Returns a string that is a list of all relevant information of the profile.
        /// </summary>
        /// <returns></returns>
        public string ListProfile()
        {
            return _user.List();
        }

        /// <summary>
        /// Returns a string list of the goals based on the input category
        /// </summary>
        /// <param name="cat"></param>
        /// <returns></returns>
        public string ListCategory(GoalCategory cat)
        {
            return _user.ListCategory(cat);
        }

        /// <summary>
        /// Returns a string list of goals based on the inputed type
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public string ListType(Type t)
        {
            return _user.ListType(t);
        }

        /// <summary>
        /// Returns the profile that is the user
        /// </summary>
        public Profile User 
        {
            get { return _user; }
        }

        /// <summary>
        /// Adds the inputed goal to the profile, returns a string explaining events
        /// </summary>
        /// <param name="toAdd">Goal</param>
        /// <returns></returns>
        public string AddGoal(Goal toAdd)
        {
            _user.AddGoal(toAdd);
            return Environment.NewLine + toAdd.Name + " was saved.";
        }

        /// <summary>
        /// Removes the inputed goal and all its required goals
        /// </summary>
        /// <param name="toRem">Goal</param>
        /// <returns></returns>
        public string RemoveGoal(Goal toRem)
        {
            _user.RemoveGoal(toRem);
            return Environment.NewLine + toRem.Name + " and all its children were removed.";
        }

        /// <summary>
        /// Removes the inputed goal, but none of its required goals
        /// </summary>
        /// <param name="toRem"></param>
        /// <returns></returns>
        public string RemoveGoalSolo(Goal toRem)
        {
            _user.RemoveGoalSolo(toRem);
            return Environment.NewLine + toRem.Name + " was removed.";
        }

        /// <summary>
        /// Returns a bool explaining whether a profile is loaded.
        /// </summary>
        public bool ProfLoaded
        {
            get
            {
                if (_user == null)
                {
                    return false;
                }
                else 
                {
                    return true;
                }
            
            }
        }

        /// <summary>
        /// Returns a bool explaining whether a profile file path exists or not
        /// </summary>
        public bool ProfAlreadyExists
        {
            get 
            {
                if (File.Exists(_path))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }
}
