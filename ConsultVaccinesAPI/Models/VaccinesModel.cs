using ConsultVaccinesAPI.Enums;

namespace ConsultVaccinesAPI.Models
{
    public class VaccinesModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public VaccinesStatus? Status { get; set; }
        public DateTime? DateApplied { get; set; }
    }
}
