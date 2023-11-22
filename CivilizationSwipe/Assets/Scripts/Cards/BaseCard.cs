using UnityEngine;

//Базовый класс от которого наследуются все остальные классы карточек (если они будут)
public abstract class BaseCard : MonoBehaviour    
{
    //Все эти прараметры должны быть в любой карточке
    public string TextEvent { get; set; } 
    
    public string TextLeft { get; set; }
    public string TextRight { get; set; }

    public string Era { get; set; }
    public string Image { get; set; }
}
