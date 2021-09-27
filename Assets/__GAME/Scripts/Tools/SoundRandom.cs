using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundRandom : MonoBehaviour
{

	public AudioSource sound;
	public Vector2 delay;

	void Start()
	{
		if (!sound)
			sound = GetComponent<AudioSource>();

		float d = Random.Range(delay.x, delay.y);
		Invoke(nameof(PlayRandom), d);
	}

	void PlayRandom()
	{
		float d = Random.Range(delay.x, delay.y);
		Invoke(nameof(PlayRandom), d);
		sound.Play();
	}

}
