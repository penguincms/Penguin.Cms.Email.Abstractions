namespace Penguin.Cms.Email.Abstractions
{
    /// <summary>
    /// Represents the sent state of the message, used when queueing
    /// </summary>
    public enum EmailMessageState
    {
        /// <summary>
        /// No attempt has been made to send the message
        /// </summary>
        Unsent,

        /// <summary>
        /// The previous attempt to send the message was successful
        /// </summary>
        Success,

        /// <summary>
        /// The previous attempt to send the message resulted in an error
        /// </summary>
        Failure,

        /// <summary>
        /// The message should not be sent for environment reasons and no attempt has been made
        /// </summary>
        Debug,

        /// <summary>
        /// The message should not be sent due to some kind of business logic and no attempt has been made
        /// </summary>
        Skip
    }
}