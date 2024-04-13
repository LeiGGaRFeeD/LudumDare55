using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MoveCube : MonoBehaviour
{
    public Transform pointA; // Первая точка
    public Transform pointB; // Вторая точка
    public float speed = 5.0f; // Скорость перемещения

    private Transform target; // Текущая целевая точка

    void Start()
    {
        // Начинаем движение к точке A
        target = pointA;
    }

    void Update()
    {
        // Перемещаем объект к текущей целевой точке
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        // Проверяем, достиг ли объект целевой точки
        if (transform.position == target.position)
        {
            // Переключаем целевую точку
            target = target == pointA ? pointB : pointA;
        }
    }
}