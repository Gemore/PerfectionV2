using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfectionV2
{
    /// <summary>
    /// Shows lists of all the users goals so that they may pick which ones to complete.
    /// </summary>
    public partial class completeGoalForm : Form
    {
        PerfectionModel _model;
        bool _submitted;
        List<TaskGoal> _tasksToComplete;
        List<ShortTermGoal> _shortToComplete;
        List<LongTermGoal> _longToComplete;

        /// <summary>
        /// completeGoalForm constructor. Takes in a model and sets default values.
        /// All goals already completed are added to locked completed goal list box.
        /// </summary>
        /// <param name="model">Perfection Model</param>
        public completeGoalForm(PerfectionModel model)
        {
            InitializeComponent();
            _model = model;
            _submitted = false;

            taskCkhBx.Items.Clear();
            shortChkBx.Items.Clear();
            longChkBx.Items.Clear();
            completedBx.Items.Clear();
            _tasksToComplete = new List<TaskGoal>();
            _shortToComplete = new List<ShortTermGoal>();
            _longToComplete = new List<LongTermGoal>();

            foreach (TaskGoal tg in _model.User.Tasks)
            {
                if (!tg.Completed)
                {
                    taskCkhBx.Items.Add(tg);
                }
            }

            foreach (ShortTermGoal sg in _model.User.ShortGoals)
            {
                if (!sg.Completed)
                {
                    shortChkBx.Items.Add(sg);
                }
            }

            foreach (LongTermGoal lg in _model.User.LongGoals)
            {
                if (!lg.Completed)
                {
                    longChkBx.Items.Add(lg);
                }
            }

            foreach (Goal g in _model.User.Goals)
            {
                if (g.Completed)
                {
                    completedBx.Items.Add(g);
                }
            }
        }

        /// <summary>
        /// Closes this form and sets _submitted to false as a precaution.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            _submitted = false;
            this.Close();
        }

        private void completeGoalForm_Load(object sender, EventArgs e)
        {           
        }

        /// <summary>
        /// When the submit button is clicked, sets _submitted to true and adds all checked lists to _goalsToBeCompelted (a list read by mainform)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitBtn_Click(object sender, EventArgs e)
        {
            _submitted = true;

            foreach (TaskGoal tg in taskCkhBx.CheckedItems)
            {
                _tasksToComplete.Add(tg);
            }

            foreach (ShortTermGoal sg in shortChkBx.CheckedItems)
            {
                _shortToComplete.Add(sg);
            }

            foreach (LongTermGoal lg in longChkBx.CheckedItems)
            {
                _longToComplete.Add(lg);
            }

            this.Close();
        }

        /// <summary>
        /// Returns whether this form has been submitted.
        /// </summary>
        public bool Submitted
        {
            get { return _submitted; }
        }

        /// <summary>
        /// Returns a list of task goals the user has checked that need to be completed.
        /// </summary>
        public List<TaskGoal> TasksToComplete
        {
            get { return _tasksToComplete; }
        }

        /// <summary>
        /// Returns a list of short-term goals the user has checked that need to be completed.
        /// </summary>
        public List<ShortTermGoal> ShortToComplete
        {
            get { return _shortToComplete; }
        }

        /// <summary>
        /// Returns a list of long-term goals the user has checked that need to be completed.
        /// </summary>
        public List<LongTermGoal> LongToComplete
        {
            get { return _longToComplete; }
        }
    }
}
