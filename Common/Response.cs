using System;
using System.Text;

namespace MyQuiver.Common
{
    /// <summary>
    /// Foundation of all response message types
    /// </summary>
    public abstract class Response
    {
        /// <summary>
        /// Get or set the resulting status of the operation
        /// </summary>
        public ResponseStatus Status { get; set; }

        /// <summary>
        /// Get or set the message as a result of the operation
        /// </summary>
        public string Message { get; set; }
    }
}
