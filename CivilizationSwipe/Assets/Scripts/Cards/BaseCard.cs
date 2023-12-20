using UnityEngine;

//The base class from which all other card classes are inherited (if any)
public abstract class BaseCard : MonoBehaviour    
{
    //All these parameters should be in any card
    public string TextEvent { get; set; } 
    
    public string TextLeft { get; set; }
    public string TextRight { get; set; }

    public string Era { get; set; }
}
