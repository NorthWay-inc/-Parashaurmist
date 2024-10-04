using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_script : MonoBehaviour
{
    // создаём 2 переменные чтобы определить игрока на сцене и его скорость передвижения по оси Y
    public Rigidbody2D player;
    [SerializeField] private float _hspeed;

    void Awake()
    {
        player = player.GetComponent<Rigidbody2D>();
    }

    // создание функций передвижения
    public void Move_right()
    {
        player.velocity = transform.TransformDirection(new Vector2(_hspeed, player.velocity.y));
    }

    public void Move_left()
    {
        player.velocity = transform.TransformDirection(new Vector2(-_hspeed, player.velocity.y));
    }

    // останавливает движение игрока когда отпускает кнопку
    public void Move_stop()
    {
        player.velocity = transform.TransformDirection(new Vector2(0 , player.velocity.y));
    }


}
