// Copyright (c) TRONSoft, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Runtime.InteropServices;

namespace WiringPi.Net
{
    public static class SoftPwm
    {
        [DllImport("libwiringPi.so.2.0", EntryPoint = "softPwmCreate")]
        public static extern int SoftPwmCreate(int pin, int value, int range);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "softPwmWrite")]
        public static extern void SoftPwmWrite(int pin, int value);
    }
}