namespace RealCloud.Data
{
    public class Property_Owner
    {
        public int OwnerId { get; set; }
        public int PropertyId { get; set; }

        public virtual Owner Owner { get; set; }
        public virtual PropertyDetails Property { get; set; }
    }
}
