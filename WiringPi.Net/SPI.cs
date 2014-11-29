﻿// Copyright (c) TRONSoft, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Runtime.InteropServices;

namespace WiringPi.Net
{
    public static class SPI
    {
        [DllImport("libwiringPi.so.2.0", EntryPoint = "wiringPiSPIGetFd")]
        public static extern int WiringPiPiSPIGetFd(int channel);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "wiringPiSPIDataRW")]
        public static extern int WiringPiPiSPIDataRW(int channel, HandleRef handle);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "wiringPiSPISetup")]
        public static extern int WiringPiPiSPISetup(int channel, int speed);
    }
}