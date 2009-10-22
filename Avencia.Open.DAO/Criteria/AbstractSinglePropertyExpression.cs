// Copyright (c) 2004-2009 Avencia, Inc.
// 
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.

using System;

namespace Avencia.Open.DAO.Criteria
{
    /// <summary>
    /// Base class for expressions that only check one property.
    /// </summary>
    [Serializable]
    public abstract class AbstractSinglePropertyExpression : AbstractExpression
    {
        /// <summary>
        /// The data class' property/field being compared.
        /// May not be null.
        /// </summary>
        public readonly string Property;
        /// <summary>
        /// Base class for expressions that only check one property.
        /// </summary>
        /// <param name="property">The data class' property/field being compared.
        ///                        May not be null.</param>
        /// <param name="trueOrNot">True means look for matches (I.E. ==),
        ///                         false means look for non-matches (I.E. !=)</param>
        protected AbstractSinglePropertyExpression(string property, bool trueOrNot) : base(trueOrNot)
        {
            if (property == null)
            {
                throw new ArgumentNullException("property", "Property parameter cannot be null.");
            }
            Property = property;
        }

        /// <exclude/>
        public override string ToString()
        {
            return "Property=" + Property + ", " + base.ToString();
        }
    }
}