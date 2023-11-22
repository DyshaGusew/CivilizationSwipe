using static JSONCardReader;

//��� ��� �������(�� �����������, �����, �������, ������� �� �������) �������� �� ���������� � �������� 
public class NormalCard : BaseCard       
{
    public int MoneyL { get; set; }
    public int ArmyL { get; set; }
    public int ReligionL { get; set; }
    public int PeopleEffectL { get; set; }

    public int MoneyR { get; set; }
    public int ArmyR { get; set; }
    public int ReligionR { get; set; }
    public int PeopleEffectR { get; set; }

    public string ImageHero { get; set; }
    public string TextHero { get; set; }

    //����������� �����, ��������� ����� ����� �� ����������� JSON �����
    public NormalCard(ReadingCard ReadCard)    
    {
        TextEvent = ReadCard.TextEvent; 

        TextLeft = ReadCard.TextLeft;
        MoneyL = ReadCard.MoneyL;
        ArmyL = ReadCard.ArmyL;
        ReligionL = ReadCard.ReligionL;
        PeopleEffectL = ReadCard.PeopleEffectL;

        TextRight = ReadCard.TextRight;
        MoneyR = ReadCard.MoneyR;
        ArmyR = ReadCard.ArmyR;
        ReligionR = ReadCard.ReligionR;
        PeopleEffectR = ReadCard.PeopleEffectR;

        Era = ReadCard.Era;
        Image = ReadCard.ImageHero;
        TextHero = ReadCard.TextHero;
    }

    //������������ ���� ����� �������� � ����������� �� ���������� ��������
    public void DownloadNormalCard(NormalCard ReadCard)
    { 
        TextEvent = ReadCard.TextEvent;

        TextLeft = ReadCard.TextLeft;
        MoneyL = ReadCard.MoneyL;
        ArmyL = ReadCard.ArmyL;
        ReligionL = ReadCard.ReligionL;
        PeopleEffectL = ReadCard.PeopleEffectL;

        TextRight = ReadCard.TextRight;
        MoneyR = ReadCard.MoneyR;
        ArmyR = ReadCard.ArmyR;
        ReligionR = ReadCard.ReligionR;
        PeopleEffectR = ReadCard.PeopleEffectR;

        Era = ReadCard.Era;
        Image = ReadCard.ImageHero;
        TextHero = ReadCard.TextHero;
    }

    //����� ������ � ���� �������� ���������, �� ������������ �� �������� � ����������� �� ������� �������� �� ������� � ���
    private void OnEnable()
    {   
        DownloadNormalCard(MainStorage.thisCard);
    }
}
