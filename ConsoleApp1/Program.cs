using Disks;
using Output_Devices;

namespace _06_interfaces
{
    internal class Program
    {
        class Comp
        {
            private List<Disk> disks;
            private List<IPrintInformation> outputDevices;
            public Comp(List<Disk> disks, List<IPrintInformation> outputDevices)
            {
                this.disks = disks;
                this.outputDevices = outputDevices;
            }

            public void AddDisk(Disk disk) => disks.Add(disk);
            public void AddOutputDevice(IPrintInformation outputDevice) => outputDevices.Add(outputDevice);
            public bool CheckDisk(Disk disk) => disks.Contains(disk);
            public void InsertReject(Disk disk)
            {
                if (!disks.Contains(disk))
                    disks.Add(disk);
                else
                    disks.Remove(disk);
            }
            public void PrintInfo(string text, IPrintInformation outputDevice) => outputDevice.Print(text);
            public void ReadInfo(Disk disk) => disk.Read();
            public void ShowDisk() => disks.ForEach((i) => Console.WriteLine($"Name: {i.GetName}\nMemory size: {i.MemSize}"));
            public void ShowOutputDevice() => outputDevices.ForEach((i) => Console.WriteLine($"Name: {i.GetName}"));
        }
        static void Main()
        {
            HDD hdd = new HDD()
            {
                Memory = "0110101010001",
                MemSize = 250
            };
            DVD dvd = new DVD()
            {
                Memory = "110011010",
                MemSize = 5
            };
            Printer printer = new Printer();
            Monitorr monitor = new Monitorr();

            List<Disk> disks = new List<Disk>
            {
                hdd, dvd
            };
            List<IPrintInformation> outputDevices = new List<IPrintInformation>
            {
                printer, monitor
            };

            Comp computer = new Comp(disks, outputDevices);
            computer.PrintInfo("123", outputDevices[0]);
        }
    }
}