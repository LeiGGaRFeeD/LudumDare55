using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuDebug : MonoBehaviour
{
    [SerializeField] private bool _debugIsOn;
    [SerializeField] private bool _webGL;
    [SerializeField] private GameObject[] _debugObj;

    [SerializeField] private GameObject[] _webObj;

    // Start is called before the first frame update
    void Start()
    {
        if (_debugIsOn == true)
        {
            for (int i = 0; i < _debugObj.Length; i++)
            {
                _debugObj[i].SetActive(true);
            }
            Debug.Log("Debug settings for menu are active");
        }
        if (_debugIsOn == false)
        {
            for (int i = 0; i < _debugObj.Length; i++)
            {
                _debugObj[i].SetActive(false);
            }
            Debug.Log("Debug settings for menu are inactive");
        }

        if (_webGL == true)
        {
            for (int i = 0; i < _webObj.Length; i++)
            {
                _webObj[i].SetActive(true);
            }
            Debug.Log("WebGL settings for menu are active");
        }
        if (_webGL == false)
        {
            for (int i = 0; i < _webObj.Length; i++)
            {
                _webObj[i].SetActive(false);

            }
            Debug.Log("WebGL settings for menu are inactive");
        }
    }
    
    // Update is called once per frame
    void Update()
    {

    }
}
