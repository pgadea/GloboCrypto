using GloboCrypto.Models.Notifications;

namespace GloboCrypto.WebAPI.Services.Notifications
{
    public interface INotificationService
    {
        Task CheckAndNotifyAsync();
        Task<NotificationSubscription> SubscribeAsync(string userId, NotificationSubscription subscription);
        Task UpdateSubscriptionAsync(string userId, string coinIds);
        Task<IEnumerable<NotificationSubscription>> GetSubscriptions();
    }
}
