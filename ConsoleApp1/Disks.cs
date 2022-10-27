namespace Disks
{
    interface IRemoveableDisk
    {
        public bool HardDisk { get; }
        public void Insert();
        public void Reject();
    }
    interface IDisk
    {
        public void Read();
        public void Write(string data);
    }
    class Disk : IDisk
    {
        private string memory;
        private int memSize;

        public string Memory { 
            get
            {
                return memory;
            }
            set
            {
                if (value != null)
                    memory = value;
            }
        }
        public int MemSize
        {
            get
            {
                return memSize;
            }
            set
            {
                if (value > 0)
                    memSize = value;
            }
        }
        public Disk()
        {
            memory = "SSD";
            memSize = 1000;
        }
        public Disk(string memory, int memSize)
        {
            this.memory = memory;
            this.memSize = memSize;
            Memory = memory;
            MemSize = memSize;
        }
        public virtual string GetName() => memory;
        public void Read() => Console.WriteLine("Reading data from disk...");
        public void Write(string data) => Console.WriteLine($"Data \"{data}\" has been written to memory!");
        public override string ToString() => $"Memory: {memory}\nMemory size: {memSize} GB";
    }
    class HDD : Disk
    {
        public override string GetName() => "HDD";
    }
    class CD : Disk, IRemoveableDisk
    {
        private bool hasDisk;
        public bool HasDisk
        {
            get => hasDisk;
        }
        public bool HardDisk { get; } = false;
        public override string GetName() => "CD";
        public void Insert()
        {
            hasDisk = true;
            Console.WriteLine("CD inserted!");
        }
        public void Reject()
        {
            hasDisk = false;
            Console.WriteLine("CD rejected!");
        }
        public override string ToString() => hasDisk ? "There is inserted CD!" : "There is not inserted CD!";
    }
    class DVD : Disk, IRemoveableDisk
    {
        private bool hasDisk;
        public bool HasDisk {
            get
            {
                return hasDisk;
            }
        }
        public bool HardDisk { get; } = false;
        public override string GetName() => "DVD";
        public void Insert()
        {
            hasDisk = true;
            Console.WriteLine("DVD inserted!");
        }
        public void Reject()
        {
            hasDisk = false;
            Console.WriteLine("DVD rejected!");
        }
        public override string ToString() => hasDisk ? "There is inserted DVD!" : "There is not inserted DVD!";
    }
    class Flash : Disk, IRemoveableDisk
    {
        private bool hasDisk;
        public bool HasDisk
        {
            get
            {
                return hasDisk;
            }
        }
        public bool HardDisk { get; } = false;
        public override string GetName() => "Flash";
        public void Insert()
        {
            hasDisk = true;
            Console.WriteLine("Flash inserted!");
        }
        public void Reject()
        {
            hasDisk = false;
            Console.WriteLine("Flash rejected!");
        }
        public override string ToString() => hasDisk ? "There is inserted flash!" : "There is not inserted flash!";
    }
}