using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraController : MonoBehaviour {
	public Transform player;

	public float frontNum = 10;
	
	public float highNum = 10;
	void LateUpdate () {
		transform.position = player.position + (-player.forward * frontNum) + (player.up *highNum);
		transform.LookAt (player.position+Vector3.up);
	}
}
