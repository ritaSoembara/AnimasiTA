using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dataLoad : MonoBehaviour {

	public string namaScene; 

	public void load(){
		SceneManager.LoadScene(PlayerPrefs.GetString("namaScene"));

	}
}