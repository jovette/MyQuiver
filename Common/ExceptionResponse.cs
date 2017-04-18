namespace MyQuiver.Common
{
    /// <summary>
    /// Provides application exception information in the response. This is useful in a logging scenario
    /// </summary>
    public class ExceptionResponse : Response
    {
        /// <summary>
        /// Construct a new ExceptionResponse with the default status as Failure
        /// </summary>
        public ExceptionResponse()
        {
            Status = ResponseStatus.Failure;
        }

        /// <summary>
        /// Get or set the inner exception if one was provided
        /// </summary>
        public string InnerException { get; set; }

        /// <summary>
        /// Get or set the stack trace of where the exception occured
        /// </summary>
        public string StackTrace { get; set; }

        /// <summary>
        /// Get or set the reflected type of the exception thrown
        /// </summary>
        public string ExceptionType { get; set; }
    }
}
