using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

//Получение данных из Json
public class JSONCardReader
{
    //Создаю класс для указания того, что именно считывать Json
    public class ReadingCard                
    {
        public string TextEvent;
        public string TextLeft;

        public int MoneyL;
        public int ArmyL;
        public int ReligionL;
        public int PeopleEffectL;

        public string TextRight;
        public int MoneyR;
        public int ArmyR;
        public int ReligionR;
        public int PeopleEffectR;

        public string Era;
        public string ImageHero;
        public string TextHero;
    }

    //Получаю указанную карточку (по эре и id) по факту в виде просnого текста в классе 
    public static ReadingCard GetCard(int id, string era, string typeCard) 
    {     
        string path = Application.streamingAssetsPath + "/CardListJSON/" + era + "/" + typeCard + "/" + id.ToString() + ".json";
        ReadingCard getCard = JsonUtility.FromJson<ReadingCard>(File.ReadAllText(path));
        return getCard;
    }

    public static ReadingCard GetCard(string name, string era, string typeCard)
    {
        string path = Application.streamingAssetsPath + "/CardListJSON/" + era + "/" + typeCard + "/" + name + ".json";
        ReadingCard getCard = JsonUtility.FromJson<ReadingCard>(File.ReadAllText(path));
        return getCard;
    }
}
