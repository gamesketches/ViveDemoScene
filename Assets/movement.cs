using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	CharacterController characterController;
	// Use this for initialization
	void Start () {
		characterController = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		float vert = Input.GetAxis("Vertical");

		characterController.Move(new Vector3(0f, vert, 0f));
	}
}
