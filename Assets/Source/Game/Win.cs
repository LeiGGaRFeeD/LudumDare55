using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    [SerializeField] private GameObject _winPanel;
    private int a = 0;
    private string[] _keys = { "Slimeman", "Turtle", "Spider","BoboCat","OsmoCat","NightLamp","Fox","Jellyfish","Dragon","Garpy" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int  i = 0;  i < _keys.Length;  i++)
        {
            if (PlayerPrefs.GetInt(_keys[i]) == 1)
            {
                a++;
            }
        }
      //  if 
    }
}
