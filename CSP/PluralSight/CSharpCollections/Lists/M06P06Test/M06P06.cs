using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSP.PluralSight.CSharpCollections.Lists.M06P06Test
{
    /// <summary>
    /// A list of strings where each string is guaranteed to have a 
    /// non-blank character in it
    /// </summary>
    class M06P06 : Collection<string>
    {
        protected override void InsertItem(int index, string item)
        {
            if (String.IsNullOrWhiteSpace(item))
                throw new ArgumentException("Elements of NonBlankStringList must not be" +
                                            "null or whitespace");
            base.InsertItem(index, item);
        }

        protected override void SetItem(int index, string item)
        {
            if (String.IsNullOrWhiteSpace(item))
                throw new ArgumentException("Elements of NonBlankStringList must not be" +
                                            "null or whitespace");
            base.SetItem(index, item);
        }
    }
}
