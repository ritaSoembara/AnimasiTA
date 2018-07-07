using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.orientation = ScreenOrientation.Landscape;
	}

	public void kembali()
	{
		Screen.orientation = ScreenOrientation.Portrait;
	}
}
