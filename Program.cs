using System;
using System.Collections.Generic;
using System.Collections;

namespace TpObra
{
    class Program
    {
        static void Main(string[] args)
        {

                        // Nuevos ingresantes..
                        Obrero juan = new Obrero("Juan", "Perez", "12345678", 1234, 50000, "Carpintero");
                        Obrero robert = new Obrero("Robert", "Gonzalez", "777", 1234, 222, "Pintor");
                        Obrero rodolfo = new Obrero("Rodolfo", "Caballero", "35", 3135, 555533, "Pintor");
                        GrupoObrero grupo = new GrupoObrero();


                        //Codigo Del grupo
                        Console.WriteLine(grupo.Cod);


                        // empresa grupos

                        // añadir nuevos


                        Empresa reclutar = new Empresa();
                        reclutar.contratarObrero(juan);
                        reclutar.contratarObrero(robert);
                        reclutar.contratarObrero(rodolfo);

          
                    reclutar.getGrupos();


           
        }



    }


}


