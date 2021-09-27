using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class DialogAnswer
{
	public string description;
	public string nextDialog;
	public UnityEvent<string> AfterDialog;
}
[System.Serializable]
public class DialogItem
{
	public string id;
	public string name;
	public string description;
	public UnityEvent<string> BeforeDialog;
	public List<DialogAnswer> answerList;
}
public class DialogManager : MonoBehaviour
{
	static DialogManager instance;

  public GameObject dialogPanel;
	public TMP_Text caption;
	public TMP_Text description;

	public List<GameObject> answePanels;
	public List<TMP_Text> answerTexts;

	public List<DialogItem> dialogs;

	private void Awake()
	{
		instance = this;
	}

	public static void ShowDialog(string id)
	{
		foreach (var item in instance.dialogs)
		{
			if (item.id == id)
			{
				instance.Show(item);
				return;

			}
		}
	}

	DialogItem currentItem;

	void Show(DialogItem item)
	{
		currentItem = item;

		caption.text = item.name;
		description.text = item.description;

		foreach (GameObject g in answePanels)
			g.SetActive(false);

		for (int i = 0; i < item.answerList.Count; i++)
		{
			answePanels[i].SetActive(true);
			answerTexts[i].text = item.answerList[i].description;
		}
		currentItem.BeforeDialog.Invoke(currentItem.id);
		dialogPanel.SetActive(true);
	}

	public void OnAnswer(string message)
	{
		Debug.Log(message);

		int i = int.Parse(message);

		currentItem.answerList[i].AfterDialog.Invoke(currentItem.id);

		string next = currentItem.answerList[i].nextDialog;
		if (next != "")
			ShowDialog(next);

	}

}
