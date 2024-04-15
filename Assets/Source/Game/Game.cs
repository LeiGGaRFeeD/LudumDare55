using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    
    [SerializeField] private string _name;
    // Start is called before the first frame update
    [SerializeField] private GameObject[] _boilerPic;
    void Start()
    {
        
    }
    
    
    //States
    //0 - closed
    //1 - opened 
    //2 - Mini-game opening
    public void CheckCook() //Check if ingridients are right
    {
        if (_name.Contains("sparkles") && _name.Contains("crystal") && _name.Contains("slurry"))
        {
            
        }
        if (_name == "sparklescrystalslurry" || _name == "sparklesslurrycrystal" || _name == "crystalsparklesslurry" || _name == "crystalslurrysparkles" || _name == "slurrysparklescrystal" || _name == "slurrycrystalslurry" )
        {
            PlayerPrefs.SetInt("Slimeman",2);
            PlayerPrefs.SetString("LastUse", "Slimeman");
            Debug.Log("Turtle opened");
            SceneManager.LoadScene("MiniGame");
        }
        
        else if (_name == "sparklescrystalfire" || _name == "sparklesfirecrystal" || _name == "firecrystalsparkles" || _name == "firesparklescrystal" || _name == "crystalfiresparkles" || _name == "crystalfiresparkles" )
        {
            PlayerPrefs.SetInt("Turtle",2);
            PlayerPrefs.SetString("LastUse", "Turtle");
            Debug.Log("Turtle opened");
            SceneManager.LoadScene("MiniGame");
        }
        
        else if (_name == "sparklescrystalfur" || _name == "sparklesfurcrystal" || _name == "fursparklescrystal" || _name == "furcrystalsparkles" || _name == "crystalfursparkles" || _name == "crystalsparklesfur" )
        {
            PlayerPrefs.SetInt("Spider",2);
            PlayerPrefs.SetString("LastUse", "Spider");
            Debug.Log("Spider opened");
            SceneManager.LoadScene("MiniGame");
        }
        
        else if (_name == "crystalfurslurry" || _name == "crystalslurryfur" || _name == "furcrystalslurry" || _name == "furslurrycrystal" || _name == "slurrycrystalfur" || _name == "slurryfurcrystal" )
        {
            PlayerPrefs.SetInt("BoboCat",2);
            PlayerPrefs.SetString("LastUse", "BoboCat");
            Debug.Log("BoboCat opened");
            SceneManager.LoadScene("MiniGame");
        }
        
        else if (_name == "sparklesfurslurry" || _name == "sparklesslurryfur" || _name == "fursparklesslurry" || _name == "furslurrysparkles" || _name == "slurrysparklesfur" || _name == "slurryfursparkles" )
        {
            PlayerPrefs.SetInt("OsmoCat",2);
            PlayerPrefs.SetString("LastUse", "OsmoCat");
            Debug.Log("OsmoCat opened");
            SceneManager.LoadScene("MiniGame");
        }
        
        else if (_name == "sparklesfurfire" || _name == "sparklesfirefur" || _name == "firesparklesfur" || _name == "firefursparkles" || _name == "furfiresparkles" || _name == "fursparklesfire" )
        {
            PlayerPrefs.SetInt("NightLamp",2);
            PlayerPrefs.SetString("LastUse", "NightLamp");
            Debug.Log("Nightlamp opened");
            SceneManager.LoadScene("MiniGame");
        }
        
        else if (_name == "crystalfurfire" || _name == "crystalfirefur" || _name == "firefurcrystal" || _name == "firecrystalfur" || _name == "furcrystalfire" || _name == "furfirecrystal" )
        {
            PlayerPrefs.SetInt("Fox",2);
            PlayerPrefs.SetString("LastUse", "Fox");
            Debug.Log("fox opened");
            SceneManager.LoadScene("MiniGame");
        }
        
        else if (_name == "sparklesslurryfire" || _name == "sparklesfireslurry" || _name == "fireslurrysparkles" || _name == "firesparklesslurry" || _name == "slurryfiresparkles" || _name == "slurrysparklesfire" )
        {
            PlayerPrefs.SetInt("Jellyfish",2);
            PlayerPrefs.SetString("LastUse", "Jellyfish");
            Debug.Log("OsmoCat opened");
            SceneManager.LoadScene("MiniGame");
        }
        
        else if (_name == "firecrystalslurry" || _name == "firesslurrycrystal" || _name == "crystalfireslurry" || _name == "crystalslurryfire" || _name == "slurryfirecrystal" || _name == "slurrycrystalfire" )
        {
            PlayerPrefs.SetInt("Dragon",2);
            PlayerPrefs.SetString("LastUse", "Dragon");
            Debug.Log("Dragon opened");
            SceneManager.LoadScene("MiniGame");
        }
        
        else if (_name == "furslurryfire" || _name == "furfireslurry" || _name == "fireslurryfur" || _name == "firefurslurry" || _name == "slurryfirefur" || _name == "slurryfurfire" )
        {
            PlayerPrefs.SetInt("Garpy",2);
            PlayerPrefs.SetString("LastUse", "Garpy");
            Debug.Log("Garpy opened");
            SceneManager.LoadScene("MiniGame");
        }
        else if (_name == "crystalcrystalcrystal"  )
        {
            SceneManager.LoadScene(("Krayk"));
        }
        else
        {
            _boilerPic[1].SetActive(true);
            _boilerPic[0].SetActive(false);
            DeactivateAfterDelay();
        }


        _name = "";
        PlayerPrefs.SetInt("CookClicked",1);

    }
    
    
   
    public void DeactivateAfterDelay()
    {
        StartCoroutine(DeactivateCoroutine());
    }

    private IEnumerator DeactivateCoroutine()
    {
        // Ожидаем 2 секунды
        yield return new WaitForSeconds(2f);

        // Делаем объект неактивным
        _boilerPic[0].SetActive(true);
        _boilerPic[1].SetActive((false));
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
        PlayerPrefs.SetString("nameSTR",_name);
    }
}
