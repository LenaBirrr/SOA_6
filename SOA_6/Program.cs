// See https://aka.ms/new-console-template for more information
using SOA_6;

SickPerson sick = new SickPerson();
sick.Name = "Jack";
sick.Virus = "Plague";

PlagueMedication medication = new PlagueMedication();
PlagueMedication medication1 = new ColdMedication();

sick.Recover(medication);
sick.Recover(medication1);


