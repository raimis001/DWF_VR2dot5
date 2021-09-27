using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

	public static bool LeftPressed => instance.input.Move.Left.triggered;
	public static bool RightPressed => instance.input.Move.Right.triggered;

	static readonly Dictionary<string, int> inventory = new Dictionary<string, int>();
	static readonly Dictionary<int, bool> slots = new Dictionary<int, bool>() {
		{0, false },{1, false },{2, false },{3, false },{4, false },{5, false },{6, false }
	};

	static Manager instance;
	InputController input;

	public static bool AddInventory(string id, int slot)
	{
		if (slots[slot])
			return false;

		slots[slot] = true;

		if (inventory.ContainsKey(id))
		{
			inventory[id]++;
		} else
		{
			inventory.Add(id, 1);
		}
		return true;
	}

	public static bool HasInventory(string id)
	{
		return inventory.ContainsKey(id) && inventory[id] > 0;
	}

	public static bool RemoveInventory(string id)
	{
		if (!HasInventory(id) )
			return false;

		inventory[id]--;
		return true;
	}

	public static bool FreeSlot(int slot)
	{
		return slots[slot];
	}

	private void Awake()
	{
		instance = this;
		input = new InputController();
	}

	private void OnEnable()
	{
		input.Enable();
	}
	private void OnDisable()
	{
		input.Disable();
	}
	private void Update()
	{
		
	}
}
