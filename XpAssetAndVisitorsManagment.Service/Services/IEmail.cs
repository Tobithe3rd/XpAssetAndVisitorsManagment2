using XpAssetAndVisitorsManagement.Service.Models;

namespace XpAssetAndVisitorsManagement.Service.Services
{
    public interface IEmail
    {
        void sendEmail(Message message);
    }
}
