
namespace SDD.Transaction.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Transaction.ParentMessage")]
    [BasedOnRow(typeof(Entities.ParentMessageRow), CheckNames = true)]
    public class ParentMessageForm
    {   

        [Category("Broadcast")]
        [HalfWidth]
        public String Title { get; set; }
        [RadioButtonEditor(EnumKey = "Transaction.EnumSend")]
        public Send Option1 { get; set; }
        [Visible(false)]
        public String Message { get; set; }
        [TextAreaEditor(Rows = 7 ,Cols = 7)]
       
        public String Body { get; set; }
        [Category("Detail Broadcast")]
        [FcmMessageGrid]
        public List<Entities.FcmMessageRow> Detail { get; set; }
        //public DateTime TimeStamp { get; set; }
    }
}