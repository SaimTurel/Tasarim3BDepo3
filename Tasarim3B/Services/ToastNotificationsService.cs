using CommunityToolkit.WinUI.Notifications;

using Tasarim3B.Contracts.Services;

using Windows.UI.Notifications;

namespace Tasarim3B.Services;

public partial class ToastNotificationsService : IToastNotificationsService
{
    public ToastNotificationsService()
    {
    }

    public void ShowToastNotification(ToastNotification toastNotification)
    {
        ToastNotificationManagerCompat.CreateToastNotifier().Show(toastNotification);
    }
}
