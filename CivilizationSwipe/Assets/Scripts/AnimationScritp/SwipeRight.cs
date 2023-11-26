using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//������ ���������� �� �������� �������� ��� ������(��������� ��� �������) ������� �������
public class SwipeRight : MonoBehaviour
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
        FinishInclineAnimation();
        FindAnimation();
        if (animator != null)
        {
            animator.SetBool("Right", true);
        }
    }

    //��������� �������� �������
    public void FinishInclineAnimation()
    {
        FindAnimation();
        if (animator != null)
        {
            animator.SetBool("Right", false);
        }
    }

    //����� ���������� ���� ������� ��������(�� ��� ��� ��������� ��� ����)
    public void SwipeRightCard()
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

    //������ �������� �������� ������� ��������
    public void SwipeRightDelete()
    {
        GameObject obj = GameObject.Find("Card");
        obj.tag = "Card"; // ��������� ���� �������
        Animator Animarotlocal = obj.GetComponent<Animator>();
        // ��������� ��������     
        StartCoroutine(WaitForAnimation(Animarotlocal, "DropRight"));
    }

    //������� ���� ���������, ��� ������������ ��������
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