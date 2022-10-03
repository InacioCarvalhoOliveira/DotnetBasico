using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Linq;

namespace MaoNaMassaOop.NotificationContext
{
    //abstract faz com que a classe não seja instanciada 
    public abstract class Notifiable
    {       
       public List<Notification> Notifications { get; set; }

       public Notifiable()
       {
        Notifications = new List<Notification>();
       }
       public void AddNotification(Notification notification )
       {
           Notifications.Add(notification);
       }
       public void AddNotifications(IEnumerable<Notification> notifications)
       {
           Notifications.AddRange(notifications);
       }

       public bool IsValid => Notifications.Any();
       
    }
        
        
}