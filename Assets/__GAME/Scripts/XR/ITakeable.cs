using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ITakeable : MonoBehaviour
{
	public string id;

	public UnityEvent<XRHand, ITakeable> OnTakeHand;
	public UnityEvent<XRHand, ITakeable> OnDropHand;

	public virtual void OnTakeInHand()
	{

	}

	public virtual void OnDropFromHand(bool disable)
	{

	}
}
