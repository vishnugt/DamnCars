using UnityEngine;
using System.Collections;

public class keep_moving : MonoBehaviour {


	public float speed = -5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	transform.localPosition = transform.localPosition + new Vector3(0f, Time.deltaTime * speed, 0f);
	//transform.Translate(newpos);
	}
}
