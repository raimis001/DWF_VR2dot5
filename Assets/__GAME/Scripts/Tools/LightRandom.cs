using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRandom : MonoBehaviour
{
	new public Light light;

	public bool animateColor = true;
	public Gradient colors;
	public float colorSpeed = 1;

	public float intensity;
	public float intSpeed = 1;

	float intSeed;
	float colSeed;
	float intStart;

	void Start()
	{

		intSeed = Random.value;
		colSeed = Random.value;

		if (!light)
			light = GetComponent<Light>();

		if (!light)
			return;

		intStart = light.intensity;
	}

	void Update()
	{
		if (!light)
			return;

		float it = Mathf.PerlinNoise(Time.time * intSpeed, intSeed) - 0.5f;
		light.intensity = intStart + it * intensity;

		if (!animateColor)
			return;

		float cl = Mathf.PerlinNoise(Time.time * colorSpeed, colSeed);
		light.color = colors.Evaluate(cl);

	}
}
