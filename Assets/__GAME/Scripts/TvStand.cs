using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class TvStand : MonoBehaviour, IRaycaster
{
	public List<GameObject> panels;
	public List<string> texts;
	public TMP_Text hintText;

	Collider _collision;
	public Collider collision { get => _collision; set => _collision = value; }

	private int  tvStatus = 0;

	public UnityEvent OnChanellEnd;

	private void Start()
	{
		hintText.gameObject.SetActive(false);
	}

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
			return;
		if (hand.inHand.item.id != "tvController")
			return;

		if (tvStatus == 0)
		{
			hintText.gameObject.SetActive(true);
			hintText.text = texts[tvStatus];
			tvStatus++;
			return;
		}

		if (tvStatus >= texts.Count)
			return;

		hintText.text = texts[tvStatus];
		tvStatus++;
		if (tvStatus >= texts.Count)
			OnChanellEnd.Invoke();

	}

	public void TurnOff(string dialogId)
	{
		foreach (GameObject g in panels)
		{
			g.SetActive(false);
		}
	}

	
}
