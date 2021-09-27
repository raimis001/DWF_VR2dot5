using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class CameraGizmos : MonoBehaviour
{
#if UNITY_EDITOR
	[Range(0, 360)]
	public float angle = 60;

	[Range(0, 2)]
	public float length = 1;

	private void OnDrawGizmos()
	{
		float a = 360 - angle * 0.5f;
		Handles.color = new Color(0.259434f, 0.9613943f, 1, 0.5f);
		//Handles.DrawWireArc(transform.position, Vector3.up, Quaternion.AngleAxis(a, Vector3.up) * transform.forward, angle, length);
		Handles.DrawSolidArc(transform.position, Vector3.up, Quaternion.AngleAxis(a, Vector3.up) * transform.forward, angle, length);
	}
	private void OnDrawGizmosSelected()
	{
		float a = 360 - angle * 0.5f;
		Handles.color = new Color(0.259434f, 0.9613943f, 1, 0.1f);
		Handles.DrawSolidArc(transform.position, Vector3.up, Quaternion.AngleAxis(a, Vector3.up) * transform.forward, angle, length);
	}
#endif
}
