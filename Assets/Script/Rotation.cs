using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

	[SerializeField] float rotationSpeed = 6f;

	void Update () {
		this.transform.RotateAround (this.transform.position, Vector3.up, Time.deltaTime * rotationSpeed);
	}
}
