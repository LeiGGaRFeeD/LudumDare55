using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CorrectZone : MonoBehaviour
{
    [SerializeField] private GameObject _sucsessText;
    public AudioClip victorySound; // Аудиоклип, который будет воспроизводиться при победе
    private AudioSource audioSource; // Источник звука для воспроизведения аудиоклипа

    private bool _playerInside;
    // Start is called before the first frame update
    void Start()
    {
        _sucsessText.SetActive(false);
        // Получаем компонент AudioSource или добавляем его, если он отсутствует
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
        audioSource.playOnAwake = false; // Отключаем автоматическое воспроизведение
    }

    public void CreaturesOpening()
    {
        Debug.Log("Creature opening is working");
        if (_playerInside == true)
        {
            // Проверяем состояние каждого существа и загружаем сцену с задержкой
            CheckAndLoadSceneWithDelay("Slimeman", "Game");
            CheckAndLoadSceneWithDelay("Turtle", "Game");
            CheckAndLoadSceneWithDelay("Spider", "Game");
            CheckAndLoadSceneWithDelay("BoboCat", "Game");
            CheckAndLoadSceneWithDelay("OsmoCat", "Game");
            CheckAndLoadSceneWithDelay("NightLamp", "Game");
            CheckAndLoadSceneWithDelay("Fox", "Game");
            CheckAndLoadSceneWithDelay("Jellyfish", "Game");
            CheckAndLoadSceneWithDelay("Dragon", "Game");
            CheckAndLoadSceneWithDelay("Garpy", "Game");
        }
    }

    private void CheckAndLoadSceneWithDelay(string creatureKey, string sceneName)
    {
        if (PlayerPrefs.GetInt(creatureKey) == 2)
        {
            PlayerPrefs.SetInt(creatureKey, 1);
            PlayVictorySound(); // Воспроизводим звук победы
            StartCoroutine(LoadSceneAfterDelay(sceneName));

         //   Time.timeScale = 0;
        }
    }
    private void PlayVictorySound()
    {
        if (victorySound != null)
        {
            MoveCube.speed = 0;
            _sucsessText.SetActive(true);
            audioSource.PlayOneShot(victorySound);
        }
    }

    // Корутина для загрузки сцены с задержкой
    private IEnumerator LoadSceneAfterDelay(string sceneName)
    {
        yield return new WaitForSeconds(0.8f); // Задержка в 1 секунду
        SceneManager.LoadScene(sceneName);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        _playerInside = true;
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        _playerInside = false;
    }
    
    void Update()
    {
        Debug.Log("Player inside = " + _playerInside);
    }
}
