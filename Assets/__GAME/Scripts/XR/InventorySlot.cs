using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlot : MonoBehaviour, IRaycaster
{
	public int slotId;
	public Transform slotPoint;

	private Collider _collider;
	public Collider collision { get => _collider; set => _collider = value; }



	public void OnEnter(XRHand hand)
	{
		
	}

	public void OnExit(XRHand hand)
	{
		
	}

	public void OnHand(XRHand hand)
	{
		if (!hand.triggerDown)
			return;

		if (!hand.inHand.taken)
			//TODO remove frominventory
			return;

		if (!Manager.FreeSlot(slotId))
		{
			hand.DropFromHand(slotPoint, false);
		}
	}
}
