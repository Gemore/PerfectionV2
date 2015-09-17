using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectionV2
{
    /// <summary>
    /// Extension methods for PerfectionV2
    /// </summary>
    public static class ExtensionMethods
    {

        /// <summary>
        /// Reads a line from the streamreader and converts it to an int.
        /// </summary>
        /// <param name="reader">Stream Reader</param>
        /// <returns>Integer</returns>
        public static int ReadInteger(this StreamReader reader)
        {
            return Convert.ToInt32(reader.ReadLine());
        }

        /// <summary>
        /// Reads a line from the streamreader and converts it to a goal(its type dependant on line read)
        /// </summary>
        /// <param name="reader">Stream Reader</param>
        /// <returns>Goal of type</returns>
        public static Goal ReadGoalType(this StreamReader reader)
        {
            Goal result;
            string readGoalType = reader.ReadLine();
            if (readGoalType == "LongTerm")
            {
                result = new LongTermGoal("", "", GoalCategory.Career, new List<ShortTermGoal>() );
            }
            else if (readGoalType == "ShortTerm")
            {
                result = new ShortTermGoal("", "", GoalCategory.Career, new List<TaskGoal>());
            }
            else if (readGoalType == "Task")
            {
                result = new TaskGoal("", "", GoalCategory.Career);
            }
            else
            {
                result = new TaskGoal("", "", GoalCategory.Career);
            }
            return result;
        }

        /// <summary>
        /// Reads a line from the streamreader and converts it to a boolean.
        /// </summary>
        /// <param name="reader">Stream Reader</param>
        /// <returns>Boolean</returns>
        public static bool ReadBool(this StreamReader reader)
        {
            bool result;
            string readBool = reader.ReadLine();
            if (readBool.ToLower() == "true")
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        /// <summary>
        /// Reads a line from the streamreader and converts it into a GoalCategory.
        /// </summary>
        /// <param name="reader"> Stream Reader</param>
        /// <returns>GoalCategory</returns>
        public static GoalCategory ReadCategory(this StreamReader reader)
        {
            GoalCategory result;
            string readGoalCat = reader.ReadLine();
            if (readGoalCat == "Hobby")
            {
                result = GoalCategory.Hobby;
            }
            else if (readGoalCat == "Health")
            {
                result = GoalCategory.Health;
            }
            else if (readGoalCat == "Career")
            {
                result = GoalCategory.Career;
            }
            else if (readGoalCat == "Interpersonal")
            {
                result = GoalCategory.Interpersonal;
            }
            else
            {
                result = GoalCategory.Hobby;
            }
            return result;
        }
    }
}
