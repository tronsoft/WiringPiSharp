// Copyright (c) TRONSoft, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Runtime.InteropServices;

namespace WiringPi.Net
{
    public static class Setup
    {
        [DllImport("libwiringPi.so.2.0", EntryPoint = "wiringPiSetup")]
        public static extern int WiringPiPiSetup();

        [DllImport("libwiringPi.so.2.0", EntryPoint = "wiringPiSetupSys")]
        public static extern int WiringPiPiSetupSys();

        [DllImport("libwiringPi.so.2.0", EntryPoint = "wiringPiSetupGpio")]
        public static extern int WiringPiPiSetupGpio();

        [DllImport("libwiringPi.so.2.0", EntryPoint = "wiringPiSetupPhys")]
        public static extern int WiringPiPiSetupPhys();

        [DllImport("libwiringPi.so.2.0", EntryPoint = "piFaceSetup")]
        public static extern int PiFaceSetup(int pinbase);
    }
}