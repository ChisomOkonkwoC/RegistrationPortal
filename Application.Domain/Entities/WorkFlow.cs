namespace Application.Domain.Entities
{
    public class WorkFlow : BaseEntity
    {
        public string StageName { get; set; }
        public virtual ICollection<StageType> StageTypes { get; set; }
    }
}