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
        SceneManager.LoadScene("MainMenu");
    }

    public void GoToGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void GoToMiniGame()
    {
        SceneManager.LoadScene("MiniGame");
    }
    public void GoToAutores()
    {
        SceneManager.LoadScene("Autores");
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
            if (Input.GetKeyDown(KeyCode.Alpha0) == true)
            {
                Debug.Log(("Reloading scene"));
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}
