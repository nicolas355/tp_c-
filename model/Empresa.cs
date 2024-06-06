using System;
using System.Collections.Generic;

class Empresa{

public  List<Obrero> listaempresa;
public List<GrupoObrero> listagrupo;


 public Empresa()
    {
        listaempresa = new List<Obrero>();
        listagrupo = new List<GrupoObrero>();


// crear grupos
 for (int i = 0; i < 8; i++)
        {
            listagrupo.Add(new GrupoObrero());
        }
       

   

    }
    
     


    public void contratarObrero(Obrero unObrero)
    {
         listaempresa.Add(unObrero);
  foreach (var grupo in listagrupo)
        {
            if (grupo.Cod == 0) 
            {
                grupo.Integrantes.Add(unObrero);
                Console.WriteLine($"{unObrero.Nombre}  fue asignado al grupo sin asignar (código 0)");
                return;
            }
  
    }

        Console.WriteLine("No hay grupos libres para asignar al obrero.");


    }

    public void getGrupos()
{
    foreach (var grupo in listagrupo)
    {
        Console.WriteLine($"Código del grupo: {grupo.Cod}");
        Console.WriteLine("Integrantes del grupo:");
        foreach (var obrero in grupo.Integrantes)
        {
            Console.WriteLine($"Nombre: {obrero.Nombre}, Apellido: {obrero.Apellido}");
        }
    }
}



  }
    


