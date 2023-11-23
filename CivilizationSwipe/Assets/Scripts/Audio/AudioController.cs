using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//������ ��� ��������� ������
public class AudioController : MonoBehaviour
{
    //��������� �������� ����� � ����������� �� ���������� ���
    public void SetFoneAudio(string era)
    {
        gameObject.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>("Sound/FoneAudio/" + era);
        gameObject.GetComponent<AudioSource>().Play();
    }
}
