using Microsoft.EntityFrameworkCore;

namespace Skeleton.DAL.Entities
{
    public class User : BaseEntity       //user class inheriting from the BaseEntity class
    {
        public string Name { get; set; }              //properties
        public string Surname { get; set; }
        public string Password { get; set; }

        public ICollection<Test>? Tests { get; set; }        //Collection associated with the user. "?" means thas value can be null
    }
}
