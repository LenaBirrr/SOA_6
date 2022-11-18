// See https://aka.ms/new-console-template for more information
using SOA_6;

SickPerson sick = new SickPerson();
sick.Name = "Jack";
sick.Virus = "Plague";

IMedication medication = new PlagueMedication();

sick.Recover(medication);

Console.WriteLine("Hello, World!");
