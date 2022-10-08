using System;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        var position = transform.position;

        var step = _speed*Time.deltaTime;//создадим переменную step, которая равна значению скорости, умноженной на deltaTime
        
        if(Input.GetKey(KeyCode.W))//если игрок нажимает W
        {
            position.z+=step;//машина сделает шаг по оси Z
        }
        else if(Input.GetKey(KeyCode.S))//иначе, если игрок нажимает S 
        {
            position.z-=step;//машина сделает шаг по оси Z в обратную сторону
        }
        else if(Input.GetKey(KeyCode.D))//иначе, если игрок нажимает S 
        {
            position.x+=step;//машина сделает шаг по оси Z в обратную сторону
        }
        else if(Input.GetKey(KeyCode.A))//иначе, если игрок нажимает S 
        {
            position.x-=step;//машина сделает шаг по оси Z в обратную сторону
        }

        transform.position = position;
    }
}