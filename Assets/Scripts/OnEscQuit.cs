using UnityEngine;
using System.Collections;

public class OnEscQuit : MonoBehaviour {

	void Update()
	{
		if(Input.GetKey(KeyCode.Escape))
		{
			Application.Quit();
		}
	}
}
