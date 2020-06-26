using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card 
{
    public int coste;
    public bool produccion;
    public bool oro;
    public int ataque;
    public int vida;
    public string nombre;
    public string texto;
    
    public Card(int coste, bool produccion, bool oro, int ataque, int vida, string nombre, string texto)
    {
        this.coste = coste;
        this.produccion = produccion;
        this.oro = oro;
        this.ataque = ataque;
        this.vida = vida;
        this.nombre = nombre;
        this.texto = texto;
    }
    
}
