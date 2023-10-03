using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

//��������� ������ �� Json
public class JSONController
{
    public class ReadingCard                //������ ����� ��� �������� ����, ��� ������ ��������� Json
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

    public static ReadingCard GetCard(int id, string era) //������� ��������� �������� (�� ��� � id) �� ����� � ���� ����n��� ������ � ������ 
    {     
        string path = Application.streamingAssetsPath + "/CardListJSON/" + era + "/" + id.ToString() + ".json";   //���� ������� �� ��� � id
        ReadingCard getCard = JsonUtility.FromJson<ReadingCard>(File.ReadAllText(path));
        return getCard;
    }
}
