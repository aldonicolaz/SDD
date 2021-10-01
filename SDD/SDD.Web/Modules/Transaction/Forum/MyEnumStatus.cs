using Serenity.ComponentModel;
using System.ComponentModel;


namespace SDD.Transaction
{
    [EnumKey("Transaction.MyEnumStatus")]
    public enum MyEnumStatus
    {
        Hidden = 1,
        Show = 0
    }
}