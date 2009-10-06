﻿/*
 Copyright 2009 Riaan Hanekom

 This program is licensed under the GNU Lesser General Public License (LGPL).  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at http://www.gnu.org/copyleft/lesser.html.
*/

using FluentDot.Attributes.Graphs;
using NUnit.Framework;

namespace FluentDot.Tests.Attributes.Graphs {
    
    [TestFixture]
    public class PageAttributeTests {

        [Test]
        public void ToDot_Should_Produce_Correct_Output()
        {
            Assert.AreEqual(new PageAttribute(0.22f, 0.33f).ToDot(), "page=\"0.22,0.33\"");
        }
    }
}
