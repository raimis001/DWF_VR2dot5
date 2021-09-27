using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActionClick : Clickable, IRaycaster
{
	public UnityEvent<string> OnAction;
	public string acceptString;

	Collider _collider;
	public Collider collision { 
		get => _collider; 
		set => _collider = value; 
	}

	public override void OnDoAction()
	{
		OnAction.Invoke(id);
	}

	public void OnEnter(XRHand hand)
	{
		
	}

	public void OnExit(XRHand hand)
	{
		
	}

	public void OnHand(XRHand hand)
	{
		if (hand.triggerDown)
		{
			if (acceptString != "")
			{
				if (!hand.inHand.taken)
					return;
				if (hand.inHand.item.id != acceptString)
					return;
			}
			OnAction.Invoke(id);
		}
	}
}
