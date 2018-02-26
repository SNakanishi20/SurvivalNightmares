using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	public float smoothing = 5.0f;
	private Vector3 offset;

	// Use this for initialization
	void Start () {

		//オフセットを設定(基準が存在する地点)
		offset = transform.position - target.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		Vector3 targetCamPos = target.position + offset;
		transform.position = Vector3.Lerp (transform.position, targetCamPos, smoothing);
	}
}
