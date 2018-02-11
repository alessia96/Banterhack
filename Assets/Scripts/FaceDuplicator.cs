using UnityEngine;
using System.Collections;

public class FaceDuplicator : MonoBehaviour {

	public GameObject faceToDuplicate;
	protected GameObject[] lcdScreens;

	// Use this for initialization
	void Start () {
	
		lcdScreens = GameObject.FindGameObjectsWithTag ("LCD");

		foreach(GameObject lcdScreen in lcdScreens)
		{
			GameObject clone;
			Vector3 position;
			Quaternion rotation;

			Transform lcdPosition;

			lcdPosition = lcdScreen.transform;

			//lcdPosition.Rotate (Vector3.forward);

			position = lcdPosition.position;
			rotation = lcdPosition.rotation;

			clone = Instantiate (faceToDuplicate, position, rotation) as GameObject;
			clone.transform.Rotate (Vector3.up, -90);
			clone.transform.Translate (Vector3.up * 0.4f);
			clone.transform.Translate (Vector3.right * 0.015f);
			clone.transform.Translate (Vector3.forward * 0.65f);

		}

		faceToDuplicate.SetActive (false);

	}
}
