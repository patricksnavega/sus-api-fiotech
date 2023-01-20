using System.ComponentModel;

namespace ConsultVaccinesAPI.Enums
{
    public enum VaccinesStatus
    {
        [Description("Applyed")]
        applyed = 1,
        [Description("Not applyed")]
        notApplyed = 2,
    }
}
