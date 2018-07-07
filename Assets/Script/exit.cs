using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exit : MonoBehaviour {
	public int keluar;

	public void tombolExit(){
		if (keluar == 1) 
		{
			Application.Quit ();
		}

	}
}