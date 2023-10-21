using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

//��������� ������ �� Json
public class JSONCardReader
{
    //������ ����� ��� �������� ����, ��� ������ ��������� Json
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
    }

    //������� ��������� �������� (�� ��� � id) �� ����� � ���� ����n��� ������ � ������ 
    public static ReadingCard GetCard(int id, string era) 
    {     
        string path = Application.streamingAssetsPath + "/CardListJSON/" + era + "/" + id.ToString() + ".json";
        ReadingCard getCard = JsonUtility.FromJson<ReadingCard>(File.ReadAllText(path));
        return getCard;
    }
}