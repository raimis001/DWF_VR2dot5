using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandPanel : MonoBehaviour
{

	public GameObject panel;

	XRHand hand;

	void Start()
	{
		if (panel)
			panel.SetActive(false);

		hand = GetComponentInParent<XRHand>();
	}

	// Update is called once per frame
	void Update()
	{
		if (!panel)
			return;
		if (!hand)
			return;
		if (!hand.action)
			return;

		panel.SetActive(!panel.activeInHierarchy);
	}
}
