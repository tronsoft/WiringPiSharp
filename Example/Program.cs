using System.Threading;

using WiringPiSharp;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Setup.WiringPiPiSetupGpio();
            GPIO.PinMode(18, WiringPi.Output);
            while (true)
            {
                GPIO.DigitalWrite(18, WiringPi.High);
                Thread.Sleep(500);
                GPIO.DigitalWrite(18, WiringPi.Low);
                Thread.Sleep(500);
            }
        }
    }
}
