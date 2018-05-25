using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	public Animator anim;

	// Use this for initialization
	void Start () {
			anim = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
			if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger)) {
				anim.Play("WAIT04", -1, 0f);
			}
	}
}
