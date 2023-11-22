using static JSONCardReader;

//Это уже обычная(их большинство, герой, событие, влияние на аспекты) карточка со значениями и методами 
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

    //Конструктор карты, создающий новую карту из считываемой JSON карты
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

    //Устанавливаю этой карте значение в зависимосте от переданной карточки
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

    //Когда объект с этим скриптом создается, то устанавливаю ей значения в зависимости от текущей карточки из массива и эры
    private void OnEnable()
    {   
        DownloadNormalCard(MainStorage.thisCard);
    }
}
