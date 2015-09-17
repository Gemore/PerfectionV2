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
    /// The removeGoalForm. User inputs which goals they would like to remove, and then those goals are removed.
    /// </summary>
    public partial class removeGoalForm : Form
    {
        PerfectionModel _model;
        bool _submitted, _remSolo;
        List<Goal> _goalsToRemove;

        /// <summary>
        /// Constructor for the removeGoalForm. Sets values and takes in a model. Populates the checkbox with the users goals. Sets submitted to false.
        /// </summary>
        /// <param name="model"></param>
        public removeGoalForm(PerfectionModel model)
        {
            InitializeComponent();
            _model = model;
            _submitted = false;
            _remSolo = false;
            _goalsToRemove = new List<Goal>();

            foreach (Goal g in _model.User.Goals)
            {
                goalChkBx.Items.Add(g);
            }
        }

        /// <summary>
        /// Closes this form and sets submitted to false.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            _submitted = false;
            this.Close();

        }

        /// <summary>
        /// Closes this form and sets submitted to true. Populates  _goalsToRemove with all goals the user has checked.
        /// Checks whether user wants goals to be removed without their children.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitBtn_Click(object sender, EventArgs e)
        {
            foreach (Goal g in goalChkBx.CheckedItems)
            {
                _goalsToRemove.Add(g);
            }
            _submitted = true;
            if (rmvGoalSoloChk.Checked)
            {
                _remSolo = true;
            }
            this.Close();
        }


        /// <summary>
        /// Returns whether this form was submitted
        /// </summary>
        public bool Submitted
        {
            get { return _submitted; }
        }

        /// <summary>
        /// Returns whether the user checked to remove goals alone
        /// </summary>
        public bool RemoveSolo
        {
            get { return _remSolo; }
        }

        /// <summary>
        /// Returns a list of goals the user wants to remove.
        /// </summary>
        public List<Goal> GoalsToRemove
        {
            get { return _goalsToRemove; }
        }
    }
}
