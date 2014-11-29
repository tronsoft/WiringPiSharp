// Copyright (c) TRONSoft, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Runtime.InteropServices;

namespace WiringPi.Net
{
    public static class Devices
    {
        [DllImport("libwiringPi.so.2.0", EntryPoint = "mcp23s17Setup")]
        public static extern int Mcp23s17Setup(int pinBase, int spiPort, int devId);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "mcp23017Setup")]
        public static extern int Mcp23017Setup(int pinBase, int i2cAddress);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "mcp23s08Setup")]
        public static extern int Mcp23s08Setup(int pinBase, int spiPort, int devId);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "mcp23008Setup")]
        public static extern int Mcp23008Setup(int pinBase, int i2cAddress);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "sr595Setup")]
        public static extern int sr595Setup(int pinBase, int numPins, int dataPin, int clockPin, int latchPin);
    }
}