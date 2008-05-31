﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace NAudio.Dmo
{
    static class DmoInterop
    {
        [DllImport("msdmo.dll")]
        public static extern int DMOEnum(
            [In] ref Guid guidCategory,
            DmoEnumFlags flags,
            int inTypes,
            [In] DmoPartialMediaType[] inTypesArray,
            int outTypes,
            [In] DmoPartialMediaType[] outTypesArray,
            out IEnumDmo enumDmo);

    }
}
