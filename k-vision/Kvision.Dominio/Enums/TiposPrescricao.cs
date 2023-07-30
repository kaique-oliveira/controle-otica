
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Kvision.Dominio.Enums
{
    public enum TiposPrescricao
    {
        [Description("Longe")]
        [EnumMember(Value = "Longe")]
        Longe = 0,

        [Description("Perto")]
        [EnumMember(Value = "Perto")]
        Perto = 1,

        [Description("Ambos")]
        [EnumMember(Value = "Ambos")]
        Ambos = 2,
    }
}
