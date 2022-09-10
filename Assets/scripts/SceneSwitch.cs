using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public string sceneName;
    public bool useMouseClick = false;

    // Update is called once per frame
    void Update()
    {
        if (useMouseClick)
        {
            CheckStart();
        }
    }

    void CheckStart()
    {
        if (Input.GetMouseButtonDown (0)) 
        {
            //Change the scene name depending on which script you are on.
            //Note that this will require that each SceneManager has a string
            //typed into the Unity Inspector for sceneName.
            SceneManager.LoadScene (sceneName);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && useMouseClick == false)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}


