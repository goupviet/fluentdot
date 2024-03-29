﻿/*
 Copyright 2009 Riaan Hanekom

 This program is licensed under the GNU Lesser General Public License (LGPL).  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at http://www.gnu.org/copyleft/lesser.html.
*/

namespace FluentDot.Attributes.Edges {

    /// <summary>
    /// An attribute that sets the target on an edge tail.
    /// </summary>
    public class TailTargetAttribute : AbstractDotAttribute<string> {

        #region Construction

        /// <summary>
        /// Initializes a new instance of the <see cref="TailTargetAttribute"/> class.
        /// </summary>
        /// <param name="target">The target.</param>
        public TailTargetAttribute(string target)
            : base("tailtarget", target, true) {

        }

        #endregion
    }
}
