using System.Collections.Generic;

namespace MyQuiver.Common
{
    /// <summary>
    /// Provides detailed responses if the operation had multiple messages returned
    /// </summary>
    public class DetailedResponse : Response
    {
        /// <summary>
        /// Get or set additional details from the operation
        /// </summary>
        public List<KeyValuePair<string,string>> Details { get; set; }
    }
}
