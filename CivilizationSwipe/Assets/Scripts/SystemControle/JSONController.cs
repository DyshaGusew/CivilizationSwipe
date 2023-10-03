using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

//Получение Данных из Json
public class JSONController
{
    public class ReadingCard                //Создаю класс для указания того, что именно считывать Json
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
    }

    public static ReadingCard GetCard(int id, string era) //Получаю указанную карточку (по эре и id) по факту в виде просnого текста в классе 
    {     
        string path = Application.streamingAssetsPath + "/CardListJSON/" + era + "/" + id.ToString() + ".json";   //Путь зависит от эры и id
        ReadingCard getCard = JsonUtility.FromJson<ReadingCard>(File.ReadAllText(path));
        return getCard;
    }
}
