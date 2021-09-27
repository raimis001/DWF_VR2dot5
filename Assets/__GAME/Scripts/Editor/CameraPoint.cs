using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPoint : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Manager.LeftPressed)
			transform.Translate(0, 0, -14);
		if (Manager.RightPressed)
			transform.Translate(0, 0, 14);
	}
}
