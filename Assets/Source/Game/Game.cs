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
        if (_name == "sparklescrystalslurry" || _name == "sparklesslurrycrystal" || _name == "crystalsparklesslurry" || _name == "crystalslurrysparkles" || _name == "slurrysparklescrystal" || _name == "slurrycrystalslurry" )
        {
            PlayerPrefs.SetInt("Slimeman",1);
            Debug.Log("Turtle opened");
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
        
        if (_name == "sparklesfurfire" || _name == "sparklesfirefur" || _name == "firesparklesfur" || _name == "firefursparkles" || _name == "furfiresparkles" || _name == "fursparklesfire" )
        {
            PlayerPrefs.SetInt("NightLamp",1);
            Debug.Log("Nightlamp opened");
        }
        
        if (_name == "crystalfurfire" || _name == "crystalfirefur" || _name == "firefurcrystal" || _name == "firecrystalfur" || _name == "furcrystalfire" || _name == "furfirecrystal" )
        {
            PlayerPrefs.SetInt("Fox",1);
            Debug.Log("fox opened");
        }
        
        if (_name == "sparklesslurryfire" || _name == "sparklesfireslurry" || _name == "fireslurrysparkles" || _name == "firesparklesslurry" || _name == "slurryfiresparkles" || _name == "slurrysparklesfire" )
        {
            PlayerPrefs.SetInt("Jellyfish",1);
            Debug.Log("OsmoCat opened");
        }
        
        if (_name == "firecrystalslurry" || _name == "firesslurrycrystal" || _name == "crystalfireslurry" || _name == "crystalslurryfire" || _name == "slurryfirecrystal" || _name == "slurrycrystalfire" )
        {
            PlayerPrefs.SetInt("Dragon",1);
            Debug.Log("Dragon opened");
        }
        
        if (_name == "furslurryfire" || _name == "furfireslurry" || _name == "fireslurryfur" || _name == "firefurslurry" || _name == "slurryfirefur" || _name == "slurryfurfire" )
        {
            PlayerPrefs.SetInt("Garpy",1);
            Debug.Log("Garpy opened");
        }


        _name = "";
        PlayerPrefs.SetInt("CookClicked",1);

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
