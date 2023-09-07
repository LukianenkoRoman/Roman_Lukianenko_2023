using Microsoft.EntityFrameworkCore;

namespace Skeleton.DAL.Entities
{
    public class Question : BaseEntity
    {
        public string Text { get; set; }     //property
        public Guid? TestId { get; set; }    //the unique object 

        public Test? Test { get; set; }       //reference to a Test object
        public ICollection<Answer>? Answers { get; set; }   //Answer objects is associated with the Question
    }
}
