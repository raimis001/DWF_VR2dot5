using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fps
{

	public float frequency = 0.5F; // The update frequency of the fps
	public int nbDecimal = 1; // How many decimal do you want to display

	public string FpsString = ""; // The fps formatted into a string.

	private int frameRange = 60;
	private int averageFps;
	private int[] fpsBuffer;
	private int fpsBufferIndex;

	public void Update()
	{
		if (fpsBuffer == null || fpsBuffer.Length != frameRange)
		{
			InitBuffer();
		}

		UpdateFrameBuffer();
		CalculateFps();
	}

	private void InitBuffer()
	{

		if (frameRange <= 0)
		{
			frameRange = 1;
		}

		fpsBuffer = new int[frameRange];
		fpsBufferIndex = 0;
	}

	private void UpdateFrameBuffer()
	{
		fpsBuffer[fpsBufferIndex++] = (int)(1f / Time.unscaledDeltaTime);

		if (fpsBufferIndex >= frameRange)
		{
			fpsBufferIndex = 0;
		}
	}

	private void CalculateFps()
	{
		int sum = 0;

		for (int i = 0; i < frameRange; i++)
		{
			int fps = fpsBuffer[i];
			sum += fps;
		}

		averageFps = sum / frameRange;

		FpsString = averageFps.ToString("00");
	}
}



