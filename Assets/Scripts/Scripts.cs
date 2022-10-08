using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scripts : MonoBehaviour
{
    // Запускается единожды до старта первого кадра
    void Start()
    {
        
    }

    //Запускается при создании объекта
    void Awake()
    {
        Debug.Log("Моя скорость:" + NewSpeed._speed);
    }

    // Запускается каждый кадр
    void Update()
    {
        
    }
}
