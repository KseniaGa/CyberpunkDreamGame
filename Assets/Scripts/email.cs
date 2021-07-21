using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class email : MonoBehaviour
{

    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;

    //public GameObject backButton2;
    //public GameObject emailPanel;


    public void p1Em ()
	{
        p1.SetActive(true);
        p2.SetActive(false);
        p3.SetActive(false);
        p4.SetActive(false);

    }

    public void p2Em()
    {

        p2.SetActive(true);
        p1.SetActive(false);
        p3.SetActive(false);
        p4.SetActive(false);
    }

    public void p3Em()
    {
        p3.SetActive(true);
        p1.SetActive(false);
        p2.SetActive(false);
        p4.SetActive(false);
    }

    public void p4Em()
    {
        p4.SetActive(true);
        p1.SetActive(false);
        p2.SetActive(false);
        p3.SetActive(false);
    }

}
