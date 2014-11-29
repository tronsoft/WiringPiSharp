// Copyright (c) TRONSoft, Inc. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Runtime.InteropServices;

namespace WiringPi.Net
{
    public static class Interrupts
    {
        [DllImport("libwiringPi.so.2.0", EntryPoint = "waitForInterrupt")]
        public static extern int waitForInterrupt(int pin, int timeout);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "wiringPiISR")]
        public static extern int WiringPiPiISR(int pin, int mode, Action method);
    }
}