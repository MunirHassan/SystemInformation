using System;

namespace SystemInformation
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("OS Platform: " + HardwareInfo.GetOSPlatform());
            Console.WriteLine("Processor Id: " + HardwareInfo.GetProcessorId());
            Console.WriteLine("HDDSerial No:  " + HardwareInfo.GetHDDSerialNo());

            Console.WriteLine("MAC Address: " + HardwareInfo.GetMACAddress());
            Console.WriteLine("Board Maker: " + HardwareInfo.GetBoardMaker());
            Console.WriteLine("Board ProductId: " + HardwareInfo.GetBoardProductId());
            Console.WriteLine("Cd Rom Drive:  " + HardwareInfo.GetCdRomDrive());

            Console.WriteLine("BIOS maker: " + HardwareInfo.GetBIOSmaker());
            Console.WriteLine("BIOS ser No: " + HardwareInfo.GetBIOSserNo());
            Console.WriteLine("BIOS caption: " + HardwareInfo.GetBIOScaption());
            Console.WriteLine("Account Name:  " + HardwareInfo.GetAccountName());

            Console.WriteLine("Physical Memory: " + HardwareInfo.GetPhysicalMemory());
            Console.WriteLine("No Ram Slots: " + HardwareInfo.GetNoRamSlots());
            Console.WriteLine("CPU Manufacturer: " + HardwareInfo.GetCPUManufacturer());
            Console.WriteLine("CPU Current Clock Speed:  " + HardwareInfo.GetCPUCurrentClockSpeed());

            Console.WriteLine("Cpu Speed In GHz: " + HardwareInfo.GetCpuSpeedInGHz());
            Console.WriteLine("Current Language: " + HardwareInfo.GetCurrentLanguage());
            Console.WriteLine("OS Information:  " + HardwareInfo.GetOSInformation());

            Console.WriteLine("Processor Information: " + HardwareInfo.GetProcessorInformation());
            Console.WriteLine("Computer Name: " + HardwareInfo.GetComputerName());

            Console.WriteLine("Machine Guid: " + Microsoft.Win32.Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Cryptography", "MachineGuid", null));
            Console.WriteLine("Machine Name With FQDN: " + HardwareInfo.GetMachineNameWithFQDN());

            Console.ReadKey();
        }
    }
}
