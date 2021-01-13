using Domain.Common;
using Domain.Enums;

namespace Domain.Entities
{
    public class JobApplication
        : AuditableEntity
    {
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public string Company { get; set; }
        public string City { get; set; }
        public AmericanState State { get; set; }
        public int Salary { get; set; }
        public PipelineStage Stage { get; set; } = PipelineStage.Prospect;
    }
}