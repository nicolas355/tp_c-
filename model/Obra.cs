using System;
using System.Collections.Generic;


class Obra{


public string Nombre{get;set;}

public int Dni {get;set;}
public int Codigo{get;set;}
public string Tipo{get;set;}
public double Estado{get;set;}

public Obrero Jefe{get;set;}

public decimal Costo{get;set;}



public Obra(string nombre,int dni,int codigo,string tipo,double estado,Obrero jefe,decimal costo){

    this.Nombre=nombre;
    this.Dni=dni;
    this.Codigo=codigo;
    this.Tipo=tipo;
    this.Estado=estado;
    this.Jefe=jefe;
    this.Costo=costo;




}














}

