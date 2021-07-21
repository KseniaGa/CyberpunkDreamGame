using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class DialogStartComp : MonoBehaviour
{
	public TextMeshProUGUI textDisplay;
	public string[] sentences;
	private int index;
	public float typingSpeed;

	public GameObject continueButton;
	public GameObject textBox;
	public GameObject compCanvas;



	// player.GetComponent<PlayerMovement>();
	//	private float plVelocity = player.GetComponent<PlayerMovement>().velocity;


	//private BoxCollider2D bc;

	void Start()

	{
		if (PlayerMovement.emailClue == false)
		{
			textBox.SetActive(true);
			StartCoroutine(Type());

		}

		else
		{
			compCanvas.SetActive(true);
		}

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
			compCanvas.SetActive(true);

		}
	}



}
