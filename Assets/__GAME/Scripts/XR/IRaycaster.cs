using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IRaycaster 
{
	public Collider collision { get; set; }
	void OnEnter(XRHand hand);
	void OnExit(XRHand hand);
	void OnHand(XRHand hand);
}
