using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

using TMPro;

public class GlobeDialog: MonoBehaviour
{


    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

    public GameObject continueButton;
    public GameObject textBox;

    public GameObject globePanel;


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
            globePanel.SetActive(true);

            //Time.timeScale = 0;
        }
    }



    private void OnTriggerEnter2D(Collider2D collider)
    {

        GameObject player = GameObject.Find("ruby");

        Debug.Log("Triggered Globe");

        

        if ((PlayerMovement.posterClueGlobe == false) && (PlayerMovement.emailClue == true))
        {
            player.GetComponent<PlayerMovement>().velocity = 0f;
            textBox.SetActive(true);
            StartCoroutine(Type());




        }


        //if (PlayerMovement.doorSuccess == true)
       // {
            //SceneManager.LoadScene(2);
       // }

    }
}
