using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickable : MonoBehaviour
{
	public string id;
	public virtual void OnDoAction()
	{

	}

	private void OnMouseDown()
	{
		OnDoAction();		
	}
}
