﻿// Copyright (c) TRONSoft, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Runtime.InteropServices;

namespace WiringPiSharp
{
    public static class WiringPi
    {
        public const int Input = 0;
        public const int Output = 1;
        public const int PwmOutput = 2;
        public const int GpioClock = 3;
        public const int Low = 0;
        public const int High = 1;
        public const int PudOff = 0;
        public const int PudDown = 1;
        public const int PudUp = 2;
        public const int PwmModeMs = 0;
        public const int PwmModeBal = 1;
        public const int IntEdgeSetup = 0;
        public const int IntEdgeFalling = 1;
        public const int IntEdgeRising = 2;
        public const int IntEdgeBoth = 3;
        public const int Lsbfirst = 0;
        public const int Msbfirst = 1;

        [DllImport("libwiringPi.so.2.0", EntryPoint = "piBoardRev")]
        public static extern int PiBoardRev();

        [DllImport("libwiringPi.so.2.0", EntryPoint = "wpiPinToGpio")]
        public static extern int WPIPinToGPIO(int wpiPin);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "setPadDrive")]
        public static extern void SetPadDrive(int group, int value);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "getAlt")]
        public static extern int GetAlt(int pin);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "digitalWriteByte")]
        public static extern void DigitalWriteByte(int value);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "pwmSetMode")]
        public static extern void PwmSetMode(int mode);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "pwmSetRange")]
        public static extern void PwmSetRange(uint range);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "pwmSetClock")]
        public static extern void PwmSetClock(int divisor);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "gpioClockSet")]
        public static extern void GpioClockSet(int pin, int freq);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "piHiPri")]
        public static extern int PiHiPri(int pri);
    }
}