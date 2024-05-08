using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    
    private SpriteRenderer spriteRenderer; // ĳ���� �¿������ ���
    public GameUI gameUI;
    public GameUITalk gameUITalk;

    public void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        gameUI = FindObjectOfType<GameUI>();
        gameUITalk = FindObjectOfType<GameUITalk>();
    }

    public void Update()
    {
        if (!gameUI.inputField.isActiveAndEnabled && !gameUITalk.talkImage.isActiveAndEnabled)
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            if (mousePos.x < transform.position.x)
            {
                spriteRenderer.flipX = true;
            }
            else
            {
                spriteRenderer.flipX = false;
            }
        }
    }
}
