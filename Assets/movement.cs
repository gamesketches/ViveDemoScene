using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	CharacterController characterController;
	public GameObject leftHand;
	// Use this for initialization
	void Start () {
		characterController = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		float vert = Input.GetAxis("Vertical");

		characterController.Move(new Vector3(0f, 0f, vert));

		if(Input.GetAxis("Jump") != 0) {
			Instantiate(Resources.Load<GameObject>("blockboy"), leftHand.transform.position, leftHand.transform.rotation);
		}
	}
}
