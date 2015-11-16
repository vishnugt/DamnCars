using UnityEngine;
using System.Collections;

public class trigger : MonoBehaviour {

	 public static float count = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		count += Time.deltaTime;
	
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "rightobstacle") 
		{
			Application.LoadLevel(2);
		}	

		if (col.tag == "leftobstacle") 
		{
			Application.LoadLevel(2);
		}
	}

	void OnGUI()
	{
		GUI.Label(new Rect(10, 10, 100, 100), "Score is " + count.ToString("00")	);
	}
}
