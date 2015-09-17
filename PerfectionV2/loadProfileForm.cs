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
    /// Form class for loading profiles
    /// </summary>
    public partial class loadProfileForm : Form
    {
        string _profName;
        bool _submitted;

        /// <summary>
        /// Constructor for loadProfileForm. Sets submitted to false.
        /// </summary>
        public loadProfileForm()
        {
            InitializeComponent();
            _submitted = false;
        }

        /// <summary>
        /// Checks the user inputed data. If valid, sets submitted to true and closes form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void subProfBtn_Click(object sender, EventArgs e)
        {
            if (profNameBx.Text != "")
            {
                _profName = profNameBx.Text;
                _submitted = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a profile name");
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
        /// Returns the intputed user name
        /// </summary>
        public string ProfName
        {
            get { return _profName; }
        }

        /// <summary>
        /// Returns whether this form has been submitted or not
        /// </summary>
        public bool Submitted
        {
            get { return _submitted; }
        }
    }
}
