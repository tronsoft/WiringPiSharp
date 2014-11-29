// Copyright (c) TRONSoft, Inc. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Runtime.InteropServices;

namespace WiringPiSharp
{
    public static class Threads
    {
        [DllImport("libwiringPi.so.2.0", EntryPoint = "piThreadCreate")]
        public static extern int PiThreadCreate([MarshalAs(UnmanagedType.FunctionPtr)] Action<IntPtr> method);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "piLock")]
        public static extern void PiLock(int key);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "piUnlock")]
        public static extern void PiUnlock(int key);
    }
}