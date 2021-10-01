


using Serenity.ComponentModel;
using System.ComponentModel;

namespace SDD.Transaction
{
    [EnumKey("Transaction.GetTrackStatus")]
    public enum GetTrackStatus
    {
        [Description("Show")]
        Show = 0,
        [Description("Hidden")]
        Hidden = 1
        

    }
}