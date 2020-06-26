using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Database
{
    public List<Card> database= new List<Card>();
    public Database(){
        this.database.Add(new Card(1,true,false,1,1,"Campesino",""));
    }
}
