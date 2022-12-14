using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimRotation : MonoBehaviour
{
    [SerializeField]
    private Transform _target;

    private void Update()
    {
        Vector3 targetOrientatation = _target.position - transform.position;
        Debug.DrawRay(transform.position, targetOrientatation, Color.green);

        Quaternion targetOrientationQuaternion = Quaternion.LookRotation(targetOrientatation);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetOrientationQuaternion, Time.deltaTime);
    }


}
