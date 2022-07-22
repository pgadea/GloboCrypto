using GloboCrypto.Models.Notifications;
using GloboCrypto.WebAPI.Services.Notifications;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GloboCrypto.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService NotificationService;
        public NotificationController(INotificationService notificationService)
        {
            NotificationService = notificationService;
        }

        [HttpPut("subscribe")]
        [Authorize]
        public async Task<NotificationSubscription> Subscribe(NotificationSubscription subscription)
        {
            return await NotificationService.SubscribeAsync(User.Identity.Name, subscription);
        }

        [HttpGet("update-subscription")]
        [Authorize]
        public async Task UpdateSubscription(string coinIds)
        {
            await NotificationService.UpdateSubscriptionAsync(User.Identity.Name, coinIds);
        }

        [HttpGet("check-and-notify")]
        [Authorize]
        public async Task CheckAndNotify()
        {
            await NotificationService.CheckAndNotifyAsync();
        }
    }
}
