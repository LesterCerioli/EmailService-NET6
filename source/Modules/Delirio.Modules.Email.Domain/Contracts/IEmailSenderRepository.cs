using Delirio.Modules.Email.Domain.Modules;

namespace Delirio.Modules.Email.Domain.Contracts
{
    public interface IEmailSenderRepository
    {
        Task<OrderEmail> SendEmailAsync(string email, string subject, string message, bool isHtml = false);
    }
}