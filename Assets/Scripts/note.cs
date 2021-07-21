using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class note : MonoBehaviour
{


   // void Update()
//    {
        
//}


	private void OnTriggerEnter2D(Collider2D collider)
	{


			//textBox.SetActive(true);
			//StartCoroutine(Type());
			PlayerMovement.gotNote = true;
			Debug.Log("Got the note");


	}
}
