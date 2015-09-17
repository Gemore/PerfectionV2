using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectionV2
{
    /// <summary>
    /// The class that handles the loading of all information (Currently from text files).
    /// </summary>
    class Loader
    {
        /// <summary>
        /// Constructor for Loader
        /// </summary>
        public Loader()
        { }

        /// <summary>
        /// Loads a profile by reading a text document from the stream reader and returns it
        /// </summary>
        /// <param name="sr">StreamReader</param>
        /// <returns>Profile</returns>
        public Profile LoadProfile(StreamReader sr)
        {
            Profile user = new Profile("temp", "temp");

            user.Name = sr.ReadLine();
            user.Desc = sr.ReadLine();
            user.Exp = sr.ReadInteger();
            user.ExpReq = sr.ReadInteger();
            user.Level = sr.ReadInteger();
            int taskCount = sr.ReadInteger();
            int shortCount = sr.ReadInteger();
            int longCount = sr.ReadInteger();
            for (int i = 0; i < taskCount; i++)
            {
                LoadGoal(sr, ref user);
            }
            for (int i = 0; i < shortCount; i++)
            {
                LoadGoal(sr, ref user);
            }
            for (int i = 0; i < longCount; i++)
            {
                LoadGoal(sr, ref user);
            }

            return user;
        }

        /// <summary>
        /// Loads a goal from a stream reacer and attaches it to the profile
        /// </summary>
        /// <param name="sr">StreamReader</param>
        /// <param name="user">Profile</param>
        private void LoadGoal(StreamReader sr, ref Profile user)
        {
            Goal resultGoal = sr.ReadGoalType();
            string goalName = sr.ReadLine();
            string goalDesc = sr.ReadLine();
            GoalCategory goalCate = sr.ReadCategory();


            if (resultGoal is LongTermGoal)
            {
                LongTermGoal resultLong = new LongTermGoal(goalName, goalDesc, goalCate, new List<ShortTermGoal>());
                resultLong.Completed = sr.ReadBool();
                resultLong.ExpVal = sr.ReadInteger();
                resultLong.EstHours = sr.ReadInteger();
                int reqShort = sr.ReadInteger();
                for (int i = 0; i < reqShort; i++)
                {
                    string reqShortName = sr.ReadLine();
                    foreach (ShortTermGoal sg in user.ShortGoals)
                    {
                        if (sg.Name == reqShortName)
                        {
                            if (!resultLong.ReqShort.Contains(sg))
                            {
                                resultLong.ReqShort.Add(sg);
                                break;
                            }
                        }
                    }
                }
                resultGoal = resultLong;

            }
            else if (resultGoal is ShortTermGoal)
            {
                ShortTermGoal resultShort = new ShortTermGoal(goalName, goalDesc, goalCate, new List<TaskGoal>());
                resultShort.Completed = sr.ReadBool();
                resultShort.ExpVal = sr.ReadInteger();
                resultShort.EstHours = sr.ReadInteger();
                int reqTasks = sr.ReadInteger();
                for (int i = 0; i < reqTasks; i++)
                {
                    string reqTaskName = sr.ReadLine();
                    foreach (TaskGoal tg in user.Tasks)
                    {
                        if (tg.Name == reqTaskName)
                        {
                            if (!resultShort.ReqTasks.Contains(tg))
                            {
                                resultShort.ReqTasks.Add(tg);
                                break;
                            }
                        }
                    }
                }
                resultGoal = resultShort;
            }
            else
            {
                resultGoal = new TaskGoal(goalName, goalDesc, goalCate);
                resultGoal.Completed = sr.ReadBool();
                resultGoal.ExpVal = sr.ReadInteger();
                resultGoal.EstHours = sr.ReadInteger();
            }


            user.AddGoal(resultGoal);
        }
      
    }
}
