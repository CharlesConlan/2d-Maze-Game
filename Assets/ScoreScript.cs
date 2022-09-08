using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreScript : MonoBehaviour
{
    // Start is called before the first frame update
public TextMeshProUGUI scoreText;
int score = 0;
    void Start()
    {

    }


        public void AddScore()
{


  score++;
  scoreText.text = score.ToString ();
}
    // Update is called once per frame
    void Update()
    {
        
    }
}

