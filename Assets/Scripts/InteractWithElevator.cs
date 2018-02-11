using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InteractWithElevator : MonoBehaviour {

	private bool approach;
	public Text pressEToInteract;
	public Light secondMainLight;

	void Start()
	{
		approach = false;
		pressEToInteract.enabled = false;
	}

	void Update()
	{
		if((approach) && (secondMainLight.gameObject.activeSelf))
		{
			pressEToInteract.enabled = true;
		} else {
			pressEToInteract.enabled = false;
		}
	}

	void OnTriggerEnter(Collider coll)
	{
		if(coll.tag == "ElevatorButton")
		{
			approach = true;
		}
	}

	void OnTriggerExit(Collider coll)
	{
			if(coll.tag == "ElevatorButton")
			{
				approach = false;
			}
	}
}
