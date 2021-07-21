using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using UnityEngine.SceneManagement;

public class drimsDialog : MonoBehaviour
{
	public TextMeshProUGUI textDisplay;
	public string[] sentences;
	private int index;
	public float typingSpeed;

	public GameObject continueButton;
	public GameObject textBox;

	public GameObject finalChoicePanel;



	// player.GetComponent<PlayerMovement>();
	//	private float plVelocity = player.GetComponent<PlayerMovement>().velocity;


	//private BoxCollider2D bc;

	void Start()

	{
		GameObject player = GameObject.Find("ruby");

		//bc = GetComponent <BoxCollider2D> ();
		//Time.timeScale = 0;

			player.GetComponent<PlayerMovement>().velocity = 0f;

			textBox.SetActive(true);
			StartCoroutine(Type());



		//player.GetComponent<PlayerMovement>().velocity = 5f;




	}

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
			index++;
			textDisplay.text = "";
			StartCoroutine(Type());
		}
		else
		{
			textDisplay.text = "";
			continueButton.SetActive(false);
			textBox.SetActive(false);
			finalChoicePanel.SetActive(true);
			//player.GetComponent<PlayerMovement>().velocity = 10f;
			//HARD CODING OOPS

			//Time.timeScale = 1;
		}
	}


	//	private void OnTriggerEnter2D(Collider2D collider)
	//	{
	//		Debug.Log("Triggered");
	//	textBox.SetActive(true);
	//	StartCoroutine(Type());
	//
	//}

	public void badEnding()
	{
		SceneManager.LoadScene("BadEnding");
	}

	public void goodEnding()
	{
		SceneManager.LoadScene("GoodEnding");
	}



}
