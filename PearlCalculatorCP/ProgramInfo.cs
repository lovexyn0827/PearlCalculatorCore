﻿using System;
using System.Diagnostics;
using System.Reflection;

#nullable disable

namespace PearlCalculatorCP
{
    public static class ProgramInfo
    {
        public static readonly string Version;

        public static string Title => $"PearlCalculator v{Version}";

        public static readonly string BaseDirectory;

        static ProgramInfo()
        {
            Version = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyFileVersionAttribute>().Version;
            BaseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        }
    }
}
