using System;
using System.Collections.Generic;

public class Obrero : Persona
{
    public int Legajo { get; set; }
    public int Sueldo { get; set; }
    public string Cargo { get; set; }

    public Obrero(string nombre, string apellido, string dni, int legajo, int sueldo, string cargo)
        : base(nombre, apellido, dni)
    {
        
        this.Legajo = legajo;
        this.Sueldo = sueldo;
        this.Cargo = cargo;
    }

    public string GetData()
    {
        return $"El nombre es {this.Nombre}\n" +
               $"El apellido es {this.Apellido}\n" +
               $"El DNI es {this.Dni}\n" +
               $"El legajo es {this.Legajo}\n" +
               $"El sueldo es {this.Sueldo}\n" +
               $"El cargo es {this.Cargo}\n";
    }
}








