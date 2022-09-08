using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCollectible : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
     void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("trigger");
        GameObject.Find ("Score_Canvas").GetComponent<ScoreScript> ().AddScore ();
        RepositionCollectible();
    }

 void RepositionCollectible()
         
    {
        float newX = Random.Range (-5, 5);
        float newY = Random.Range (-3, 3);
        Vector2 newPos = new Vector2 (newX, newY);
        transform.position = newPos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
