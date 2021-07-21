using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class drimsInterfaceScript : MonoBehaviour
{

	public TextMeshProUGUI textDisplay;
	public string[] sentences;
	private int index;
	public float typingSpeed;

	public GameObject continueButton;
	public GameObject textBox;

	public GameObject drimsPanel;


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

			drimsPanel.SetActive(true);
			//Time.timeScale = 1;
		}
	}


	private void OnTriggerEnter2D(Collider2D collider)
	{
		GameObject player = GameObject.Find("ruby");
		player.GetComponent<PlayerMovement>().velocity = 0f;
		textBox.SetActive(true);
		StartCoroutine(Type());
 
	}

	public void ConnectButton()
	{
		SceneManager.LoadScene("Drimsapace");
	}

}
