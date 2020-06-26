using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Deck
{
    public List<Card> deck= new List<Card>();
    public Deck(int[] ids, List<Card> database){
        for (int i = 0; i < ids.Length; i++)
        {
            deck.Add(database[ids[i]]);
        }
    }

    public void barajar(){
        List<Card> novo= new List<Card>();
        int length=this.deck.Count;
        for (int i = 0; i < length; i++)
        {
            int num = Random.Range(0,this.deck.Count-1);
            novo.Add(this.deck[num]);
            this.deck.Remove(this.deck[num]);
        }
        this.deck=novo;
    }
}
