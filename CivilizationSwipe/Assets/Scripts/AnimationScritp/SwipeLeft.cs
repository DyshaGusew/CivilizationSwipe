using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//������ ���������� �� �������� �������� ��� ������(��������� ��� �������) ������ �������
public class SwipeLeft : MonoBehaviour
{
    private Animator animator; // ������ �� ��������� Animator, ��������� �� ����� ��������

    //�������� ��������� Animator � ������� ��������
    private void FindAnimation()
    {
        animator = MainStorage.thisGameCard.GetComponent<Animator>();
    }

    //������ �������� �������
    public void StartInclineAnimation()
    {
        FindAnimation();
        if (animator != null)
        {
            animator.SetBool("Left", true);
        }
    }

    //��������� �������� �������
    public void FinishInclineAnimation()
    {
        FindAnimation();
        if (animator != null)
        {
            animator.SetBool("Left", false);
        }
    }

    //����� ���������� ���� ������������� ��������(�� ��� ��� ��������� ��� ����)
    public void SwipeLeftCard()
    {
        // ������� ������ �� �����
        GameObject obj = GameObject.Find("NormalCard(Clone)");

        // ���������, ������ �� ������
        if (obj != null)
        {
            obj.name = "Card";
            SpriteRenderer spriteRenderer = obj.GetComponent<SpriteRenderer>();

            // ���� ��������� ������, ���������� ���� ������
            if (spriteRenderer != null)
            {
                spriteRenderer.sortingOrder = 10;
            }
        }
    }
    public void SwipeLeftDelete()
    {
        GameObject obj = GameObject.Find("Card");
        obj.tag = "Card"; // ��������� ���� �������
        Animator Animarotlocal = obj.GetComponent<Animator>();
        // ��������� ��������     
        StartCoroutine(WaitForAnimation(Animarotlocal, "DropLeft"));
    }

    //�������� ���� ���������, ��� ������������ ��������  
    private IEnumerator WaitForAnimation(Animator animator, string animationName)
    {
        animator.Play(animationName);
        // �������� � ��� �������              
        yield return new WaitForSeconds(0.35f);

        // ������� ��� ������� � ������ "Card" ����� ��������� ��������     
        GameObject[] cards = GameObject.FindGameObjectsWithTag("Card");
        foreach (GameObject card in cards)
        {
            if (card.name == "Card")
            {
                Destroy(card);
            }
        }
    }
}
