using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CorrectZone : MonoBehaviour
{
    private bool _playerInside;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public void CreaturesOpening()
    {
        Debug.Log(("Creature opening is working"));
        if (_playerInside == true)
        {


            if (PlayerPrefs.GetInt("Slimeman") == 2)
            {
                PlayerPrefs.SetInt("Slimeman", 1);
                SceneManager.LoadScene("Game");
            }

            if (PlayerPrefs.GetInt("Turtle") == 2)
            {
                PlayerPrefs.SetInt("Turtle", 1);
                SceneManager.LoadScene("Game");
            }

            if (PlayerPrefs.GetInt("Spider") == 2)
            {
                PlayerPrefs.SetInt("Spider", 1);
                SceneManager.LoadScene("Game");
            }

            if (PlayerPrefs.GetInt("BoboCat") == 2)
            {
                PlayerPrefs.SetInt("BoboCat", 1);
                SceneManager.LoadScene("Game");
            }

            if (PlayerPrefs.GetInt("OsmoCat") == 2)
            {
                PlayerPrefs.SetInt("OsmoCat", 1);
                SceneManager.LoadScene("Game");
            }

            if (PlayerPrefs.GetInt("NightLamp") == 2)
            {
                PlayerPrefs.SetInt("NightLamp", 1);
                SceneManager.LoadScene("Game");
            }

            if (PlayerPrefs.GetInt("Fox") == 2)
            {
                PlayerPrefs.SetInt("Fox", 1);
                SceneManager.LoadScene("Game");
            }

            if (PlayerPrefs.GetInt("Jellyfish") == 2)
            {
                PlayerPrefs.SetInt("Jellyfish", 1);
                SceneManager.LoadScene("Game");
            }

            if (PlayerPrefs.GetInt("Dragon") == 2)
            {
                PlayerPrefs.SetInt("Dragon", 1);
                SceneManager.LoadScene("Game");
            }

            if (PlayerPrefs.GetInt("Garpy") == 2)
            {
                PlayerPrefs.SetInt("Garpy", 1);
                SceneManager.LoadScene("Game");
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        _playerInside = true;
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        _playerInside = false;
    }
    
    
    void Update()
    {
        Debug.Log(("Player inside = "+_playerInside));
    }
}
