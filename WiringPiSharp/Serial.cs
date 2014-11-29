// Copyright (c) TRONSoft, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Runtime.InteropServices;

namespace WiringPiSharp
{
    public static class Serial
    {
        [DllImport("libwiringPi.so.2.0", EntryPoint = "serialOpen")]
        public static extern int SerialOpen(string device, int baud);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "serialClose")]
        public static extern void SerialClose(int fd);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "serialFlush")]
        public static extern void SerialFlush(int fd);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "serialPutchar")]
        public static extern void SerialPutchar(int fd, byte c);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "serialPuts")]
        public static extern void SerialPuts(int fd, string message);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "serialPrintf")]
        public static extern void SerialPrintf(int fd, string message, params object[] args);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "serialDataAvail")]
        public static extern int serialDataAvail(int fd);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "serialGetchar")]
        public static extern int SerialGetchar(int fd);
    }
}