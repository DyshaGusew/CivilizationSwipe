using UnityEngine;

//���������� �������� ������� ����
public class MainGameController : MonoBehaviour
{
    //������������� ���������� ����� ����
    static public bool gameOver = false;

    //����� ��� ������������ ����� �������
    static public void ControleAfterBut()
    {
        //����� ����� ��� ��� �������� ������
        if(gameOver == false)
        {
            //���� ����� ������� ��� ��������� ����������, �� �������
            if (MainStorage.Money >= 0 && MainStorage.Army >= 0 && MainStorage.Religion >= 0 && MainStorage.People >= 0)
            {
                //������� ����� �������� � ������������� �� ������ ���� ��� �� ������� �� ������� ������ ���
                if (MainStorage.counterCard != MainStorage.maxCountCardOfThisEra + MainStorage.maxCountCardOfStartEra + MainStorage.maxCountCardOfEndEra + 1)
                {
                    CardConstructor.CreatePlayCardOfBase();
                    TextSetterView.SetTextEvent(MainStorage.thisCard.TextEvent, MainStorage.thisCard.TextHero);
                }
                //���� � ������� ��� ������ ��� ����, �� ������
                else
                {
                    //���� ��� ��������� ���, �� ������ ��������� ����
                    if (MainStorage.era == MainStorage.eras[5])
                    {
                        GameObject.Find("Main Camera").GetComponent<OpenWindowWinOrFail>().AtiveWinMenu();
                        NewGameCreate();  
                    }
                    //������������ ��� � ��������� ��������� ��������(��������� ��� ������ ���)
                    else
                    {
                        string thisEra = MainStorage.era;
                        MainStorage.LoadNormalValue();
                        MainStorage.learning = 1;
                        MainStorage.era = thisEra;
                        //������������ �������� ���
                        for (int i = 0; i < MainStorage.eras.Length; i++)
                        {
                            if (MainStorage.eras[i] == MainStorage.era)
                            {
                                MainStorage.era = MainStorage.eras[i + 1];
                                break;
                            }
                        }
                        //������������ ��� � mainStorage � ��������
                        MainStorage.maxCountCardOfThisEra = System.IO.Directory.GetFiles(Application.streamingAssetsPath + "\\CardListJSON\\" + MainStorage.era + "\\BaseCard\\", "*.json").Length;
                        MainStorage.maxCountCardOfStartEra = System.IO.Directory.GetFiles(Application.streamingAssetsPath + "\\CardListJSON\\" + MainStorage.era + "\\StartCard\\", "*.json").Length;
                        MainStorage.maxCountCardOfEndEra = System.IO.Directory.GetFiles(Application.streamingAssetsPath + "\\CardListJSON\\" + MainStorage.era + "\\EndCard\\", "*.json").Length;
                        MainStorage.counterCard = 1;

                        MainStorage.Save();

                        //������ �������, ����� �������� � ������������ ���������
                        MainStorage.ThisCardMassive = CardConstructor.CardMassSet(MainStorage.era);
                        CardConstructor.CreatePlayCardOfBase();
                        TextSetterView.SetTextEvent(MainStorage.thisCard.TextEvent, MainStorage.thisCard.TextHero);
                        FoneAspectSetter.FoneSet();
                        FoneAspectSetter.AspecSet();
                    }
                }
            }

            //���� ���� �� ���������� ���� �� 0, �� ������ �������� ������, ������������ game over true � ��� ��������� �������� ��������� ���� ���������
            else
            {
                //��������� ����� �������� ������ ��������
                gameOver = true;
                if (MainStorage.Money < 0)
                {
                    CardConstructor.CreatePlayCardOfDied("money");
                }
                else if (MainStorage.Army < 0)
                {
                    CardConstructor.CreatePlayCardOfDied("army");
                }
                else if (MainStorage.Religion < 0)
                {
                    CardConstructor.CreatePlayCardOfDied("religion");
                }
                else if (MainStorage.People < 0)
                {
                    CardConstructor.CreatePlayCardOfDied("people");
                }
                TextSetterView.SetTextEvent(MainStorage.thisCard.TextEvent, MainStorage.thisCard.TextHero); 
            }
        }
        //���� �������� gameOver = true, �� ���������� �������� ��� �������� ������ � ����� �� ����������� ������ ���� ���������
        else
        {
            GameObject.Find("Main Camera").GetComponent<OpenWindowWinOrFail>().AtiveExitMenu();
            NewGameCreate();
        }
        
    }

    //�������� ����� ����, ��� � ����
    static void NewGameCreate()
    {
        gameOver = false;
        MainStorage.LoadNormalValue();
        MainStorage.learning = 1;
        MainStorage.Save();
        MainStorage.ThisCardMassive = CardConstructor.CardMassSet(MainStorage.era);
        CardConstructor.CreatePlayCardOfBase();
        TextSetterView.SetTextEvent(MainStorage.thisCard.TextEvent, MainStorage.thisCard.TextHero);
        AspectGreenRed.AspectLightSol(0,0,0,0);
    }
}
