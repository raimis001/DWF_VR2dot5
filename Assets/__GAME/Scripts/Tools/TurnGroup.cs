using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnGroup : MonoBehaviour
{
  public GameObject[] group;
	public bool startOn;




	private void Start()
	{
		foreach (GameObject g in group)
		{
			g.SetActive(startOn);
		}
	}

	public void OnAction(string id)
	{
		foreach (GameObject g in group)
		{
			g.SetActive(!g.activeInHierarchy);
		}
	}
}
