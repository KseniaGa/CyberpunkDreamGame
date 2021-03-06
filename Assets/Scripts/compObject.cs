using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

using TMPro;

public class compObject : MonoBehaviour
{
	public TextMeshProUGUI textDisplay;
	public string[] sentences;
	private int index;
	public float typingSpeed;

	public GameObject continueButton;
	public GameObject textBox;

	public GameObject compPanel;

	//private BoxCollider2D bc;


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

			SceneManager.LoadScene("Computer");
			//Time.timeScale = 1;
		}
	}


	private void OnTriggerEnter2D(Collider2D collider)
	{
		GameObject player = GameObject.Find("ruby");

		if ((PlayerMovement.gotNote == true) && (PlayerMovement.emailClue == false))
		{
			player.GetComponent<PlayerMovement>().velocity = 0f;

			Debug.Log("Triggered");
			textBox.SetActive(true);
			StartCoroutine(Type());
			//PlayerMovement.boardClue = true;

		}

		else if (PlayerMovement.emailClue == true)
		{
			SceneManager.LoadScene("Computer");
		}

	}


}
