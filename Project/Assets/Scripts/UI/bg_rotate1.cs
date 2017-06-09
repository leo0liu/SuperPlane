using UnityEngine;
using System.Collections;

public class bg_rotate1 : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {
        transform.Rotate(-Vector3.up,-50f*Time.deltaTime*0.2f);
	}
}
