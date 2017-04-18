namespace MyQuiver.Common
{
    /// <summary>
    /// Authentication providers that users can use to register for the application
    /// </summary>
    public enum AuthenicationProvider
    {
        /// <summary>
        /// Facebook authentication provider
        /// </summary>
        Facebook = 1,
        /// <summary>
        /// Twitter authentication provider
        /// </summary>
        Twitter = 2,
        /// <summary>
        /// Google authentication provider
        /// </summary>
        Google = 3,
        /// <summary>
        /// Microsoft authentication provider
        /// </summary>
        Microsoft = 4,
        /// <summary>
        /// Open ID authentication provider
        /// </summary>
        OpenID = 5
    }
}
