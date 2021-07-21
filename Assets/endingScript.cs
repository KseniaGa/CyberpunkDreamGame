using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class endingScript : MonoBehaviour
{


	//public GameObject QuitButton;
	//public GameObject ReStartButton;





	public void restartButton()
	{
		SceneManager.LoadScene("LilysOffice");

	}

	public void quitButton()
	{
		Application.Quit(); 

	}

}
