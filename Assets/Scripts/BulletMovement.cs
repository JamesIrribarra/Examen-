using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed = 2f;
    [SerializeField]
    private float _timelife = 5f;

    //public object _explosionEffect;

    private void Start()
    {
        Destroy(gameObject, _timelife);
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * _speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //Instantiate (_explosionEffect, transform.position, Quaternion.identity);
            Destroy (gameObject);
        }
    }
}
