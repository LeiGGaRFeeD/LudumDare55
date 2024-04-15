using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class DebugGame : MonoBehaviour
{
    [SerializeField] private GameObject _debugCanvas;
    private bool _debugIsOn;
    [SerializeField] private string[] _textForPersonsC = { "SL", "TU", "SP", "BO", "OS", "NI", "FO", "JE", "DR", "GA" };

    [SerializeField] private Text _nameDB;
    // Start is called before the first frame update
    void Start()
    {
   /*     if ( _debugIsOn == true)
        {
            Debug.Log(("Debug is on"));
        }
        else
        {
            Debug.Log("Debug is off");
        }*/
    }

    public void ResetOpened()
    {
        PlayerPrefs.SetInt("Slimeman",0);
        PlayerPrefs.SetInt("Turtle",0);
        PlayerPrefs.SetInt("Spider",0);
        PlayerPrefs.SetInt("BoboCat",0);
        PlayerPrefs.SetInt("OsmoCat",0);
        PlayerPrefs.SetInt("NightLamp",0);
        PlayerPrefs.SetInt("Fox",0);
        PlayerPrefs.SetInt("Jellyfish",0);
        PlayerPrefs.SetInt("Dragon",0);
        PlayerPrefs.SetInt("Garpy",0);
        Debug.Log(("Opened reseted!"));

        for (int  i = 0;  i < _textForPersonsC.Length;  i++)
        {
            PlayerPrefs.SetInt(_textForPersonsC[i],0);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.UpArrow) == true)
        {
            _debugIsOn = true;
        }
        if ( Input.GetKeyDown(KeyCode.DownArrow) == true)
        {
            _debugIsOn = false;
        }

        
        if ( (_debugIsOn == true))
        {
            _debugCanvas.SetActive(true);
            if ( Input.GetKeyDown((KeyCode.R))==true)
            {
                ResetOpened();
            }
            
            
        }
        else
        {
            _debugCanvas.SetActive(false);
        }

        _nameDB.text ="Name = "+ PlayerPrefs.GetString("nameSTR").ToString();
    }
}
