﻿/*
 Copyright 2009 Riaan Hanekom

 This program is licensed under the GNU Lesser General Public License (LGPL).  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at http://www.gnu.org/copyleft/lesser.html.
*/

using FluentDot.Expressions.Graphs;

namespace FluentDot.Samples.Core.Demos.SimpleGraphs
{
    /// <summary>
    /// A simple undirected graph.
    /// </summary>
    public class SimpleUndirectedGraph : AbstractGraphDemo {

        #region AbstractGraphDemo Members

        /// <summary>
        /// Produces the dot for the specified demo.
        /// </summary>
        /// <returns>DOT.</returns>
        protected override IGraphExpression CreateGraph()
        {
            #region ExportCode
            return Fluently.CreateUndirectedGraph()
                .Edges.Add(x =>
                               {
                                   x.FromNodeWithName("A").ToNodeWithName("B");
                                   x.FromNodeWithName("A").ToNodeWithName("C");
                                   x.FromNodeWithName("B").ToNodeWithName("C");
                                   x.FromNodeWithName("B").ToNodeWithName("D");
                               }
                );
            #endregion
        }

        public override string FriendlyName {
            get { return "Simple Undirected Graph"; }
        }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        public override string Description {
            get { return "An illustration of a simple undirected graph."; }
        }

        /// <summary>
        /// Gets or sets the rank.
        /// </summary>
        /// <value>The rank.</value>
        public override DemoType Type {
            get { return DemoType.SimpleGraphs; }
        }

        #endregion
    }
}