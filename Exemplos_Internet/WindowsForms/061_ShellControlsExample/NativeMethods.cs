﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace ShellControlsExample
{
  class NativeMethods
  {
    [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
    public extern static int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);
  }
}