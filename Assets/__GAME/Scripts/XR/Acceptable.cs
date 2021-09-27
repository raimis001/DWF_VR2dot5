using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(ITouchable))]
public class Acceptable : MonoBehaviour, IOperateTouch
{
	public Transform acceptPoint;

	public UnityEvent<ITakeable> OnAccept;
	public UnityEvent<ITakeable> OnRemove;

	public void OnHandAction(XRHand hand, ITouchable item)
	{
		if (!hand.inHand.taken)
			return;


		ITakeable take = hand.inHand.item;
		take.OnTakeHand.AddListener(OnTakeHand);

		hand.DropFromHand(acceptPoint ? acceptPoint : transform, false);
		OnAccept.Invoke(take);
	}
	void OnTakeHand( XRHand hand, ITakeable item)
	{
		item.OnTakeHand.RemoveListener(OnTakeHand);
		OnRemove.Invoke(item);
	}

	public void OnHandEnter(XRHand hand, ITouchable item)
	{
		
	}

	public void OnHandExit(XRHand hand, ITouchable item)
	{
		
	}

	public void OnHandOwer(XRHand hand, ITouchable item)
	{
		
	}
}
