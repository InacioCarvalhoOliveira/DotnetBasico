namespace MaoNaMassaOop.NotificationContext
{
    //com sealed a classe não pode ser extendida 
    public sealed class Notification
    {
        public Notification(){}           
        public string Property { get; set; }
        public string Message { get; set; }

        public Notification(string property,string message)
        {
            Property = property;
            Message = message;
        }        
     }       
}