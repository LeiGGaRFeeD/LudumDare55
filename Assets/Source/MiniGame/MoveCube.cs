using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

public class MoveCube : MonoBehaviour
{
    public Transform pointA; // Первая точка
    public Transform pointB; // Вторая точка
    public static float speed = 5.0f; // Скорость перемещения

    [Header("Reference speed")] [SerializeField]
    private float _refSpeed;

    [Header("Random settings")] [SerializeField]
    private bool _randomIsActivated;
    [SerializeField] private float min;
    [SerializeField] private float max;
    

    private Transform target; // Текущая целевая точка

    void Start()
    {
        // Начинаем движение к точке A
        target = pointA;
        if (_randomIsActivated == true)
        {
            speed = Random.RandomRange(min, max);
        }
        else
        {
            speed = _refSpeed;
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
     //   _playerInside = false;
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