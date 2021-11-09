﻿using System;
using System.Collections.Generic;

namespace Employe
{
    class Program
    {
        static void Main(string[] args)
        {
            Employes bruno = new Employes("Bruno", "MAYEUX", new DateTime(2000, 10, 15), "Chef de projet", 45500, "Front-End");
            Employes pierre = new Employes("Pierre", "COURQUIN", new DateTime(2020, 5, 1), "Developpeur", 67500, "Front-End");
            Employes martine = new Employes("Martine", "POIX", new DateTime(2021, 11, 01), "Stagiaire", 0, "Café");
            Employes quentin = new Employes("Quentin", "BALAIR", new DateTime(2017, 02, 15), "Developpeur", 0, "Back-End");
            Employes maxence = new Employes("Maxence", "THACKER", new DateTime(2021, 11, 01), "Stagiaire", -1000, "Menage");

            Console.WriteLine(bruno.Prime());

            List<Employes> listeEmployes = new List<Employes>()
            {
            bruno,
            pierre };
            listeEmployes.Add(martine);
            listeEmployes.Add(quentin);
            listeEmployes.Add(maxence);

            Console.WriteLine("Nombre d'employer dans la societe : " + listeEmployes.Count);

            listeEmployes.Sort(Employes.Classement);
        }
    }
}
