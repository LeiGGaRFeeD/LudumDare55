using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class VisibleText : MonoBehaviour
{
    [SerializeField] private GameObject[] _text;

    [SerializeField] private string[] _keys = { "Slimeman", "Turtle", "Spider","BoboCat","OsmoCat","NightLamp","Fox","Jellyfish","Dragon","Garoy" };

    [SerializeField] private string[] _textForPersonsC = { "SL", "TU", "SP", "BO", "OS", "NI", "FO", "JE", "DR", "GA" };

    [SerializeField] private GameObject[] _uiText;
    [SerializeField] private Text[] _symbols;
    private string _forErr = "You already created it!";

    private int a;
    // Start is called before the first frame update
    void Start()
    {
        OpenText();
    }

    private void OpenText()
    {
        for (int i = 0; i < _keys.Length; i++)
        {
            if (PlayerPrefs.GetInt(_keys[i])== 1 && PlayerPrefs.GetInt(_textForPersonsC[i]) == 0)
            {
                _uiText[i].SetActive(true);
                a = i;
                DeactivateAfterDelay();
            }
            else
            {
            //    _uiText[i].SetActive((false));
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
        yield return new WaitForSeconds(2f);

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
        
    }
}
