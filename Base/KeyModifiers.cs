using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlwysClick.Base
{
    [Flags()]
    public enum KeyModifiers
    {
        None = 0,
        Alt = 1,
        Ctrl = 2,
        Shift = 4,
        WindowsKey = 8
    }
}
