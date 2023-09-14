using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace Skeleton.DAL.Entities
{
    public class Question : BaseEntity
    {
        public string Text { get; set; }     
        public Guid? TestId { get; set; }   

        public Test? Test { get; set; }       
        public ICollection<Answer>? Answers { get; set; }  
    }
}
