namespace Output_Devices
{
    interface IPrintInformation
    {
        public string GetName();
        public void Print(string data);
    }
    class Printer : IPrintInformation
    {
        public string GetName() => "Printer";
        public void Print(string data) => Console.WriteLine($"Printed \"{data}\"!");
    }
    class Monitorr : IPrintInformation
    {
        public string GetName() => "Monitor";
        public void Print(string data) => Console.WriteLine($"\"{data}\" - showed on screen!");
    }
}