using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    private float _speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        //Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + transform.forward * Time.deltaTime * _speed;
    }
}
