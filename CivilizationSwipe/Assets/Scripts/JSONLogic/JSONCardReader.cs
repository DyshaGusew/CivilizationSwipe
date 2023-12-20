using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

//Getting card data from Json
public class JSONCardReader
{
    //Creating a class to specify exactly what to read Json
    public class ReadingCard                
    {
        public string TextEvent;
        public string TextLeft;

        public int MoneyL;
        public int ArmyL;
        public int ReligionL;
        public int PeopleEffectL;
        public int NextCardL;

        public string TextRight;
        public int MoneyR;
        public int ArmyR;
        public int ReligionR;
        public int PeopleEffectR;
        public int NextCardR;

        public string Era;
        public string ImageHero;
        public string TextHero;
    }

    //I receive the specified card (by era, id and type (initial, regular, final))
    //in fact, in the form of a simple text in the classroom
    public static ReadingCard GetCard(int id, string era, string typeCard) 
    {     
        string path = Application.streamingAssetsPath + "/CardListJSON/" + era + "/" + typeCard + "/" + id.ToString() + ".json";
        ReadingCard getCard = JsonUtility.FromJson<ReadingCard>(File.ReadAllText(path));
        return getCard;
    }

    //I receive the specified card (by era, name and type (initial, regular, final))
    //in fact, in the form of a simple text in the classroom
    public static ReadingCard GetCard(string name, string era, string typeCard)
    {
        string path = Application.streamingAssetsPath + "/CardListJSON/" + era + "/" + typeCard + "/" + name + ".json";
        ReadingCard getCard = JsonUtility.FromJson<ReadingCard>(File.ReadAllText(path));
        return getCard;
    }
}
