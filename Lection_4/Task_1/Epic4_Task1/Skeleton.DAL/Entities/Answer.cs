using Microsoft.EntityFrameworkCore;

namespace Skeleton.DAL.Entities
{
    public class Answer : BaseEntity
    {
        public string Text { get; set; }         //propertyes
        public bool IsCorrect { get; set; }
        public Guid? QuestionId { get; set; }     //the unique object

        public Question? Question { get; set; }   //reference to a Question object
    }
}
