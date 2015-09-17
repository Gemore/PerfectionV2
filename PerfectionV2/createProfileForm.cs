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
    /// Create profile form, allows the data to set a name and description for their profile.
    /// </summary>
    public partial class createProfileForm : Form
    {
        string _profName, _profDesc;
        bool _submitted;

        /// <summary>
        /// Constructor for createProfileForm. Sets submitted to false.
        /// </summary>
        public createProfileForm()
        {
            InitializeComponent();
            _submitted = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Checks if the data is valid. If it is, sets the values and closes this form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void subProfBtn_Click(object sender, EventArgs e)
        {
            if (_profName == "")
            {
                MessageBox.Show("Please enter a valid name");
            }
            else
            {
                _profName = profNameBx.Text;
                _profDesc = profDescBx.Text;
                _submitted = true;
                this.Close();
            }
        }

        /// <summary>
        /// Closes this form and sets _submiited to false (precaution)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            _submitted = false;
            this.Close();
        }

        /// <summary>
        /// Returns the user-entered profile name.
        /// </summary>
        public string ProfName
        {
            get { return _profName; }
        }

        /// <summary>
        /// Returns the user-entered profile description
        /// </summary>
        public string ProfDesc
        {
            get { return _profDesc; }
        }

        /// <summary>
        /// Returns wether this form was submitted.
        /// </summary>
        public bool Submitted
        {
            get { return _submitted; }
        }
    }
}
