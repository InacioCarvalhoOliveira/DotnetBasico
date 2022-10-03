using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using MaoNaMassaOop.NotificationContext;
using MaoNaMassaOop.SharedContext;

namespace MaoNaMassaOop.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }

        public string Email { get; set; }
        
        public string Name { get; set; }
        
        public User User { get; set; } 
        public IList<Subscription> Subscriptions { get; set; }
        public void CreateSubscription(Subscription subscription)
        {
            if(IsPremium)
            {
                AddNotification(new Notification("Preminum","aluno já temassinatura premium"));
                return;
            }
            Subscriptions.Add(subscription);
        }
        public bool Ispremium { get; set; }
        public bool IsPremium => Subscriptions.Any(x=> !x.IsInactive); 

         
        
    }
}