using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PerfectionV2
{
    /// <summary>
    /// Abstract class which allows objects to have a name and description.
    /// </summary>
    public abstract class Identifiable
    {
        private string _name, _desc;

        /// <summary>
        /// Constructor for Identifiable. Takes in a name and description
        /// </summary>
        /// <param name="name">String Name</param>
        /// <param name="desc">String Description</param>
        public Identifiable(string name, string desc)
        {
            _name = name;
            _desc = desc;
        }

        /// <summary>
        /// Gets or Sets the _name of this object.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Gets or Sets the description of this object
        /// </summary>
        public string Desc
        {
            get { return _desc; }
            set { _desc = value; }
        }

        /// <summary>
        /// Saves this object via the inputed streamwriter
        /// </summary>
        /// <param name="sw">StreamWriter</param>
        public virtual void Save ( StreamWriter sw )
        {
            sw.WriteLine(Name);
            sw.WriteLine(Desc);
        }

        /// <summary>
        /// Returns a string listing all the relevant information about this object
        /// </summary>
        /// <returns>String</returns>
        public virtual string List()
        {
            string result = Environment.NewLine + "Name: " + _name;
            result += Environment.NewLine + "Description: " + _desc;
            return result;
        }

        /// <summary>
        /// Overrides the ToString function so that it returns Identifiable's name.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _name;
        }
    }
}
