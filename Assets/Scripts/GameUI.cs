using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public InputField inputField;
    public Button submitButton;
    public Button cancelButton;
    public Text displayText;
    public Text characterSelect;
    public Text listName;
    public Image characterImage;
    public Image characterImage1;
    public Image characterImage2;

    public GameObject character1;
    public GameObject character2;

    public Camera mainCamera;

    public void Start()
    {
        // Input Field�� ���ڼ� ���� ����
        inputField.characterLimit = 10;
    }

    public void SubmitButtonClicked()
    {
        //Debug.Log("�޼��尡 �����1");

        string inputText = inputField.text;
        if (inputText.Length >= 2 && inputText.Length <= 10)
        {
            //Debug.Log("�޼��尡 �����2");

            displayText.text = inputText;
            listName.text = inputText;
            inputField.gameObject.SetActive(false); // Input Field ��Ȱ��ȭ
            submitButton.gameObject.SetActive(false); // Button ��Ȱ��ȭ
            cancelButton.gameObject.SetActive(false);

        }
        else
        {
            Debug.Log("ĳ���� �г����� 2~10���ڰ� �ƴ�.");
        }
    }

    public void NickNameOn()
    {
        inputField.gameObject.SetActive(true);
        submitButton.gameObject.SetActive(true);
    }

    public void CharacterOn()
    {
        characterImage.gameObject.SetActive(true);
    }

    public void CharacterChange()
    {
        characterImage.gameObject.SetActive(true);
    }

    public void CharacterSeclect1()
    {
        character1.gameObject.SetActive(true);
        character2.gameObject.SetActive(false);
        mainCamera.gameObject.SetActive(false);
        characterImage.gameObject.SetActive(false);
        characterImage1.gameObject.SetActive(true);
        characterImage2.gameObject.SetActive(false);
        characterSelect.gameObject.SetActive(false);
    }

    public void CharacterSeclect2()
    {
        character2.gameObject.SetActive(true);
        character1.gameObject.SetActive(false);
        mainCamera.gameObject.SetActive(false);
        characterImage.gameObject.SetActive(false);
        characterImage2.gameObject.SetActive(true);
        characterImage1.gameObject.SetActive(false);
        characterSelect.gameObject.SetActive(false);
    }
}
