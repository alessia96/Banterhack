using UnityEngine;
using System.Collections;

public class Faces : MonoBehaviour {

	protected GameObject[] screens;

	// Use this for initialization
	void Start () {
		screens = GameObject.FindGameObjectsWithTag ("LCD");
		//InvokeRepeating("SwapScreens", 0, 0.6F);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void SwapScreens() {
		foreach(GameObject flicker in screens)
		{
			if (Random.value > 0.7f) {
				flicker.SetActive(false);
			} else {
				flicker.SetActive(true);
			}
		}
	}
}
