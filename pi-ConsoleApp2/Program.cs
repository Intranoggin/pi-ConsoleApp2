using System.Device.Gpio;
using System.Threading;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("VS - Hello, World!");

GpioController controller = new GpioController(PinNumberingScheme.Board);

var pin = 5;
var lightTime = 300;

controller.OpenPin(pin, PinMode.Output);

try
{
    while (true)
    {
        controller.Write(pin, PinValue.High);
        Thread.Sleep(lightTime);
        controller.Write(pin, PinValue.Low);
        Thread.Sleep(lightTime);
    }
}
finally
{
    controller.ClosePin(pin);
}