using System.ComponentModel;

namespace Koko.Domain.Models.EnumModels
{
    public enum TipoProduto : byte
    {
        [Description("AÇÃO")]
        Ação = 1,

        [Description("FUN")]
        Fundo = 2,

        [Description("CRI")]
        Criptomoeda = 3,

        [Description("FII")]
        FundoImobiliario = 4,

        [Description("PUB")]
        TituloPublico = 5,

        [Description("OP")]
        Opção = 6,

        [Description("DEB")]
        Debênture = 7,

        [Description("DER")]
        Derivativo = 8,

        [Description("CAI")]
        Caixa = 9
    }
}