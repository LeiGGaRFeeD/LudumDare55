using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChargeBar : MonoBehaviour
{
    public Slider slider; // Ссылка на UI Slider
    public float chargeTime = 3f; // Время зарядки в секундах

    private void Start()
    {
        if (slider == null)
        {
            slider = GetComponent<Slider>(); // Получаем компонент Slider, если он не был назначен
        }
        StartCoroutine(Charge());
    }

    private IEnumerator Charge()
    {
        float elapsedTime = 0f; // Время, прошедшее с начала зарядки

        while (elapsedTime < chargeTime)
        {
            elapsedTime += Time.deltaTime; // Увеличиваем прошедшее время
            slider.value = elapsedTime / chargeTime; // Обновляем значение слайдера
            yield return null; // Ждем следующего кадра
        }

        slider.value = 1f; // Устанавливаем полное значение после зарядки
        // Здесь можно добавить дополнительные действия после завершения зарядки
    }
}