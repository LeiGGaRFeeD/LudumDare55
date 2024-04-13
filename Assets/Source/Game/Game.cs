using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    [SerializeField] private string _name;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public void CheckCook() //Check if ingridients are right
    {
        if (_name == "firecrystalslurry" || _name == "fireslurrycrystal" || _name == "crystalfireslurry" || _name == "crystalslurryfire" || _name == "slurryfirecrystal" || _name == "slurrycrystalfire" )
        {
            PlayerPrefs.SetInt("Slimeman",1);
            Debug.Log("Slimeman opened");
        }
        
        if (_name == "sparklescrystalfire" || _name == "sparklesfirecrystal" || _name == "firecrystalsparkles" || _name == "firesparklescrystal" || _name == "crystalfiresparkles" || _name == "crystalfiresparkles" )
        {
            PlayerPrefs.SetInt("Turtle",1);
            Debug.Log("Turtle opened");
        }
        
        if (_name == "sparklescrystalfur" || _name == "sparklesfurcrystal" || _name == "fursparklescrystal" || _name == "furcrystalsparkles" || _name == "crystalfursparkles" || _name == "crystalsparklesfur" )
        {
            PlayerPrefs.SetInt("Spider",1);
            Debug.Log("Spider opened");
        }
        
        if (_name == "crystalfurslurry" || _name == "crystalslurryfur" || _name == "furcrystalslurry" || _name == "furslurrycrystal" || _name == "slurrycrystalfur" || _name == "slurryfurcrystal" )
        {
            PlayerPrefs.SetInt("BoboCat",1);
            Debug.Log("BoboCat opened");
        }
        
        if (_name == "sparklesfurslurry" || _name == "sparklesslurryfur" || _name == "fursparklesslurry" || _name == "furslurrysparkles" || _name == "slurrysparklesfur" || _name == "slurryfursparkles" )
        {
            PlayerPrefs.SetInt("OsmoCat",1);
            Debug.Log("OsmoCat opened");
        }
        
    }
    
    
    
    //buttons logic
    public void ingridientOne()
    {
        _name = _name + "sparkles";
    }

    public void ingridientTwo()
    {
        _name = _name + "crystal";
    }
    public void ingridientThree()
    {
        _name = _name + "fur";
    }

    public void ingridientFour()
    {
        _name = _name + "slurry";
    }
    public void ingridientFive()
    {
        _name = _name + "fire";
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log(("name = "+_name));
    }
}
