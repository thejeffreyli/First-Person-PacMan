using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportTestScript : MonoBehaviour
{
	public GameObject player;
	public Transform destination; 

	private void OnTriggerEnter(Collider other) {
		player.transform.position = destination.transform.position;
	}
}
