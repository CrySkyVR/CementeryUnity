using UnityEngine;
using System.Collections;

public class Facing : MonoBehaviour {

	public Transform objetivo;
	
	// Update is called once per frame
	void Update () {

		transform.LookAt (objetivo, Vector3.up);
	
	}
}
