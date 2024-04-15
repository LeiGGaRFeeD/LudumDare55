using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    private static MusicPlayer instance = null;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Запрещаем уничтожение объекта при смене сцены
        }
        else if (instance != this)
        {
            Destroy(gameObject); // Уничтожаем дубликаты
        }
    }

    // Другие методы компонента AudioSource, если необходимо
}