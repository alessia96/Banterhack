using UnityEngine;
using System.Collections;

public class SlowSpeed : MonoBehaviour {

	public GameObject smoke;

	void Start()
	{
		smoke.GetComponent<ParticleSystem>().playbackSpeed = 0.025f;
	}
}
