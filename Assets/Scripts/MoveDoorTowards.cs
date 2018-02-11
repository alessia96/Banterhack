using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoveDoorTowards : MonoBehaviour {

	private bool approach;
	public Transform target;
	public float speed;
	public Text pressEToInteract;
	public GameObject elevatorBarrier;
	public Light secondMainLight;

	void Start()
	{
		pressEToInteract.enabled = false;
	}

	void Update()
	{
		if((approach) && (secondMainLight.gameObject.activeSelf))
		{
			pressEToInteract.enabled = true;
			
			if(Input.GetKey(KeyCode.E))
			{
				float step = speed * Time.deltaTime;
				transform.position = Vector3.MoveTowards(transform.position, target.position, step);
				SetElevatorBarrierInactive();
			}
		} else {
			pressEToInteract.enabled = false;
		}
	}

	void OnTriggerEnter(Collider coll)
	{
		if(coll.tag == "Player")
		{
			approach = true;
		}
	}

	void OnTriggerExit(Collider coll)
	{
		if(coll.tag == "Player")
		{
			approach = false;
		}
	}

	void SetElevatorBarrierInactive()
	{
		elevatorBarrier.SetActive(false);
	}
}
