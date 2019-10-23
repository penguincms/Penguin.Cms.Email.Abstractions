using Penguin.Email.Abstractions.Interfaces;

namespace Penguin.Cms.Email.Abstractions.Interfaces
{
    public interface IPersistableEmailMessage : IEmailMessage
    {
        string BCCRecipients { get; set; }
        string CCRecipients { get; set; }
        string Recipients { get; set; }
    }
}