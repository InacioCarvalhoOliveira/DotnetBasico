using MaoNaMassaOop.SharedContext;
namespace MaoNaMassaOop.ContentContext
{
public class CareerItem : Base
    {


        public CareerItem(int order, string title, string description,string a,Course course)
        {            
            Order = order;
            Title = title;
            Description = description;
            Course = course;

            if(course == null)
                AddNotification(new NotificationContext.Notification("Course","Curso inválido"));
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
         
    }

}