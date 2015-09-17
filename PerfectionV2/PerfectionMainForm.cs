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
    /// The main form.
    /// </summary>
    public partial class PerfectionMain : Form
    {
        public PerfectionModel model;

        /// <summary>
        /// Default Constuctor, intializes the model.
        /// </summary>
        public PerfectionMain()
        {
            InitializeComponent();
            model = new PerfectionModel();
        }

        /// <summary>
        /// Intialises a create profile form. If its submitted, creates the user profile.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createProfBtn_Click(object sender, EventArgs e)
        {
            createProfileForm createForm = new createProfileForm();
            if (model.ProfLoaded)
            {
                if (MessageBox.Show("Are you sure? This will remove your current profile", "Create Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Hide();
                    using (createForm)
                    {
                        createForm.ShowDialog();
                    }
                }
            }
            else 
            {
                this.Hide();
                using (createForm)
                {
                    createForm.ShowDialog();
                }
            }

            if (createForm.Submitted)
            {
                outputBox.Text += model.NewUser(createForm.ProfName, createForm.ProfDesc);
                profNameLb.Text = "Profile: " + model.User.Name;
                proflevelLb.Text = "Level: " + model.User.Level;
                expProgBar.Value = 0;
                expProgBar.Maximum = model.User.ExpReq;
                expProgBar.Increment(model.User.Exp);

            } else if (!createForm.Submitted)
            {
                outputBox.Text += Environment.NewLine + "No profile was created.";
            }
            this.Show();
        }


        /// <summary>
        /// If a profile is loaded, saves the profile. If the profile has already been saved, asks the user if they want to overwrite.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveProfBtn_Click(object sender, EventArgs e)
        {
            if (model.ProfLoaded)
            {
                if (model.ProfAlreadyExists)
                {
                    if (MessageBox.Show("Profile already exists. Overwrite?", "Save Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        outputBox.Text += model.SaveProfile();
                    }
                }
                else 
                {
                    outputBox.Text += model.SaveProfile();
                }
            }
            else
            {
                MessageBox.Show("You currently have no profile");
            }
        }
        
        /// <summary>
        /// If a profile is already loaded, asks the user if they want to load a new profile. Attempts to load a new profile based on the load form. No changes if invalid input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadProfBtn_Click(object sender, EventArgs e)
        {
            loadProfileForm loadForm = new loadProfileForm();
            if (model.ProfLoaded)
            {
                this.Hide();
                
                if (MessageBox.Show("Are you sure? This will remove your current profile", "Load Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Hide();
                    using (loadForm)
                    {
                        loadForm.ShowDialog();
                    }
                }
            }
            else 
            {
                this.Hide();
                using (loadForm)
                {
                    loadForm.ShowDialog();
                }
            }

            if (loadForm.Submitted)
            {
                outputBox.Text += model.LoadProfile(loadForm.ProfName);
                profNameLb.Text = "Profile: " + model.User.Name;
                proflevelLb.Text = "Level: " + model.User.Level;
                expProgBar.Value = 0;
                expProgBar.Maximum = model.User.ExpReq;
                expProgBar.Increment(model.User.Exp);
            }
            else
            {
                outputBox.Text += Environment.NewLine + "No profile was loaded.";
            }

            this.Show();
        }

        private void PerfectionMain_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// If a profile is loaded, creates an add goal form. if the user submits a valid goal, it is added to the profile.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addGoalBtn_Click(object sender, EventArgs e)
        {
            if (model.ProfLoaded)
            {
                this.Hide();
                addGoalForm addForm = new addGoalForm(model);
                using (addForm)
                {
                    addForm.ShowDialog();
                }

                if (addForm.Submitted)
                {
                    outputBox.Text += model.AddGoal(addForm.GoalToAdd);
                }
                else
                {
                    outputBox.Text += Environment.NewLine + "No goal was added";
                }
                this.Show();
            }
            else
            {
                MessageBox.Show("You currently have no profile");
            }
        }

        /// <summary>
        /// Asks the user if they are sure they want to quit. If yes, closes this form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitBtn_Click(object sender, EventArgs e)
        {
            if (model.ProfLoaded)
            {
                if (MessageBox.Show("Are you sure? Your profile won't be saved", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        /// <summary>
        /// Lists all of the goals in the output box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listGoalsBtn_Click(object sender, EventArgs e)
        {
            if (model.ProfLoaded)
            {
                outputBox.Text += model.ListProfile();
            } else
            {
                MessageBox.Show("No profile loaded");
            }
        }

        /// <summary>
        /// If a profile is loaded, intialises a complete goal form. If the complete goal form is submitted, completes all goals that were checked.
        /// Updates the exp bar and notifies the user if they leveled up.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void completeGoalBtn_Click(object sender, EventArgs e)
        {
            if (model.ProfLoaded)
            {
                int currLvl = model.User.Level;
                this.Hide();
                completeGoalForm compForm = new completeGoalForm(model);
                using (compForm)
                {
                    compForm.ShowDialog();
                }

                this.Show();

                if (compForm.Submitted)
                {
                    foreach (TaskGoal tg in compForm.TasksToComplete)
                    {
                        foreach (Goal g1 in model.User.Goals)
                        {
                            if (tg.Name == g1.Name)
                            {
                                outputBox.Text += model.User.CompleteGoal(g1);
                                while (currLvl < model.User.Level)
                                {
                                    expProgBar.Value = expProgBar.Maximum;
                                    proflevelLb.Text = "Level: " + model.User.Level;
                                    MessageBox.Show("Well done! Level up!");
                                    expProgBar.Value = 0;
                                    expProgBar.Maximum = model.User.ExpReq;
                                    expProgBar.Value = model.User.Exp;
                                    currLvl++;
                                }
                                expProgBar.Value = model.User.Exp;
                                
                            }
                        }
                    }

                    foreach (ShortTermGoal sg in compForm.ShortToComplete)
                    {
                        foreach (Goal g2 in model.User.Goals)
                        {
                            if (sg.Name == g2.Name)
                            {
                                outputBox.Text += model.User.CompleteGoal(g2);
                               while (currLvl < model.User.Level)
                                {
                                    expProgBar.Value = expProgBar.Maximum;
                                    proflevelLb.Text = "Level: " + model.User.Level;
                                    MessageBox.Show("Well done! Level up!");
                                    expProgBar.Value = 0;
                                    expProgBar.Maximum = model.User.ExpReq;
                                    expProgBar.Value = model.User.Exp;
                                    currLvl++;
                                }
                                expProgBar.Value = model.User.Exp;
                                
                            }
                        }
                    }

                    foreach (LongTermGoal lg in compForm.LongToComplete)
                    {
                        foreach (Goal g3 in model.User.Goals)
                        {
                            if (lg.Name == g3.Name)
                            {
                                outputBox.Text += model.User.CompleteGoal(g3);
                                while (currLvl < model.User.Level)
                                {
                                    expProgBar.Value = expProgBar.Maximum;
                                    proflevelLb.Text = "Level: " + model.User.Level;
                                    MessageBox.Show("Well done! Level up!");
                                    expProgBar.Value = 0;
                                    expProgBar.Maximum = model.User.ExpReq;
                                    expProgBar.Value = model.User.Exp;
                                    currLvl++;
                                }
                                expProgBar.Value = model.User.Exp;
                                
                            }
                        }
                    }
                }
                else 
                {
                    outputBox.Text += Environment.NewLine + "No goals completed";
                }
            }
            else
            {
                MessageBox.Show("No profile loaded");
            }
        }

        /// <summary>
        /// If a profile is loaded, intialises a remove goal form. If the form is submitted, removes all goals on that checked list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeGoalBtn_Click(object sender, EventArgs e)
        {
            if (model.ProfLoaded)
            {
                removeGoalForm removeForm = new removeGoalForm(model);
                this.Hide();
                using (removeForm)
                {
                    removeForm.ShowDialog();
                }

                this.Show();

                if (removeForm.Submitted)
                {
                    if (!removeForm.RemoveSolo)
                    {
                        foreach (Goal g in removeForm.GoalsToRemove)
                        {
                            foreach (Goal pg in model.User.Goals)
                            {
                                if (g.Name == pg.Name)
                                {
                                    outputBox.Text += model.RemoveGoal(pg);
                                    break;
                                }
                            }
                        }
                    }
                    else 
                    {
                        foreach (Goal g in removeForm.GoalsToRemove)
                        {
                            foreach (Goal pg in model.User.Goals)
                            {
                                if (g.Name == pg.Name)
                                {
                                    outputBox.Text += model.RemoveGoalSolo(pg);
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    outputBox.Text += Environment.NewLine + "No goals removed";
                }
            }
            else
            {
                MessageBox.Show("No Profile loaded");
            }
        }
    
    }
}
