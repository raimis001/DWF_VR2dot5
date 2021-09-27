using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(ITouchable))]
public class Takeable : ITakeable, IOperateTouch
{


	internal ITouchable touchable;
	private void Start()
	{
		touchable = GetComponentInChildren<ITouchable>(false);
	}
	public void OnHandAction(XRHand hand, ITouchable item)
	{
		hand.TakeInHand(this);
		
	}

	public override void OnTakeInHand()
	{
		touchable.disabled = true;
	}

	public override void OnDropFromHand(bool disable)
	{
		touchable.disabled = disable;
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
