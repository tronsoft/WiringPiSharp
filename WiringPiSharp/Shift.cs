// Copyright (c) TRONSoft, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Runtime.InteropServices;

namespace WiringPiSharp
{
    public static class Shift
    {
        [DllImport("libwiringPi.so.2.0", EntryPoint = "shiftOut")]
        public static extern void ShiftOut(byte dPin, byte cPin, byte order, byte val);

        [DllImport("libwiringPi.so.2.0", EntryPoint = "shiftIn")]
        public static extern byte ShiftIn(byte dPin, byte cPin, byte order);
    }
}