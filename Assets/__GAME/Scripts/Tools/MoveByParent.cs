using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByParent : MonoBehaviour
{
  public Transform follow;

	private void LateUpdate()
	{
		if (!follow)
			return;

		transform.position = new Vector3(follow.position.x, transform.position.y, follow.position.z);
		//transform.eulerAngles = new Vector3(0, follow.eulerAngles.y, 0);
	}
}
