using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InteractWithComputer : MonoBehaviour {

	private bool approach;
	public Light mainLight;
	public Text pressEToInteract;
	public Light switchLight;
	public GameObject flickerLight;
	private bool dontDoAgain;
	
	void Start()
	{
		approach = false;
		mainLight.enabled = true;
		pressEToInteract.enabled = false;
		switchLight.enabled = false;
		dontDoAgain = false;
	}
	
	void Update()
	{
		if((approach) && (!dontDoAgain))
		{
			pressEToInteract.enabled = true;

			if(Input.GetKey(KeyCode.E) && (!dontDoAgain))
			{
				mainLight.enabled = false;
				flickerLight.SetActive(false);
				switchLight.enabled = true;
				dontDoAgain = true;
			}
		} else {
			pressEToInteract.enabled = false;
		}
	}

	void OnTriggerEnter(Collider coll)
	{
		if(coll.tag == "Computer")
		{
			approach = true;
		}
	}

	void OnTriggerExit(Collider coll)
	{
		if(coll.tag == "Computer")
		{
			approach = false;
		}
	}
}
