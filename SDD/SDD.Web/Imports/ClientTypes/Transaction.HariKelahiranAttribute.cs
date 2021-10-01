﻿using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace SDD.Transaction
{
    public partial class HariKelahiranAttribute : CustomEditorAttribute
    {
        public const string Key = "SDD.Transaction.HariKelahiran";

        public HariKelahiranAttribute()
            : base(Key)
        {
        }
    }
}

