using System;
using System.Collections.Generic;
using System.Linq;

class PcCatalog
{
    static void Main()
    {
        Componet boxPC = new Componet(name: "Case Shenha V6", price: 55.20m, details: "Dimmensions: 475 x 185 x 465 cm");
        Componet motherboard = new Componet(name: "Motherboard ASROCK FM2A88X Extreme6+", price: 188.40m);
        Componet hdd = new Componet(name: "HDD SEAGATE 2T, ES.3, SATA III", price: 330m, details: "Size: 2 TB");
        Componet procesor = new Componet(name: "CPU Intel Core I3-4340", price: 316.80m);
        Componet graficsCard = new Componet(name: "GPU PALIT GeForce GT 610", price: 80.40m, details: "Size: 1 GB");
        Componet ram = new Componet(name: "RAM ADATA 2X4GB", price: 171.60m, details: "Descr: 2X4G DDR3");

        Componet discSSD = new Componet(name: "Drive A-DATA 128GB SSD", price: 127.20m, details: "Descr: Multi-Level Cell (MLC) NAND Flash Memory, 2.5 inch");
        Componet blower = new Componet(name: "Fan COOLERMASTER Blade Master 80", price: 16.80m);
        Componet power = new Componet(name: "PSU FD 750W INTEGRA BLACK", price: 157.20m, details: "Descr: Multi-Level Cell (MLC) NAND Flash Memory, 2.5 inch");



        Computer computer1 = new Computer(
            name: "Frankenstein",
            boxPC: boxPC,
            motherboard: motherboard,
            hdd: hdd,
            procesor: procesor,
            graficsCard: graficsCard,
            ram: ram
        );

        Computer computer2 = new Computer("The machine", boxPC, motherboard, hdd, procesor, graficsCard, ram, discSSD, blower, power);

        Computer computer3 = new Computer("SbirotakModel", boxPC, motherboard, hdd, procesor, graficsCard, ram, discSSD);

        List<Computer> computers = new List<Computer>() { computer2, computer1, computer3, computer1 };


        computers = computers.OrderBy(computer => computer.Price).ToList();

        foreach (var computer in computers)
        {
            computer.writeToConsole();
            Console.WriteLine();
        }

    }
}
