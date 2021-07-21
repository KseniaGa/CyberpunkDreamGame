using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

public class Board2PanelDialog : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

    public GameObject continueButton;
    public GameObject textBox;

    public GameObject boardPanel;
    public GameObject board2Panel;

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

        if (index < sentences.Length - 1)
        {
            //Debug.Log("WHY");
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }

        else
        {

            textDisplay.text = "";
            continueButton.SetActive(false);
            textBox.SetActive(false);
            //boardPanel.SetActive(false);
            board2Panel.SetActive(false);
            PlayerMovement.boardClue = true;
            player.GetComponent<PlayerMovement>().velocity = 7f;

            //Time.timeScale = 0;
        }
    }



    private void OnEnable()
    {

        GameObject player = GameObject.Find("ruby");

        Debug.Log(" Board2 Panel Active");



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


