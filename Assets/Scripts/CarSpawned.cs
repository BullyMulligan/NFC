using UnityEngine;

public class CarSpawned : MonoBehaviour
{
    [SerializeField] //добавляем, чтобы поле было доступно в нашем инспекторе в Юнити
    private GameObject _prefab;

    private void Awake()
    {   
        Instantiate(_prefab);//спавним прехаб машины  
    }
}