using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHelper : MonoBehaviour
{
    [SerializeField]private bool _debugIsOn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void GoToMainMenu()
    {
        StartCoroutine(DelayedLoadScene("MainMenu", 1f));
    }

    public void GoToGame()
    {
        StartCoroutine(DelayedLoadScene("Game", 1f));
    }

    public void GoToMiniGame()
    {
        StartCoroutine(DelayedLoadScene("MiniGame", 1f));
    }
    public void GoToAutores()
    {
        StartCoroutine(DelayedLoadScene("Autores", 1f));
    }
    public void GoToKrayk()
    {
        StartCoroutine(DelayedLoadScene("Krayk", 1f));
    }


    public void quitFromGame()
    {
        Debug.Log(("quit from application"));
        Application.Quit();
    }
    private IEnumerator DelayedLoadScene(string sceneName, float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }
    // Update is called once per frame
    void Update()
    {
        if ( _debugIsOn == true)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1) == true)
            {
                Debug.Log(("Loading Main menu"));
                SceneManager.LoadScene("MainMenu");
            }
            if (Input.GetKeyDown(KeyCode.Alpha2) == true)
            {
                Debug.Log(("Loading Game"));
                SceneManager.LoadScene("Game");
            }
            if (Input.GetKeyDown(KeyCode.Alpha3) == true)
            {
                Debug.Log(("Loading Mini Game"));
                SceneManager.LoadScene("MiniGame");
            }
            if (Input.GetKeyDown(KeyCode.Alpha4) == true)
            {
                Debug.Log(("Loading Test Scene"));
                SceneManager.LoadScene("TestScene");
            }
            if (Input.GetKeyDown(KeyCode.Alpha5) == true)
            {
                Debug.Log(("Loading Autores"));
                SceneManager.LoadScene("Autores");
            }
            if (Input.GetKeyDown(KeyCode.Alpha6) == true)
            {
                Debug.Log(("Krayg scene"));
                SceneManager.LoadScene("Krayk");
            }
            if (Input.GetKeyDown(KeyCode.Alpha0) == true)
            {
                Debug.Log(("Reloading scene"));
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}
