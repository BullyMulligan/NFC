using System;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField]
    private Car _car;//Поле объекта, за которым следит камера

    [SerializeField] private Vector3 offset;

    private void Awake()//когда камера появляется в игре
    {
        _car = FindObjectOfType<Car>();//она ищет объект, который равен объекту на сцене типа Car
    }

    private void LateUpdate()
    {
        transform.position = _car.transform.position+offset;//позиция камеры равна позиции объекта + отступ
    }
}