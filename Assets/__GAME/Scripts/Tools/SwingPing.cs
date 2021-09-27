using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingPing : MonoBehaviour
{
	public Vector3 axis = new Vector3(0, 0, 1);
	public float  speed = 1;
	public float amplitude = 10;
	Vector3 rot;
	void Start()
	{
		
		rot = transform.localEulerAngles;
	}

	// Update is called once per frame
	void Update()
	{
		float p = Mathf.PingPong(Time.time * speed, 1) - 0.5f;

		transform.localEulerAngles = rot + axis * p * amplitude;

	}
}
