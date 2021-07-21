using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class doorScript: MonoBehaviour
{

    public TMP_InputField input1;
    public TMP_InputField input2;
    public TMP_InputField input3;

    public GameObject doorPanel;
    public GameObject open;


    //   void Start()
    //   {
    //      
    //  }


    //    void Update()
    //  {
    //   string num1 = input1.GetComponent<TMP_InputField>().text;
    //}


    public void tryDoor()
	{
        //num1 = input1.text;

        if ((input1.text == "R") && (input2.text == "U") && (input3.text == "B"))
		{
            GameObject player = GameObject.Find("ruby");
            Debug.Log("Success!");
            PlayerMovement.doorSuccess = true;
            player.GetComponent<PlayerMovement>().velocity = 10f;
            doorPanel.SetActive(false);
            open.SetActive(true);
		}

        else
		{
            GameObject player = GameObject.Find("ruby");
            //Time.timeScale = 1;
            player.GetComponent<PlayerMovement>().velocity = 10f;
            doorPanel.SetActive(false);
            Debug.Log("Try again");
           //Debug.Log(num2.text);
        }
	}


}
