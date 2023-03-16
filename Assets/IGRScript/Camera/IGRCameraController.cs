using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IGRCameraController : MonoBehaviour
{
   public Transform player;

	public float frontNum = 6;
	
	public float highNum = 4;
	void LateUpdate () {
		transform.position = player.position + (-player.forward * frontNum) + (player.up *highNum);
		transform.LookAt (player.position+Vector3.up);
	}
}
