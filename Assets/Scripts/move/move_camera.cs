using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_camera : MonoBehaviour
{
    // ������ ���������� ��� ������ � ������
    [SerializeField] private GameObject _camera , player;

    // ����� ������� ������
    void Update()
    {
        _camera.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
    }


}
