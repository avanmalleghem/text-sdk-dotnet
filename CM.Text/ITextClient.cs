using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CM.Text.BusinessMessaging.Model;
using JetBrains.Annotations;

namespace CM.Text
{
    /// <summary>
    ///     This interface provides methods to send text messages.
    /// </summary>
    public interface ITextClient
    {
        /// <summary>
        ///     Sends a message asynchronous.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        [PublicAPI]
        Task<TextClientResult> SendMessageAsync(Message message, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        ///     Sends a message asynchronous.
        /// </summary>
        /// <param name="messageText">The message text.</param>
        /// <param name="from">
        ///     This is the sender name.
        /// </param>
        /// <param name="to">
        ///     These are the destination mobile numbers.
        /// </param>
        /// <param name="reference">
        ///     Here you can include your message reference. This information will be returned in a status
        ///     report so you can match the message and it's status.
        /// </param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        [PublicAPI]
        Task<TextClientResult> SendMessageAsync(string messageText, string from, IEnumerable<string> to, [CanBeNull] string reference, CancellationToken cancellationToken = default(CancellationToken));
    }
}