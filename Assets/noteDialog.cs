using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

using TMPro;

public class noteDialog : MonoBehaviour
{


    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

    public GameObject continueButton;
    public GameObject textBox;

    //public GameObject doorPanel;


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
            Debug.Log("WHY");
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
            textBox.SetActive(false);
            PlayerMovement.gotNote = true;
            player.GetComponent<PlayerMovement>().velocity = 7f;

            //Time.timeScale = 0;
        }
    }



    private void OnTriggerEnter2D(Collider2D collider)
    {


        if (PlayerMovement.emailClue == false)
        {

            GameObject player = GameObject.Find("ruby");



            player.GetComponent<PlayerMovement>().velocity = 0f;
            Debug.Log("Got the note");
            textBox.SetActive(true);
            StartCoroutine(Type());

        }
        }



    
}
