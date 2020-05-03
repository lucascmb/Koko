using System.ComponentModel;

namespace Koko.Domain.Models.EnumModels
{
    public enum Suitability : byte
    {
        [Description("CON")]
        Conservador = 1,

        [Description("MOD")]
        Moderado = 2,

        [Description("AR")]
        Arrojado = 3
    }
}