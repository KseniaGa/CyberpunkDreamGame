using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public float velocity;
    private Rigidbody2D rigidbody;

    public static bool gotNote = false;

    public static bool boardClue = false;
    public static bool posterClueGlobe = false;
    public static bool posterClueSheep = false;
    public static bool emailClue = false;
    //public static bool foodMachineClue = false;

    public static bool doorSuccess = false;



    private int buildIndex;


    void Start()


    {
        Scene currentScene = SceneManager.GetActiveScene();
        buildIndex = currentScene.buildIndex;
        rigidbody = GetComponent<Rigidbody2D>();

        if ((PlayerMovement.emailClue == true) && (buildIndex == 1))
		{

            transform.position = new Vector3(-10.7f, -5.6f, -1.0f);
        }
    }

    public void Update()
    {


        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            rigidbody.velocity = Vector2.up *velocity;
            

        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {

            rigidbody.velocity = Vector2.up * 0;
        }



        if (Input.GetKeyDown(KeyCode.DownArrow))
        {

            rigidbody.velocity = Vector2.down * velocity;

        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {

            rigidbody.velocity = Vector2.down * 0;
        }





        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            rigidbody.velocity = Vector2.left * velocity;

        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {

            rigidbody.velocity = Vector2.left * 0;
        }




        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

            rigidbody.velocity = Vector2.right * velocity;

        } 
        else if (Input.GetKeyUp(KeyCode.RightArrow)) 
            {

            rigidbody.velocity = Vector2.right * 0;
        }
//Update end
    }


//End bracket
}
