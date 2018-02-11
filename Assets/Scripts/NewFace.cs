using UnityEngine;
using System.Collections;

public class NewFace : MonoBehaviour {

	public Texture[] faceOptions;
	private Renderer renderer;

	// Use this for initialization
	void Start () {
		int choose = Random.Range(0,faceOptions.Length);
		renderer = GetComponent<Renderer> ();
		renderer.material.mainTexture = faceOptions [choose];
	}

}
