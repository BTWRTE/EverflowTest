namespace DAL.Models
{
    public class BaseEntityModel
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public bool IsDeleted { get; set; }

        public ApplicationUserModel? CreatedByUser { get; set; }
        public ApplicationUserModel? LastModifiedByUser { get; set; }
    }
}