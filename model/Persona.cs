using System;
using System.Collections.Generic;

public class Persona
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Dni { get; set; }

    public Persona(string nombre, string apellido, string dni)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Dni = dni;
    }
}