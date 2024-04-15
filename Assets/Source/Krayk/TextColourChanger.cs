using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextColorChanger : MonoBehaviour
{
    public Text textComponent; // Ссылка на компонент Text
    public float changeInterval = 0.5f; // Интервал изменения цвета в секундах

    private void Start()
    {
        if (textComponent == null)
        {
            textComponent = GetComponent<Text>(); // Получаем компонент Text, если он не был назначен
        }
        StartCoroutine(ChangeTextColor());
    }

    private IEnumerator ChangeTextColor()
    {
        while (true) // Бесконечный цикл
        {
            textComponent.color = new Color(Random.value, Random.value, Random.value); // Устанавливаем случайный цвет
            yield return new WaitForSeconds(changeInterval); // Ждем указанный интервал времени
        }
    }
}