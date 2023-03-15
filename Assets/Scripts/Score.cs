using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public TMP_Text scoreText;
    private int score;
    void Start()
    {
        
    }

    void Update()
    {
        scoreText.text = score.ToString();
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Fish")
        {
            Destroy(target.gameObject);
            score++;
        }
        else if (target.tag == "Bomb")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
