using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class IngridientCount : MonoBehaviour
{
    [SerializeField] private Text[] ingridients;

    private int[] clicksCOunt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ClickI1()
    {
        clicksCOunt[0]= clicksCOunt[0]+1;
    }
    public void ClickI2()
    {
        clicksCOunt[1]= clicksCOunt[1]+1;
    }
    public void ClickI3()
    {
        clicksCOunt[2]= clicksCOunt[2]+1;
    }
    public void ClickI4()
    {
        clicksCOunt[3]= clicksCOunt[3]+1;
    }
    public void ClickI5()
    {
        clicksCOunt[4]= clicksCOunt[4]+1;
    }
    public void ClickReset()
    {
        for (int  i = 0;  i < clicksCOunt.Length;  i++)
        {
            clicksCOunt[i] = 0;
        }
    }
    // Update is called once per frame
    void Update()
    {
            ingridients[0].text = clicksCOunt[0].ToString();
            ingridients[1].text = clicksCOunt[1].ToString();
            ingridients[2].text = clicksCOunt[2].ToString();
            ingridients[3].text = clicksCOunt[3].ToString();
            ingridients[4].text = clicksCOunt[4].ToString();
        //Dont count problem
    }
}
