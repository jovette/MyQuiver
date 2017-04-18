namespace MyQuiver.Common
{
    /// <summary>
    /// A response that will return an expected value as a result, such as the ID of a newly inserted record.
    /// </summary>
    /// <typeparam name="TVal">The type of value expected</typeparam>
    public class ValueResponse<TVal> : Response
    {
        /// <summary>
        /// Get or set the expected value returned from the operation
        /// </summary>
        public TVal Value { get; set; }
    }
}
