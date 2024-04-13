using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creatures : MonoBehaviour
{
    [SerializeField] private GameObject[] creature;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void CreaturesOpening()
    {
        if ( PlayerPrefs.GetInt("Slimeman") == 1)
        {
            creature[0].SetActive(true);
        }
        else
        {
            creature[0].SetActive(false);
        }
        
        if ( PlayerPrefs.GetInt("Turtle") == 1)
        {
            creature[1].SetActive(true);
        }
        else
        {
            creature[1].SetActive(false);
        }
        
        if ( PlayerPrefs.GetInt("Spider") == 1)
        {
            creature[2].SetActive(true);
        }
        else
        {
            creature[2].SetActive(false);
        }
        
        if ( PlayerPrefs.GetInt("BoboCat") == 1)
        {
            creature[3].SetActive(true);
        }
        else
        {
            creature[3].SetActive(false);
        }
        
        if ( PlayerPrefs.GetInt("OsmoCat") == 1)
        {
            creature[4].SetActive(true);
        }
        else
        {
            creature[4].SetActive(false);
        }
        
        if ( PlayerPrefs.GetInt("NightLamp") == 1)
        {
            creature[5].SetActive(true);
        }
        else
        {
            creature[5].SetActive(false);
        }
        
        if ( PlayerPrefs.GetInt("Fox") == 1)
        {
            creature[6].SetActive(true);
        }
        else
        {
            creature[6].SetActive(false);
        }
        
        if ( PlayerPrefs.GetInt("Jellyfish") == 1)
        {
            creature[7].SetActive(true);
        }
        else
        {
            creature[7].SetActive(false);
        }
        
        if ( PlayerPrefs.GetInt("Dragon") == 1)
        {
            creature[8].SetActive(true);
        }
        else
        {
            creature[8].SetActive(false);
        }
        
        if ( PlayerPrefs.GetInt("Garpy") == 1)
        {
            creature[9].SetActive(true);
        }
        else
        {
            creature[9].SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        CreaturesOpening();
    }
}
