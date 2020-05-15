using Penguin.Email.Abstractions.Interfaces;

namespace Penguin.Cms.Email.Abstractions.Interfaces
{
    public interface IPersistableEmailMessage : IEmailMessage
    {
        new string BCCRecipients { get; set; }
        new string CCRecipients { get; set; }
        new string Recipients { get; set; }
    }
}