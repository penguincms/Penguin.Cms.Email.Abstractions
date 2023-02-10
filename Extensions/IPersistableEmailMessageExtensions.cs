using Penguin.Cms.Email.Abstractions.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Penguin.Cms.Email.Abstractions.Extensions
{
    public static class IEmailPersistableMessageExtensions
    {
        /// <summary>
        /// Adds BCC recipients to the message
        /// </summary>
        /// <param name="source"></param>
        /// <param name="NewBCCRecipients">The BCC recipients to add</param>
        public static void AddBCCRecipients(this IPersistableEmailMessage source, params string[] NewBCCRecipients)
        {
            if (source is null)
            {
                throw new System.ArgumentNullException(nameof(source));
            }

            List<string> oldList = source.GetBCCRecipients();

            oldList.AddRange(NewBCCRecipients.ToList());

            source.BCCRecipients = string.Join(";", oldList);
        }

        /// <summary>
        /// Adds CC recipients to the message
        /// </summary>
        /// <param name="source"></param>
        /// <param name="NewCCRecipients">The CC recipients to add</param>
        public static void AddCCRecipients(this IPersistableEmailMessage source, params string[] NewCCRecipients)
        {
            if (source is null)
            {
                throw new System.ArgumentNullException(nameof(source));
            }

            List<string> oldList = source.GetCCRecipients();

            oldList.AddRange(NewCCRecipients.ToList());

            source.CCRecipients = string.Join(";", oldList);
        }

        /// <summary>
        /// Adds new recipients to the message
        /// </summary>
        /// <param name="source"></param>
        /// <param name="NewRecipients">The recipients to add</param>
        public static void AddRecipients(this IPersistableEmailMessage source, params string[] NewRecipients)
        {
            if (source is null)
            {
                throw new System.ArgumentNullException(nameof(source));
            }

            List<string> oldList = source.GetRecipients();

            oldList.AddRange(NewRecipients.ToList());

            source.Recipients = string.Join(";", oldList);
        }

        /// <summary>
        /// returns the ; delimited list of recipients
        /// </summary>
        /// <returns>A list of strings representing each BCC recipient</returns>
        public static List<string> GetBCCRecipients(this IPersistableEmailMessage source)
        {
            return source is null
                ? throw new System.ArgumentNullException(nameof(source))
                : string.IsNullOrWhiteSpace(source.BCCRecipients) ? new List<string>() : source.BCCRecipients.Split(';').Where(r => !string.IsNullOrWhiteSpace(r)).ToList();
        }

        /// <summary>
        /// returns the ; delimited list of  recipients
        /// </summary>
        /// <returns>A list of strings representing each BCC recipient</returns>
        public static List<string> GetCCRecipients(this IPersistableEmailMessage source)
        {
            return source is null
                ? throw new System.ArgumentNullException(nameof(source))
                : string.IsNullOrWhiteSpace(source.CCRecipients) ? new List<string>() : source.CCRecipients.Split(';').Where(r => !string.IsNullOrWhiteSpace(r)).ToList();
        }

        /// <summary>
        /// returns the ; delimited list of recipients
        /// </summary>
        /// <returns>A list of strings representing each recipient</returns>
        public static List<string> GetRecipients(this IPersistableEmailMessage source)
        {
            return source is null
                ? throw new System.ArgumentNullException(nameof(source))
                : string.IsNullOrWhiteSpace(source.Recipients) ? new List<string>() : source.Recipients.Split(';').Where(r => !string.IsNullOrWhiteSpace(r)).ToList();
        }
    }
}