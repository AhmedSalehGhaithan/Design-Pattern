using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern.NotificationsSystem
{
    public interface INotificationSender
    {
        void SendNotification(string message);
    }
}
