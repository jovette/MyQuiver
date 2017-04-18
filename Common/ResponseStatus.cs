namespace MyQuiver.Common
{
    /// <summary>
    /// Different response conditions from an operation
    /// </summary>
    public enum ResponseStatus
    {
        /// <summary>
        /// The operation performed as intended
        /// </summary>
        Success,
        /// <summary>
        /// The operation completed but, an erroneous result returned
        /// </summary>
        Error,
        /// <summary>
        /// The operation failed to complete
        /// </summary>
        Failure
    }
}
