// Copyright (c) TRONSoft, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Runtime.InteropServices;

namespace WiringPi.Net
{
    public static class Lcd
    {
        [DllImport("libwiringPi.so.2.0", EntryPoint = "lcdHome")]
        public static extern void LcdHome(int fd);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "lcdClear")]
        public static extern void LcdClear(int fd);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "lcdSendCommand")]
        public static extern void LcdSendCommand(int fd, byte command);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "lcdPosition")]
        public static extern void LcdPosition(int fd, int x, int y);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "lcdPutchar")]
        public static extern void LcdPutchar(int fd, byte data);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "lcdPuts")]
        public static extern void LcdPuts(int fd, string message);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "lcdPrintf")]
        public static extern void LcdPrintf(int fd, string message, params object[] args);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "lcdInit")]
        public static extern int LcdInit(int rows, int cols, int bits, int rs, int strb, int d0, int d1, int d2, int d3, int d4, int d5, int d6, int d7);
    }
}