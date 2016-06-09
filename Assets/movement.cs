using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	CharacterController characterController;
	public GameObject leftHand;
	private int controllerIndex;

	// Use this for initialization
	void Start () {
		characterController = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		float vert = Input.GetAxis("Vertical");

		controllerIndex = (int)leftHand.GetComponent<SteamVR_TrackedObject>().index;

		characterController.Move(new Vector3(0f, 0f, vert));

		var device = SteamVR_Controller.Input(controllerIndex);
		if(Input.GetAxis("Jump") != 0 || device.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger)) {
			Instantiate(Resources.Load<GameObject>("blockboy"), leftHand.transform.position, leftHand.transform.rotation);
		}
	}
}
