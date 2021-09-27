using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;




public class ITouchable : MonoBehaviour
{
	public string id;
	public bool disabled;

	public UnityEvent<XRHand, ITouchable> OnEnterHand;
	public UnityEvent<XRHand, ITouchable> OnExitHand;
	public UnityEvent<XRHand, ITouchable> OnOverHand;
	public UnityEvent<XRHand, ITouchable> OnActionHand;


	public Collider collision { get; set; }
  public virtual void OnEnter(XRHand hand)
	{
		OnEnterHand.Invoke(hand, this);
	}

	public virtual void OnExit(XRHand hand)
	{
		OnExitHand.Invoke(hand, this);
	}

	public virtual void OnHand(XRHand hand)
	{
		OnOverHand.Invoke(hand, this);
		if (hand.triggerDown)
		{
			OnActionHand.Invoke(hand, this);
		}
	}
    
}
