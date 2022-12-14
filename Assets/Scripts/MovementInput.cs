
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementInput : MonoBehaviour {


	public float RotationSpead = 50f;
	public float Speed = 1f;
    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float VertitalInput = Input.GetAxis("Vertical");
        Vector3 movemetDirection = new Vector3(horizontalInput, 0, VertitalInput);
        movemetDirection.Normalize();
        transform.position = transform.position + movemetDirection * Speed * Time.deltaTime;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movemetDirection), RotationSpead * Time.deltaTime); 

	}
}
