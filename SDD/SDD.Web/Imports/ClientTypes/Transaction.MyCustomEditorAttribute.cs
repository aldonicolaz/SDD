using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace SDD.Transaction
{
    public partial class MyCustomEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "SDD.Transaction.MyCustomEditor";

        public MyCustomEditorAttribute()
            : base(Key)
        {
        }
    }
}

