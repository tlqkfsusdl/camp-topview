using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUITalk : MonoBehaviour
{
    public CircleCollider2D coll;

    public Image image;
    public Image talkImage;

    public Button talkStart;
    public Button talkOk;

    public GameObject player1;
    public GameObject player2;

    private bool isPlayer = false;

    void Start()
    {
        coll = GetComponent<CircleCollider2D>();
    }

    void Update()
    {
        if (isPlayer)
        {
            image.gameObject.SetActive(true);
        }
        else
        {
            image.gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayer = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayer = false;
        }
    }

    public void TalkStart()
    {
        talkImage.gameObject.SetActive(true);
        talkOk.gameObject.SetActive(true);

        if (player1.tag == "Player" && player2.tag == "Player")
        {
            //Debug.Log("½ÇÇàµÊ");

            player1.tag = "Talk";
            player2.tag = "Talk";

            isPlayer = false;

            image.gameObject.SetActive(false);
        }
    }

    public void TalkEnd()
    {
        talkImage.gameObject.SetActive(false);
        talkOk.gameObject.SetActive(false);

        player1.tag = "Player";
        player2.tag = "Player";
    }
}
