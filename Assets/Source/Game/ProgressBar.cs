using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] private GameObject _cookButton;
    public Slider slider; // Ссылка на UI Slider
     float fillTime = 3.7f; // Время заполнения в секундах

    private void Start()
    {
        _cookButton.SetActive(false);
        if (slider == null)
        {
            slider = GetComponent<Slider>(); // Получаем компонент Slider, если он не был назначен
        }
        StartCoroutine(FillBar());
    }

    private IEnumerator FillBar()
    {
        float elapsedTime = 0f; // Время, прошедшее с начала заполнения

        while (elapsedTime < fillTime)
        {
            elapsedTime += Time.deltaTime; // Увеличиваем прошедшее время
            slider.value = elapsedTime / fillTime; // Обновляем значение слайдера
            yield return null; // Ждем следующего кадра
        }

        slider.value = 1f; // Устанавливаем полное значение после заполнения
        _cookButton.SetActive(true); // Активируем кнопку cookButton
        // Здесь можно добавить дополнительные действия после завершения заполнения
    }
}