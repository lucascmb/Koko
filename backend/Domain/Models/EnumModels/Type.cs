using System.ComponentModel;

namespace Koko.Domain.Models.EnumModels
{
    public enum Type : byte
    {
        [Description("PROD")]
        Products = 1,

        [Description("ESP")]
        Especialist = 2,
    }
}