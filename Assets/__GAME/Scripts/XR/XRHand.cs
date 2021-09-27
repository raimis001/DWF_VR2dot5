using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public enum HandKind
{
	Left = 1, Right = 2
}

public class InHand
{
	public ITakeable item;
	public Transform parent;
	public Vector3 position;
	public Quaternion rotattion;
	public bool taken
	{
		get => _taken && item != null;
		set => _taken = value;
	}
	private bool _taken;

}
public class XRHand : MonoBehaviour
{
	public HandKind kind;
	[Header("Raycast")]
	public LayerMask raycastLayer;
	public Transform raycastPoint;
	public float raycastLenght;
	public bool alwaysShowLine;
	public Transform reaycastEnd;
	public LineRenderer raycastLine;
	private Ray raycast => new Ray(raycastPoint.position, raycastPoint.forward);

	[Header("Touchable")]
	public LayerMask touchLayer;
	public Transform touchPoint;
	public float touchRadius = 0.3f;
	readonly List<Collider> touches = new List<Collider>();

	[Header("Operate")]
	public Animator anim;
	public Transform objectPoint;


	[Header("Debug")]
	[SerializeField]
	private TMP_Text debugText;

	public Vector2 joystick =>
		kind == HandKind.Left ?
			XRManager.Input.Left.joystick.ReadValue<Vector2>() :
			XRManager.Input.Right.joystick.ReadValue<Vector2>();

	public bool triggerDown =>
		kind == HandKind.Left ?
		XRManager.Input.Left.triggerDown.triggered :
		XRManager.Input.Right.triggerDown.triggered;
	public bool triggerUp =>
		kind == HandKind.Left ?
		XRManager.Input.Left.triggerUp.triggered :
		XRManager.Input.Right.triggerUp.triggered;

	public float trigger =>
		kind == HandKind.Left ?
		XRManager.Input.Left.triggerValue.ReadValue<float>() :
		XRManager.Input.Right.triggerValue.ReadValue<float>();

	public bool triggerTouch =>
		kind == HandKind.Left ?
		XRManager.Input.Left.triggerTouch.triggered :
		XRManager.Input.Right.triggerTouch.triggered;

	public bool action =>
		kind == HandKind.Left ?
		XRManager.Input.Left.action.triggered :
		XRManager.Input.Right.action.triggered;

	public bool grabDown =>
		kind == HandKind.Left ?
		XRManager.Input.Left.grabDown.triggered :
		XRManager.Input.Right.grabDown.triggered;

	ITouchable touchable;
	IRaycaster raycaster;
	private void Start()
	{
	}
	private void OnEnable()
	{
		Application.onBeforeRender += BeforeRender;
	}
	private void Update()
	{
		anim.SetLayerWeight(2, triggerTouch ? 1 : 0);
		anim.SetFloat("Flex", triggerTouch ? 1 : 0);

		OperateRaycast();
		OperateTouchable();

		if (inHand.taken && grabDown)
			DropFromHand();
	}
	void BeforeRender()
	{

	}
	void OperateRaycast()
	{
		void disableRay()
		{
			if (raycaster != null)
				raycaster.OnExit(this);
			if (raycastLine)
				raycastLine.positionCount = 0;
			raycaster = null;

			if (alwaysShowLine && raycastLine)
			{
				raycastLine.useWorldSpace = true;
				raycastLine.positionCount = 2;
				raycastLine.SetPosition(0, raycastPoint.position);
				raycastLine.SetPosition(1, raycastPoint.position + raycastPoint.forward * raycastLenght);
			}
			if (reaycastEnd)
				reaycastEnd.gameObject.SetActive(false);
		}

		if (raycastLayer == 0)
		{
			disableRay();
			return;
		}


		if (!Physics.Raycast(raycast, out RaycastHit hit, raycastLenght, raycastLayer))
		{
			disableRay();
			return;
		}
		IRaycaster c = hit.collider.GetComponentInParent<IRaycaster>();
		if (c == null)
		{
			disableRay();
			return;
		}
		if (raycastLine)
		{
			raycastLine.useWorldSpace = true;
			raycastLine.positionCount = 2;
			raycastLine.SetPosition(0, raycastPoint.position);
			raycastLine.SetPosition(1, hit.point);
			if (reaycastEnd)
			{
				reaycastEnd.position = hit.point;
				reaycastEnd.gameObject.SetActive(true);
			}

		}

		c.collision = hit.collider;

		if (c == raycaster)
		{
			raycaster.OnHand(this);
			return;
		}

		if (raycaster != null)
			raycaster.OnExit(this);

		raycaster = c;
		raycaster.OnEnter(this);

	}
	void OperateTouchable()
	{
		void ExitTouch()
		{
			if (!touchable)
				return;

			touchable.OnExit(this);
			touchable.collision = null;
			touchable = null;
		}

		if (touchLayer == 0)
			return;

		touches.Clear();
		touches.AddRange(Physics.OverlapSphere(touchPoint.position, touchRadius, touchLayer));
		if (touches.Count < 1)
		{
			ExitTouch();
			return;
		}

		touches.Sort((c1, c2) => (Vector3.Distance(touchPoint.position, c1.transform.position).CompareTo(Vector3.Distance(touchPoint.position, c2.transform.position))));
		
		ITouchable touch = null;
		Collider coll = null;
		foreach (Collider c in touches)
		{
			touch = c.gameObject.GetComponentInParent<ITouchable>();
			if (!touch || touch.disabled)
				continue;
			coll = c;
			break;
		}
		if (!touch)
		{
			ExitTouch();
			return;
		}
		if (touchable == touch && coll == touchable.collision)
		{
			touchable.OnHand(this);
			return;
		}

		ExitTouch();

		touchable = touch;
		touchable.collision = coll;
		touchable.OnEnter(this);
	}

