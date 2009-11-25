namespace Avencia.Open.DAO.SQL
{
    /// <summary>
    /// Many SQL clauses look something like this: "(colName > 5)".  However, on
    /// some DBs, that same clause may actually look like this: "LT_OR_EQ(5, colName)".
    /// To make things more complicated, you may want to not put 5 in the string, but
    /// use a parameter instead.  So this allows you to represent it, in the first case
    /// PartBeforeValue would be "(colName > " and PartAfterValue would be ")", and in
    /// the second case PartBeforeValue would be "LT_OR_EQ(" and PartAfterValue would
    /// be ", colName)".
    /// </summary>
    public class SqlClauseWithValue
    {
        /// <summary>
        /// The part of the clause that comes before the value.  May be null.
        /// </summary>
        public string PartBeforeValue;
        /// <summary>
        /// The part of the clause that comes after the value.  May be null.
        /// </summary>
        public string PartAfterValue;
        /// <summary>
        /// Create a blank clause.
        /// </summary>
        public SqlClauseWithValue()
        {
            // Nothing to do here.
        }

        /// <summary>
        /// Create a clause by specifying the before and after parts.
        /// </summary>
        /// <param name="before">The part of the clause that comes before the value.</param>
        /// <param name="after">The part of the clause that comes after the value.</param>
        public SqlClauseWithValue(string before, string after)
        {
            PartBeforeValue = before;
            PartAfterValue = after;
        }

        /// <summary>
        /// Sets both parts back to null.
        /// </summary>
        public void Clear()
        {
            PartBeforeValue = null;
            PartAfterValue = null;
        }
    }
}