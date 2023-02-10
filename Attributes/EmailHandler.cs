using System;

namespace Penguin.Cms.Email.Abstractions.Attributes
{
    /// <summary>
    /// Used to define this method as generating an email upon execution
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class EmailHandlerAttribute : Attribute
    {
        /// <summary>
        /// The name that this method should be given publically
        /// </summary>
        public string HandlerName { get; internal set; }

        /// <summary>
        /// Constructs a new instance of this attribute
        /// </summary>
        /// <param name="handlerName">The name that this method should be given publically </param>
        public EmailHandlerAttribute(string handlerName = null)
        {
            HandlerName = handlerName;
        }
    }
}