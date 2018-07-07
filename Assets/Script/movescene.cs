using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class movescene : MonoBehaviour {

	public void moveScene(string sceneName)
	{
		PlayerPrefs.SetString("namaScene",Application.loadedLevelName);
		SceneManager.LoadScene(sceneName);
	}
}