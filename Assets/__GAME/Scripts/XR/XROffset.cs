using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class XROffset : MonoBehaviour
{
	public float targetHeight;
	public Transform cameraTransform;

	List<XRInputSubsystem> subsystems = new List<XRInputSubsystem>();

	private void OnEnable()
	{
		InputDevices.deviceConnected += DeviceConnected;
	}


	private void OnDisable()
	{
		InputDevices.deviceConnected -= DeviceConnected;
	}

	private void DeviceConnected(InputDevice obj)
	{
		//Debug.LogFormat("Device connected: {0} - head: {1}", obj.name, obj.characteristics.HasFlag(InputDeviceCharacteristics.HeadMounted));
	}

	IEnumerator Start()
	{
		cameraTransform = Camera.main.transform;

		bool systemInit = false;
		while (true) {
			SubsystemManager.GetInstances(subsystems);

			foreach (XRInputSubsystem sub in subsystems)
			{
				if (sub == null || !sub.running)
					continue;
				
				//Debug.Log(sub.GetTrackingOriginMode());
				systemInit = sub.TryRecenter();
			}

			if (systemInit)
				break;

			yield return null;
		}
		yield return new WaitForSeconds(1f);
		transform.localPosition = new Vector3(transform.localPosition.x, targetHeight - cameraTransform.localPosition.y, transform.localPosition.z);
	}

	void Update()
	{

	}
}
