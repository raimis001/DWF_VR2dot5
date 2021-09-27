using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakableRay : ITakeable, IRaycaster
{
	Collider _collider;
	public Collider collision { get => _collider; set => _collider = value; }

	public void OnEnter(XRHand hand)
	{
		
	}

	public void OnExit(XRHand hand)
	{
		
	}

	public void OnHand(XRHand hand)
	{
		if (hand.triggerDown)
			hand.TakeInHand(this);
	}

	
}
