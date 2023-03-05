using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public Transform player;

	void LateUpdate () {
		transform.position = player.position + (-player.forward * 30.0f) + (player.up * 10.0f);
		transform.LookAt (player.position+Vector3.up);
	}
}
