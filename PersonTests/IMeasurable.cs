using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonTests
{
    /// <summary>
    /// Creates and initalizes the IMeasurable interface.
    /// </summary>
    internal interface IMeasurable
    {
        /// <summary>
        /// Calls on the Size method in the Person Class.
        /// </summary>
        /// <returns>Int value of the name's lenght.</returns>
        public int Size();
    }
}
