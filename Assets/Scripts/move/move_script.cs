using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_script : MonoBehaviour
{
    // ������ 2 ���������� ����� ���������� ������ �� ����� � ��� �������� ������������ �� ��� Y
    public Rigidbody2D player;
    [SerializeField] private float _hspeed;

    void Awake()
    {
        player = player.GetComponent<Rigidbody2D>();
    }

    // �������� ������� ������������
    public void Move_right()
    {
        player.velocity = transform.TransformDirection(new Vector2(_hspeed, player.velocity.y));
    }

    public void Move_left()
    {
        player.velocity = transform.TransformDirection(new Vector2(-_hspeed, player.velocity.y));
    }

    // ������������� �������� ������ ����� ��������� ������
    public void Move_stop()
    {
        player.velocity = transform.TransformDirection(new Vector2(0 , player.velocity.y));
    }


}
