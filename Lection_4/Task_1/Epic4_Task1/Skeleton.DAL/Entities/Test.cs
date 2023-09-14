using Microsoft.EntityFrameworkCore;

namespace Skeleton.DAL.Entities
{
    public class Test : BaseEntity
    {
        public string Title { get; set; }         
        public string Description { get; set; }

        public Guid? CreatedForUserID { get; set; }       


        public User? User { get; set; }     
        public ICollection<Question>? Questions { get; set; }   
    }
}
