using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TMPro.Examples;
using UnityEngine;
using Unity.IO;

public class main_script : MonoBehaviour
{
    // создаём переменные для игрока , земли и префабов чтобы можно было сделать генерацию объектов
    [SerializeField] private GameObject Player, Earth;
    [SerializeField] private List<GameObject> Prefab_list;
    // нужно ли продолжать работу скрипта или нет
    [SerializeField] private bool working = true;
    // последний префаб созданный скриптом
    private GameObject Curient_prefab;
    private int List_leight;
    private Quaternion Prefabs_rotation;

    void Start()
    {
        //Debug.Log("ok");
        List_leight = Prefab_list.Count;
        StartCoroutine("Spawner");
        //Debug.Log("ok");
    }

    public IEnumerator Spawner()
    {
        Debug.Log("1.1");
        Curient_prefab = Instantiate(Prefab_list[UnityEngine.Random.Range(0, List_leight - 1)], new Vector2(0, Player.transform.position.y - 10), Prefabs_rotation);
        while (working)
        {
            if (Curient_prefab.transform.position.y < 14)
            {
                Debug.Log("1.2");
                working = false;
            }
            else if (Curient_prefab.transform.position.y > 14)
            {
                Debug.Log("1.3");
                Curient_prefab = Instantiate(Prefab_list[UnityEngine.Random.Range(0, List_leight)], new Vector2(0, Curient_prefab.transform.position.y - 15), Prefabs_rotation);
            }
            yield return new WaitForFixedUpdate();
        }
        Debug.Log("1.4");
        
    }
    

}
