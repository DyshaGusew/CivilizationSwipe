using static JSONCardReader;

//This is already a common (most of them, the hero, the event, the impact on aspects)
//card with values and methods
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

    //A map constructor that creates a new map from a readable JSON map
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

    //I set the value of this card depending on the transferred card
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

    //When an object with this script is created, I set its values depending on
    //the current card from the array and the era
    private void OnEnable()
    {   
        DownloadNormalCard(MainStorage.thisCard);
    }
}
