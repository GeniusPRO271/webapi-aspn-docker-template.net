namespace BackEndProject.Data.Models
{
    public interface IBaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreateDateTime { get; set; }

        public DateTime ModifyDateTime { get; set; }

        public DateTime? DeleteDate { get; set; }
    }
}
