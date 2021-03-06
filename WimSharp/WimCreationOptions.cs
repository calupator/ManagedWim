﻿using System;
using JCotton.WimSharp.Interop;

namespace JCotton.WimSharp {
    [Flags]
    public enum WimCreationOptions : uint {
        Verify = NativeMethods.WIM_FLAG_VERIFY,
        ShareWrite = NativeMethods.WIM_FLAG_SHARE_WRITE
    }
}
