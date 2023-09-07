namespace Skeleton.DAL.Entities
{
    public abstract class BaseEntity          //other classes can be only inherit from abstract class
    {
        public Guid Id { get; set; }          //guid means unique object 
    }
}
