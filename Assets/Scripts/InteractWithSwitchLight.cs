using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InteractWithSwitchLight : MonoBehaviour {

	public Light switchLight;
	public Text pressEToInteract;
	public Light secondMainLight;
	private bool approach;

	void Start()
	{
		pressEToInteract.enabled = false;
	}

	void Update()
	{
		if(switchLight.enabled)
		{
			if(approach)
			{
				if(Input.GetKey(KeyCode.E))
				{
					secondMainLight.gameObject.SetActive(true);
				}
			}
		}
	}

	void OnTriggerEnter(Collider coll)
	{
		if(coll.tag == "Switch")
		{
			approach = true;
		}
	}
	
	void OnTriggerExit(Collider coll)
	{
		if(coll.tag == "Switch")
		{
			approach = false;
		}
	}
}
