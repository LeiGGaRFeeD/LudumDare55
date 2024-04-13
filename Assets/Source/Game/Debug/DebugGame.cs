using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DebugGame : MonoBehaviour
{
    [SerializeField] private bool _debugIsOn;
    // Start is called before the first frame update
    void Start()
    {
        if ( _debugIsOn == true)
        {
            Debug.Log(("Debug is on"));
        }
        else
        {
            Debug.Log("Debug is off");
        }
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
    }
    // Update is called once per frame
    void Update()
    {
        if ( (_debugIsOn == true))
        {
            if ( Input.GetKeyDown((KeyCode.R))==true)
            {
                ResetOpened();
            }
        }
    }
}
