using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class VisibleText : MonoBehaviour
{
    [SerializeField] private GameObject[] _text;

    private string[] _keys = { "Slimeman", "Turtle", "Spider","BoboCat","OsmoCat","NightLamp","Fox","Jellyfish","Dragon","Garpy" };

    [SerializeField] private string[] _textForPersonsC = { "SL", "TU", "SP", "BO", "OS", "NI", "FO", "JE", "DR", "GA" };

    [SerializeField] private GameObject[] _uiText;
    [SerializeField] private Text[] _symbols;
   // private string _forErr = "You already created it!";
   [SerializeField] private string _SecondUse;

    private int a;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(_keys[9]);
        OpenText();
        
    }

    private void OpenText()
    {
        for (int i = 0; i < _keys.Length; i++)
        {
            Debug.Log(_keys[i]);
            Debug.Log(PlayerPrefs.GetInt(_keys[i]));
            Debug.Log(PlayerPrefs.GetInt(_textForPersonsC[i]));

            if (PlayerPrefs.GetInt(_keys[i])== 1 && PlayerPrefs.GetInt(_textForPersonsC[i]) == 0)
            {
                _uiText[i].SetActive(true);
                a = i;
                DeactivateAfterDelay();
            } 
            else if(PlayerPrefs.GetInt(_keys[i])== 1 && 
                    PlayerPrefs.GetInt(_textForPersonsC[i]) == 2
                    && PlayerPrefs.GetString("LastUse") == _keys[i])
            {
                _uiText[i].SetActive(true);
                _uiText[i].GetComponent<Text>().text = _SecondUse.ToString();//"Already used";
                a = i;
                DeactivateAfterDelay();
            }
        }
    }
    
    // Вызовите этот метод, чтобы деактивировать объект через 2 секунды.
    public void DeactivateAfterDelay()
    {
        StartCoroutine(DeactivateCoroutine());
    }

    private IEnumerator DeactivateCoroutine()
    {
        // Ожидание 2 секунд.
        yield return new WaitForSeconds(3.5f);

        // Деактивация объекта.
        for (int i = 0; i < _textForPersonsC.Length; i++)
        {
            PlayerPrefs.SetInt(_textForPersonsC[a],2);
            _uiText[a].SetActive(false);
        }
      //  gameObject.SetActive(false);
    } 

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Garpy state "+PlayerPrefs.GetInt(_textForPersonsC[9]));
        Debug.Log("Dragon state "+PlayerPrefs.GetInt(_textForPersonsC[8]));
    }
}
 