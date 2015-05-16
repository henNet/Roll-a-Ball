using UnityEngine;
using System.Collections;

public class CameraControler : MonoBehaviour {

	public GameObject player;	/* Referenciar o player */
	private Vector3 offset;

	void Start()
	{
		/*Pega a posiçao inicial da camera */
		offset = transform.position;
	}

	void LateUpdate()
	{
		transform.position = player.transform.position + offset; 
	}
}
