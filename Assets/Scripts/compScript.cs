using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class compScript : MonoBehaviour
{

    public GameObject quitButton;
    public GameObject backButton;
    public GameObject backButton2;
    public GameObject backButton3;

    public GameObject frPanel;
    public GameObject emailPanel;
    public GameObject logPanel;


    //void Start()
    //{
    //    
    //}


    void Update()
    {
        if (PlayerMovement.emailClue == true)
        {
            quitButton.SetActive(true); 
        }
    }


    public void forRuby()
	{
        frPanel.SetActive(true);
        backButton.SetActive(true);
        PlayerMovement.emailClue = true;

    }

    public void email()
	{
        emailPanel.SetActive(true);
        backButton2.SetActive(true);
    }

    public void log()
    {
        logPanel.SetActive(true);
        backButton3.SetActive(true);
    }

    public void QuitComp()
	{

        SceneManager.LoadScene("LilysOffice");
    }


    public void backFr()
    {
        frPanel.SetActive(false);
        backButton.SetActive(false);

    }

    public void backEm()
    {
        emailPanel.SetActive(false);
        backButton2.SetActive(false);

    }

    public void backLog()
    {
        logPanel.SetActive(false);
        backButton3.SetActive(false);

    }

    public void Log1()
    {

        Debug.Log("Play Log 1"); 
    }

    public void Log2()
    {

        Debug.Log("Play Log 2");
    }


}
