namespace BusinessEntities
{
    public class BaseEntity<T>
    {
        public T CreatedUser { get; set; }
        public T CreatedDate { get; set; }
        public T ModifiedUser { get; set; }
        public T ModifiedDate { get; set; }
    }
}
