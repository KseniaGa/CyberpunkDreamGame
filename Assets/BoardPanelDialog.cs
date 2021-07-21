using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

public class BoardPanelDialog : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

    public GameObject continueButton;
    public GameObject textBox;

    public GameObject boardPanel;
    public GameObject board2Panel;

    public GameObject board1Sprite;
    public GameObject board2Sprite;

    //public Image board1;
    //public Image board2;

    void Update()
    {
        if (textDisplay.text == sentences[index])
        {
            //textBox.SetActive(true);

            continueButton.SetActive(true);
        }
    }

    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }


    public void NextSentence()
    {
        continueButton.SetActive(false);
        GameObject player = GameObject.Find("ruby");

        if ((index < sentences.Length - 1) && (index != 6))
        {
            //Debug.Log("WHY");
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else if (index == 6)
        {

            //textDisplay.text = "";
           // continueButton.SetActive(false);
           // textBox.SetActive(false);



            board2Panel.SetActive(true);
            boardPanel.SetActive(false);

            index++;
           textDisplay.text = "";
           StartCoroutine(Type());

        }
        else
        {

            textDisplay.text = "";
            continueButton.SetActive(false);
            textBox.SetActive(false);
            board2Panel.SetActive(false);
            board1Sprite.SetActive(false);
            board2Sprite.SetActive(true);
            PlayerMovement.boardClue = true;
            player.GetComponent<PlayerMovement>().velocity = 7f;

            //Time.timeScale = 0;
        }
    }



    private void OnEnable()
    {

        GameObject player = GameObject.Find("ruby");

        Debug.Log(" Board Panel Active");



        if (PlayerMovement.boardClue == false)
        {
            //player.GetComponent<PlayerMovement>().velocity = 0f;
            textBox.SetActive(true);
            StartCoroutine(Type());




        }


        //if (PlayerMovement.doorSuccess == true)
        // {
        //SceneManager.LoadScene(2);
        // }

    }
}


