using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ElevatorInside : MonoBehaviour {

	private bool approach;

	void Start()
	{
		approach = false;
	}
	
	void Update()
	{
		if(approach)
		{
			if(Input.GetKey(KeyCode.E))
			{
				OnMouseDown();
			}
		}

	}

	void OnTriggerEnter(Collider coll)
	{
		if(coll.tag == "ElevInside")
		{
			approach = true;
		}
	}

	void OnMouseDown()
	{
		SceneManager.LoadScene(2);
	}
}
