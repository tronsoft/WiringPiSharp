// Copyright (c) TRONSoft, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Runtime.InteropServices;

namespace WiringPi.Net
{
    public static class GPIO
    {
        [DllImport("libwiringPi.so.2.0", EntryPoint = "pinMode")]
        public static extern void PinMode(int pin, int mode);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "pullUpDnControl")]
        public static extern void PullUpDnControl(int pin, int pud);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "digitalRead")]
        public static extern int DigitalRead(int pin);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "digitalWrite")]
        public static extern void DigitalWrite(int pin, int value);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "pwmWrite")]
        public static extern void PwmWrite(int pin, int value);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "analogRead")]
        public static extern int AnalogRead(int pin);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "analogWrite")]
        public static extern void AnalogWrite(int pin, int value);
    }
}