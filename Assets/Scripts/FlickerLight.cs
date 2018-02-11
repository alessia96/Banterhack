using UnityEngine;
using System.Collections;

public class FlickerLight : MonoBehaviour
{
	public GameObject[] flickerTheseObjects;
	public AudioSource audioSource;

	void Flicker() {

		bool toggle = Random.value > 0.7f;

		if (toggle) {
			foreach(GameObject flickerThis in flickerTheseObjects)
			{
				flickerThis.SetActive(!flickerThis.activeSelf);
			}
			if (flickerTheseObjects[0].activeSelf) {
				audioSource.Play ();
			} else {
				audioSource.Stop ();
			}
		}
	}

	void Start() {
		InvokeRepeating("Flicker", 0, 0.05F);
	}
}
