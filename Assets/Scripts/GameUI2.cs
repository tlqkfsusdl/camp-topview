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
        image.gameObject.SetActive(true); // 이미지의 활성화 상태를 변경
    }

    public void Click123()
    {
        image.gameObject.SetActive(false);
    }
}
