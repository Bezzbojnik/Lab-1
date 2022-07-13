using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private float _speed = 5f;

    void Update()
    {
        transform.position = transform.position + transform.forward * Time.deltaTime * _speed;
    }
}
