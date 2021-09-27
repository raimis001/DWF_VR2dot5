using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRMove : MonoBehaviour
{
	static XRMove instance;
	public static Vector3 position => instance.transform.position;

	public float moveSpeed = 3;
	public bool blockX = false;
	public bool blockZ = false;

	public float rotAngle = 10;
	public float rotTime = 0.1f;
	public float rotDelay = 0.05f;

	bool isRotate;

	Rigidbody rigi;
	Transform cameraTransform;
	Vector3 axis;

	private void Awake()
	{
		instance = this;

		rigi = GetComponent<Rigidbody>();
		cameraTransform = Camera.main.transform;
	}

	internal static void Teleport(Transform destination)
	{
		Teleport(destination.position);
		Vector3 euler = instance.transform.eulerAngles;
		euler.y = destination.eulerAngles.y;
		instance.transform.eulerAngles = euler;
	}


	internal static void Teleport(Vector3 teleportPosition)
	{
		Vector3 pos = teleportPosition - instance.cameraTransform.localPosition;
		pos.y = teleportPosition.y;

		instance.transform.position = pos;
	}

	private void Update()
	{
		axis = new Vector3(XRManager.LeftHand.joystick.x, 0, XRManager.LeftHand.joystick.y);
		axis.x = Mathf.Abs(axis.x) > 0.7f ? axis.x : axis.x / 3f;
		axis.z = Mathf.Abs(axis.z) > 0.7f ? axis.z : axis.z / 3f;

		if (isRotate)
			return;
		if (Mathf.Abs(XRManager.RightHand.joystick.x) < 0.75f)
			return;

		StartCoroutine(Rotate(XRManager.RightHand.joystick.x));
	}


	private void FixedUpdate()
	{
		
		Vector3 step = Quaternion.AngleAxis(cameraTransform.eulerAngles.y, Vector3.up) * axis * moveSpeed;
		step.y = Mathf.Clamp(rigi.velocity.y, -10,1);
		if (blockX)
			step.x = 0;
		if (blockZ)
			step.z = 0;

		rigi.velocity = step;
	}

	IEnumerator Rotate(float direction)
	{
		isRotate = true;
		int steps = Mathf.CeilToInt(rotTime / Time.deltaTime);
		float angle = (rotAngle / steps) * Mathf.Sign(direction);

		for (int i = 0; i < steps; i++)
		{
			transform.RotateAround(cameraTransform.position, Vector3.up,  angle);
			yield return null;
		}

		yield return new WaitForSeconds(rotDelay);
		isRotate = false;
	}

}
