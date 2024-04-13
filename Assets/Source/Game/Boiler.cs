using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boiler : MonoBehaviour
{
    [SerializeField] private GameObject[] ingridients;
    
    
    // Start is called before the first frame update
    void Start()
    {
        for (int  i = 0;  i < ingridients.Length;  i++)
        {
            ingridients[i].SetActive(false);
        }
    }


    public void SparklesAppear()
    {
        ingridients[0].SetActive(true);
    }
    public void CrystalAppear()
    {
        ingridients[1].SetActive(true);
    }
    public void FurAppear()
    {
        ingridients[2].SetActive(true);
    }
    public void SlurryAppear()
    {
        ingridients[3].SetActive(true);
    }
    public void FireAppear()
    {
        ingridients[4].SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        if ( PlayerPrefs.GetInt("CookClicked") ==  1)
        {
            for (int  i = 0;  i < ingridients.Length;  i++)
            {
                ingridients[i].SetActive(false);
            }
            PlayerPrefs.SetInt("CookClicked",0);
        }
    }
}
