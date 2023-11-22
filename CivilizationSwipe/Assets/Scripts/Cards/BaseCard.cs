using UnityEngine;

//������� ����� �� �������� ����������� ��� ��������� ������ �������� (���� ��� �����)
public abstract class BaseCard : MonoBehaviour    
{
    //��� ��� ���������� ������ ���� � ����� ��������
    public string TextEvent { get; set; } 
    
    public string TextLeft { get; set; }
    public string TextRight { get; set; }

    public string Era { get; set; }
    public string Image { get; set; }
}
