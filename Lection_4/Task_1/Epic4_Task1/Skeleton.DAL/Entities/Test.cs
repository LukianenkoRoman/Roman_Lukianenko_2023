using Microsoft.EntityFrameworkCore;

namespace Skeleton.DAL.Entities
{
    public class Test : BaseEntity
    {
        public string Title { get; set; }        //propertyes     
        public string Description { get; set; }

        public Guid? CreatedForUserID { get; set; }      //the unique object 


        public User? User { get; set; }      //reference to a User object
        public ICollection<Question>? Questions { get; set; }   //question objects is associated with the test
    }
}