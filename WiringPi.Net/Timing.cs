﻿// Copyright (c) TRONSoft, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Runtime.InteropServices;

namespace WiringPi.Net
{
    public static class Timing
    {
        [DllImport("libwiringPi.so.2.0", EntryPoint = "delay")]
        public static extern void Delay(uint howLong);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "delayMicroseconds")]
        public static extern void DelayMicroseconds(uint howLong);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "millis")]
        public static extern uint Millis();

        [DllImport("libwiringPi.so.2.0", EntryPoint = "micros")]
        public static extern uint Micros();
    }
}