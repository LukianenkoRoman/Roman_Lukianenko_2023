using Microsoft.EntityFrameworkCore;

namespace Skeleton.DAL.Entities
{
    public class Answer : BaseEntity
    {
        public string Text { get; set; }         
        public bool IsCorrect { get; set; }
        public Guid? QuestionId { get; set; }     

        public Question? Question { get; set; }   
    }
}