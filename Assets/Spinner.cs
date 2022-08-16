using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    public float speed = 0.0f;
    private float currentAngle;
    public Vector3 CurrentAngle => new Vector3(0f, currentAngle, 0f);
	void Update()
    {
        currentAngle += speed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, currentAngle, 0);
        //transform.Rotate(transform.up, speed);
    }
}
