using System;
using System.Collections.Generic;

class JefeObrero:Obrero{

public decimal Bonificacion { get; set; }

    public JefeObrero(string nombre, string apellido, string dni, int legajo, int sueldo, string cargo, decimal bonificacion)
        : base(nombre, apellido, dni, legajo, sueldo, cargo)
    {
        Bonificacion = bonificacion;
    }

public string getBonificacion(){

    return $"la bonificacion es del {this.Bonificacion} %";


}




}















