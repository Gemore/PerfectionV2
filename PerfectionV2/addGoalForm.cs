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
    /// Form that allows the creation of a goal.
    /// </summary>
    public partial class addGoalForm : Form
    {
        Goal _goalToAdd;
        bool _submitted;
        PerfectionModel _model;

        /// <summary>
        /// Constructor for addGoalForm. Takes in a model to get data relating to existing goals.
        /// </summary>
        /// <param name="model"> Perfection model</param>
        public addGoalForm (PerfectionModel model)
        {
            InitializeComponent();
            _model = model;
            _submitted = false;
            _goalToAdd = null;
        }

        private void addGoalForm_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Closes this form and sets _submitted to false (precaution)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            _submitted = false;
            this.Close();
        }

        /// <summary>
        /// Checks all the data entry is acceptable. If it is, sets _goalToAdd with that data.
        /// If long or short term goal, user can select goals from a list of possible children. All checked items are added.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitBtn_Click(object sender, EventArgs e)
        {

            bool goalNameUsed = false;
            foreach (Goal g in _model.User.Goals)
            {
                if (g.Name == goalNameBx.Text)
                {
                    goalNameUsed = true;
                    break;
                }
            }

            if (goalNameBx.Text == "")
            {
                MessageBox.Show("Please enter a goal name");
            }
            else if (goalDescBx.Text == "")
            {
                MessageBox.Show("Please enter a goal description");
            } else if (goalNameUsed)
            {
                MessageBox.Show("Please use a unique name");
            }
            else
            {
                try
                {
                    GoalCategory gc;
                    if (cateComboBx.SelectedItem.ToString() == "Career")
                    {
                        gc = GoalCategory.Career;
                    }
                    else if (cateComboBx.SelectedItem.ToString() == "Health")
                    {
                        gc = GoalCategory.Health;
                    }
                    else if (cateComboBx.SelectedItem.ToString() == "Interpersonal")
                    {
                        gc = GoalCategory.Interpersonal;
                    }
                    else if (cateComboBx.SelectedItem.ToString() == "Hobby")
                    {
                        gc = GoalCategory.Hobby;
                    }
                    else
                    {
                        throw new NullReferenceException();
                    }

                    if (shortRad.Checked)
                    {

                        List<TaskGoal> tgToAdd = new List<TaskGoal>();

                        foreach (Goal g in goalListChkBx.CheckedItems)
                        {
                            foreach (Goal pg in _model.User.Goals)
                            {
                                if (g.Name == pg.Name)
                                {
                                    if (pg is TaskGoal)
                                    {
                                        tgToAdd.Add(pg as TaskGoal);
                                        break;
                                    }
                                }
                            }
                        }

                        if (estHoursUpDwn.Value <= 0)
                        {
                            _goalToAdd = new ShortTermGoal(goalNameBx.Text, goalDescBx.Text, gc, tgToAdd);
                        }
                        else
                        {
                            _goalToAdd = new ShortTermGoal(goalNameBx.Text, goalDescBx.Text, gc, tgToAdd, Convert.ToInt32(estHoursUpDwn.Value));
                        }
                    }
                    else if (longRad.Checked)
                    {
                        List<ShortTermGoal> sgToAdd = new List<ShortTermGoal>();
                        foreach (Goal g in goalListChkBx.CheckedItems)
                        {
                            foreach (Goal pg2 in _model.User.Goals)
                            {
                                if (g.Name == pg2.Name)
                                {
                                    if (pg2 is ShortTermGoal)
                                    {
                                        sgToAdd.Add(pg2 as ShortTermGoal);
                                        break;
                                    }
                                }
                            }
                        }

                        if (estHoursUpDwn.Value <= 0)
                        {
                            _goalToAdd = new LongTermGoal(goalNameBx.Text, goalDescBx.Text, gc, sgToAdd);
                        }
                        else
                        {
                            _goalToAdd = new LongTermGoal(goalNameBx.Text, goalDescBx.Text, gc, sgToAdd, Convert.ToInt32(estHoursUpDwn.Value));
                        }
                    }
                    else
                    {
                        if (estHoursUpDwn.Value <= 0)
                        {
                            _goalToAdd = new TaskGoal(goalNameBx.Text, goalDescBx.Text, gc);
                        }
                        else
                        {
                            _goalToAdd = new TaskGoal(goalNameBx.Text, goalDescBx.Text, gc, Convert.ToInt32(estHoursUpDwn.Value));
                        }
                    }
                    _submitted = true;
                    this.Close();
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Please select a goal category");
                }
            }

            
        }

        /// <summary>
        /// When the short-term goal radio button is checked, a list of task goals shows up for the user to select task goals from.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void shortRad_CheckedChanged(object sender, EventArgs e)
        {
            goalChkBxLb.Text = "Required Tasks to add:";
            goalChkBxLb.Show();
            goalListChkBx.Items.Clear();

            foreach (TaskGoal tg in _model.User.Tasks)
            {
                goalListChkBx.Items.Add(tg);
            }

            goalListChkBx.Show();
        }

        /// <summary>
        /// When the long-term goal radio button is checked, a list of short-term goals appear for the user to check.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void longRad_CheckedChanged(object sender, EventArgs e)
        {
            goalChkBxLb.Text = "Required Short-Term goals to add: ";
            goalChkBxLb.Show();
            goalListChkBx.Items.Clear();

            foreach (ShortTermGoal sg in _model.User.ShortGoals)
            {
                goalListChkBx.Items.Add(sg);
            }

            goalListChkBx.Show();
        }

        /// <summary>
        /// Returns the goal to be added to the profile.
        /// </summary>
        public Goal GoalToAdd
        {
            get { return _goalToAdd; }
        }

        /// <summary>
        /// Returns whether this form was closed via the submit button or not
        /// </summary>
        public bool Submitted
        {
            get { return _submitted; }
        }

        private void cateComboBx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// When the task radio button is checked, the list box is cleared and hidden, as its label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskRad_CheckedChanged(object sender, EventArgs e)
        {
            goalChkBxLb.Hide();
            goalListChkBx.Items.Clear();
            goalListChkBx.Hide();
        }
    }
}
