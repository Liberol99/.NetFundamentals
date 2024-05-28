namespace EntityLayer.Abstract
{
    public interface IEntity
    {
        public long RecId { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool InUse { get; set; }
    }
}