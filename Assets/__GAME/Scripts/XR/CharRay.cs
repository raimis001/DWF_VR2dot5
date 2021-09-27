using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharRay : MonoBehaviour, IRaycaster
{
	public string startDialog;

	public AudioSource sound;

	readonly List<string> dialogs = new List<string>();

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
		if (!hand.triggerDown)
			return;

		
	}

	public void OnEndChannel()
	{
		DialogManager.ShowDialog(startDialog);
		sound.Play();
	}

}
