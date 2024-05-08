using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb; // 캐릭터 충돌 적용
    public GameUI gameUI;
    public GameUITalk gameUITalk;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameUI = FindObjectOfType<GameUI>();
        gameUITalk = FindObjectOfType<GameUITalk>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameUI.inputField.isActiveAndEnabled && !gameUITalk.talkImage.isActiveAndEnabled)
        {
            Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            rb.velocity = movement * moveSpeed;
        }
    }
}
