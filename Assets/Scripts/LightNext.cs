using UnityEngine;
using System.Collections;

public class LightNext : MonoBehaviour {

	public Light nextLight;
	private bool onLight;

	void Start()
	{
		onLight = false;
		nextLight.enabled = false;
	}

	void Update()
	{
		if(onLight)
		{
			nextLight.enabled = true;
		}
	}

	void OnTriggerEnter(Collider coll)
	{
		if(coll.tag == "Player")
		{
			onLight = true;
		}
	}
}
