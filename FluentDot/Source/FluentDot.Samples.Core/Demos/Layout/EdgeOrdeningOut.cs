﻿/*
 Copyright 2009 Riaan Hanekom

 This program is licensed under the GNU Lesser General Public License (LGPL).  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at http://www.gnu.org/copyleft/lesser.html.
*/

using FluentDot.Attributes.Graphs;
using FluentDot.Expressions.Graphs;

namespace FluentDot.Samples.Core.Demos.Layout
{
    /// <summary>
    /// A demo of the orderining the graph edges out.
    /// </summary>
    public class EdgeOrdeningOut : AbstractGraphDemo
    {
        #region AbstractGraphDemo Members

        /// <summary>
        /// Gets or sets the friendly name of this demo.
        /// </summary>
        /// <value>The friendly name of the demo.</value>
        public override string FriendlyName
        {
            get { return "Edge Ordering Out"; }
        }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        public override string Description
        {
            get { return "A demo of the orderining the graph edges out."; }
        }

        /// <summary>
        /// Gets or sets the type of demo.
        /// </summary>
        /// <value>The type of demo.</value>
        public override DemoType Type
        {
            get { return DemoType.Layout; }
        }

        /// <summary>
        /// Produces the dot for the specified demo.
        /// </summary>
        /// <returns>DOT.</returns>
        protected override IGraphExpression CreateGraph()
        {
            #region ExportCode
            return Fluently.CreateDirectedGraph()
                .Edges.Add(edges =>
                               {
                                   edges.FromNodeWithName("a").ToNodeWithName("b");
                                   edges.FromNodeWithName("a").ToNodeWithName("c");
                                   edges.FromNodeWithName("b").ToNodeWithName("c");
                                   edges.FromNodeWithName("c").ToNodeWithName("d");
                                   edges.FromNodeWithName("b").ToNodeWithName("e");
                                   edges.FromNodeWithName("e").ToNodeWithName("g");
                                   edges.FromNodeWithName("e").ToNodeWithName("f");
                                   edges.FromNodeWithName("g").ToNodeWithName("h");
                               })
                .WithEdgeOrdering(Ordering.Out)
                .WithLabel("Out Ordering of edges");
            #endregion
        }

        #endregion
    }
}