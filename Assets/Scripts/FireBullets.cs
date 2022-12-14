using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullets : MonoBehaviour
{
    [SerializeField]
    private GameObject _bullet;
    [SerializeField]
    private float _timer = 2f;
    //private float timerCount = 0f;

    
    private int _counter;
    [SerializeField]
    private int _maxCounter;

    private void Start()
    {
        StartCoroutine(FireBullets_CR());

    }

    IEnumerator FireBullets_CR()
    {
        Debug.Log("Inicio coroutine");
        for (int i = 0; i<_maxCounter; i++)
        {
            _counter++;
            Instantiate(_bullet, transform.position, transform.rotation);
            yield return new WaitForSeconds(_timer);
        }
        Debug.Log("Fin coroutine");
    }
}
