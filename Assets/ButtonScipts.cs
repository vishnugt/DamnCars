using UnityEngine;
using System.Collections;

public class ButtonScipts : MonoBehaviour {

	public int speed=10;
	public GameObject left_car;
	public GameObject right_car;
	public int left_flag=1;
	public int right_flag=1;

	// Use this for initialization
	void Start () {
		Camera cam = GetComponent<Camera>();
    	cam.aspect = 3f/2f;
	
	}

	// Update is called once per frame
	void Update () {
	
	}

	public void left_button()
	{
		if (left_flag == -1) 
	/*	{
			float move = speed * Time.deltaTime;
			left_car.transform.position = Vector3.Lerp(left_car.transform.position,new Vector3(-2,0,0), 10*Time.deltaTime);
		}
			//*/
			left_car.transform.Translate (-2, 0, 0);
		if(left_flag==1)
			left_car.transform.Translate (2, 0, 0);

		left_flag *= -1;
	}
	
	
	public void right_button()
	{

		if(right_flag==-1)
			right_car.transform.Translate (2, 0, 0);
		if (right_flag == 1) 
			right_car.transform.Translate (-2, 0, 0);

		right_flag *= -1;
		
	}
}
