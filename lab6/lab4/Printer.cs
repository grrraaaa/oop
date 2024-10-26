
namespace lab4
{
    class Printer : Device
    {
        public int PrintSpeed { get; set; }

        public override string ToString() => $"{base.ToString()}, PrintSpeed: {PrintSpeed}";

        public virtual void Print() => Console.WriteLine("Printing...");
    }
}
