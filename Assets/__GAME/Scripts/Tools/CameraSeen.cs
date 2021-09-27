using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSeen : MonoBehaviour
{
	public Vector3 delta = new Vector3(0, 180, 0);

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		transform.LookAt(Camera.main.transform);
		transform.Rotate(delta);
		transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
	}
}
