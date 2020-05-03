using System.ComponentModel;

namespace Koko.Domain.Models.EnumModels
{
    public enum TipoContato : byte
    {
        [Description("EMA")]
        Email = 1,

        [Description("TEL")]
        Telephone = 2,

        [Description("SOC")]
        SocialMedia = 3
    }
}