using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalCard : BaseCard
{
    int Money { get; set; }
    int Army { get; set; }
    int Religion { get; set; }
    int PeopleEffect { get; set; }

    string Era { get; set; }
    string TextEvent {  get; set; }
    string TextLeft { get; set; }
    string TextRight { get; set; }
    string Background { get; set; }
    string Hero { get; set; }

    public override BaseCard CreateCard(int id)
    {
        throw new System.NotImplementedException(); 
    }

    public override void LeftSolution()
    {
        throw new System.NotImplementedException();
    }

    public override void RightSolution()
    {
        throw new System.NotImplementedException();
    }


    
}
