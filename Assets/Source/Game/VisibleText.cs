using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisibleText : MonoBehaviour
{
    [SerializeField] private GameObject[] _text;

    [SerializeField] private string[] _keys = { "Slimeman", "Turtle", "Spider","BoboCat","OsmoCat","NightLamp","Fox","Jellyfish","Dragon","Garoy" };

    [SerializeField] private string[] _textForPersonsC = { "SL", "TU", "SP", "BO", "OS", "NI", "FO", "JE", "DR", "GA" };

    [SerializeField] private Text[] _symbols;
    private string _forErr = "You already created it!";
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OpenText()
    {
        for (int i = 0; i < 0; i++)
        {
            if (PlayerPrefs.GetInt(_keys[i])== 1)
            {
                if (PlayerPrefs.GetInt(_textForPersonsC[i]) == 1)
                {
                    
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
