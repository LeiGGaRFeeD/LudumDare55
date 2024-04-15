using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigPictureAppear : MonoBehaviour
{
    [Header("Place here mini icons of ingridient")]
    [SerializeField] private GameObject[] _miniIcons;
    [Header("Place here big picture of ingridien")]
    [SerializeField] private GameObject[] _bigIcons;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < _miniIcons.Length; i++)
        {
            if (_miniIcons[i].activeSelf == true)
            {
                _bigIcons[i].SetActive(true);
            }
            else if (_miniIcons[i].activeSelf == false)
            {
                
            }
            {
                _bigIcons[i].SetActive(false);
            }
        }
    }

}
