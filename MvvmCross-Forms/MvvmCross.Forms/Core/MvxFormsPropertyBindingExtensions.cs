﻿using System;
using MvvmCross.Forms.Views;

namespace MvvmCross.Forms.Core
{
    public static class MvxFormsPropertyBindingExtensions
    {
        public static string BindPartialText(this MvxListView mvxListView)
        => MvxFormsPropertyBinding.MvxListView_ItemClick;
    }
}
