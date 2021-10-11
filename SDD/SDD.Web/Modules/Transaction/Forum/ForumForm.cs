
namespace SDD.Transaction.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Transaction.Forum")]
    [BasedOnRow(typeof(Entities.ForumRow), CheckNames = true)]
    public class ForumForm
    {
        [Category("Forum")]
        [LookupEditor("Master.MasterForum")]
        [DisplayName("Jenis Forum"),Width(150)]
        public Int32 IdMasterForum { get; set; }

        //[Visible(false)]
        //public Int32 IdUserInsert { get; set; }
        
        [DisplayName("Detail"), Width(300)]
        [TextAreaEditor]
        public String DetailForum { get; set; }
        [DisplayName("Foto")]
        public String FotoDokumenForum { get; set; }
        [RadioButtonEditor(EnumKey = "Transaction.HideStatus")]
        [Visible (true),Width(150)]
        public Hide HiddenUser { get; set; }

        [Category("Respon Forum")]
        [DetailForumGrid]
        public List<Entities.DetailForumRow> Detail { get; set; }
    }
}