	internal readonly InHand inHand = new InHand();
	public void TakeInHand(ITakeable item)
	{
		if (inHand.taken)
			return;
		anim.SetInteger("Pose", 1);

		inHand.taken = true;
		inHand.item = item;
		inHand.parent = item.transform.parent;
		inHand.position = item.transform.position;
		inHand.rotattion = item.transform.rotation;

		item.transform.SetParent(objectPoint, true);

		inHand.item.OnTakeInHand();
		inHand.item.OnTakeHand.Invoke(this, inHand.item);

		item.transform.localEulerAngles = Vector3.zero;
		item.transform.localPosition = Vector3.zero;

	}
	public void DropFromHand(Transform point, bool disable)
	{
		if (!inHand.taken || !inHand.item)
			return;

		Vector3 pos = inHand.item.transform.position;
		pos.y = point.position.y;
		Vector3 euler = inHand.item.transform.eulerAngles;
		euler.x = 0;
		euler.z = 0;

		inHand.item.transform.SetParent(point, true);
		inHand.item.transform.localPosition = Vector3.zero;
		inHand.item.transform.localEulerAngles = Vector3.zero;
		inHand.item.OnDropFromHand(disable);

		inHand.item.OnDropHand.Invoke(this, inHand.item);

		anim.SetInteger("Pose", 0);
		inHand.item = null;
		inHand.taken = false;
	}

	public void DropFromHand(bool destroy = false)
	{
		if (!inHand.taken || !inHand.item)
			return;

		anim.SetInteger("Pose", 0);

		if (destroy)
		{
			Destroy(inHand.item.gameObject, 0.1f);
		}
		else
		{
			inHand.item.transform.SetParent(inHand.parent);
			inHand.item.transform.position = inHand.position;
			inHand.item.transform.rotation = inHand.rotattion;
			inHand.item.OnDropFromHand(false);
		}
		inHand.item.OnDropHand.Invoke(this, inHand.item);

		inHand.item = null;
		inHand.taken = false;
	}

	#region TOOLS
	private void OnDrawGizmos()
	{
		if (!touchPoint)
			return;

		Gizmos.color = Color.blue;
		Gizmos.DrawWireSphere(touchPoint.position, touchRadius);
	}
	public void DebugText(string message, bool append = false)
	{
		if (!debugText || !debugText.gameObject.activeInHierarchy)
			return;
		if (!append)
		{
			debugText.text = message;
			return;
		}
		debugText.text = debugText.text.Insert(0, message + "\n");
	}
	#endregion
}
