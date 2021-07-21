using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class introScript : MonoBehaviour
{
	public GameObject text1;
	public GameObject text2;
	public GameObject text3;

	public GameObject NextButton;
	public GameObject NextButton2;
	public GameObject StartButton;

	
	public void nextButton ()
	{
		text1.SetActive(false);
		text2.SetActive(true);

		NextButton.SetActive(false);
		NextButton2.SetActive(true);
	}

	public void nextButton2()
	{
		text2.SetActive(false);
		text3.SetActive(true);

		NextButton2.SetActive(false);
		StartButton.SetActive(true);
	}


	public void startButton()
	{
		SceneManager.LoadScene("LilysOffice");

	}

}
