using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;

//A class that works with a card as a game model
public class CardConstructor : MonoBehaviour
{
    //A game card on the stage (a specific model with empty properties is taken)
    public static GameObject gameCardModel;

    //Creating a card as a game object
    static public void CreatePlayCardOfBase() 
    {
        //I take the last card I need from the array of cards in the array using the card counter, save it to the storage
        NormalCard infoCard = MainStorage.ThisCardMassive[MainStorage.counterCard-1];     //I install the card through the id number
        MainStorage.thisCard = infoCard;

        //The actual creation
        GameObject newGameCard = Instantiate(gameCardModel, gameCardModel.transform.position, Quaternion.Euler(0, 0, 0));  
        newGameCard.GetComponent<SpriteRenderer>().sprite = LoadSprite(infoCard, "ProfessionIcon");

        //I increase the counter and put the current game card in the vault
        MainStorage.counterCard++;   
        MainStorage.thisGameCard = newGameCard;
    }

    static public void CreatePlayCardOfNext(int idNextCard)
    {
        //I take the last card I need from the array of cards in the array using the card counter, save it to the storage
        NormalCard infoCard = new NormalCard(JSONCardReader.GetCard(idNextCard, MainStorage.era, "NextCard"));     //I install the card through the id number
        MainStorage.thisCard = infoCard;

        //The actual creation
        GameObject newGameCard = Instantiate(gameCardModel, gameCardModel.transform.position, Quaternion.Euler(0, 0, 0));
        newGameCard.GetComponent<SpriteRenderer>().sprite = LoadSprite(infoCard, "ProfessionIcon");

        //I increase the counter and put the current game card in the vault
        MainStorage.thisGameCard = newGameCard;
    }

    //Creation of death cards depending on the aspect transferred to them
    static public void CreatePlayCardOfDied(string diedAspect)
    {
        //Depending on the type of death, I take a card from the resources
        NormalCard infoCard = diedAspect switch
        {
            "money" => new NormalCard(JSONCardReader.GetCard("money", MainStorage.era, "DiedCard")),
            "army" => new NormalCard(JSONCardReader.GetCard("army", MainStorage.era, "DiedCard")),
            "religion" => new NormalCard(JSONCardReader.GetCard("religion", MainStorage.era, "DiedCard")),
            "people" => new NormalCard(JSONCardReader.GetCard("people", MainStorage.era, "DiedCard")),
            _ => throw new System.NotImplementedException(),
        };

        //I install this card in the storage and create it on the stage
        MainStorage.thisCard = infoCard;
        GameObject newGameCard = Instantiate(gameCardModel, gameCardModel.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;  //Собственно создание
        
        newGameCard.GetComponent<SpriteRenderer>().sprite = LoadSprite(infoCard, "DiedIcon");
        MainStorage.thisGameCard = newGameCard;
    }

    //Deleting a card
    static public void DeletePlayCard()
    {
        MainStorage.thisCard = null;
    }

    //Loading a card sprite from resources
    static private Sprite LoadSprite(NormalCard infoCard, string typeCard)
    {
        return Resources.Load<Sprite>("CardSprites/" + infoCard.Era + "/" + typeCard + "/" + infoCard.Image);       
    }

    //Creating an array of cards of the specified era
    public static NormalCard[] CardMassSet(string era)
    {
        //I get the total number of cards
        int countAllCard = MainStorage.maxCountCardOfThisEra + MainStorage.maxCountCardOfStartEra + MainStorage.maxCountCardOfEndEra;

        //An array of all the cards
        NormalCard[] CardMassive = new NormalCard[countAllCard];

        //Arrays of individual cards
        NormalCard[] CardStart = new NormalCard[MainStorage.maxCountCardOfStartEra];  //The initial maps of the era
        NormalCard[] CardBase = new NormalCard[MainStorage.maxCountCardOfThisEra];    //The usual maps of the era
        NormalCard[] CardEnd = new NormalCard[MainStorage.maxCountCardOfEndEra];      //The Ultimate maps of the era

        //I read all the cards and put them in order in specific arrays
        for (int i = 0; i < MainStorage.maxCountCardOfStartEra; i++)
        {                               
            CardStart[i] = new NormalCard(JSONCardReader.GetCard(i+1, era, "StartCard"));
        }

        for (int i = 0; i < MainStorage.maxCountCardOfThisEra; i++)
        {                               
            CardBase[i] = new NormalCard(JSONCardReader.GetCard(i+1, era, "BaseCard"));
        }

        for (int i = 0; i < MainStorage.maxCountCardOfEndEra; i++)
        {                               
            CardEnd[i] = new NormalCard(JSONCardReader.GetCard(i + 1, era, "EndCard"));
        }

        //Shuffling the array with the main cards (they must be randomly arranged)
        for (int g = CardBase.Length - 1; g >= 1; g--)
        {
            int j = new System.Random().Next() % (g + 1);
            (CardBase[g], CardBase[j]) = (CardBase[j], CardBase[g]);
        }

        //Filling in the general array
        int f = 0;
        for(; f < MainStorage.maxCountCardOfStartEra; f++)
        {
            CardMassive[f] = CardStart[f];
        }

        for (int i = 0; i < MainStorage.maxCountCardOfThisEra; f++, i++)
        {
            CardMassive[f] = CardBase[i];
        }

        for (int j = 0; j < MainStorage.maxCountCardOfEndEra; f++, j++)
        {
            CardMassive[f] = CardEnd[j];
        }


        return CardMassive;
    }
}