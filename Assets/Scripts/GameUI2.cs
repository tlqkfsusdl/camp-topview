using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameUI2 : MonoBehaviour
{
    public Image image;

    public void NpcList()
    {
        image.gameObject.SetActive(true); // �̹����� Ȱ��ȭ ���¸� ����
    }

    public void Click123()
    {
        image.gameObject.SetActive(false);
    }
}
