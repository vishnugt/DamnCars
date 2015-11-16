using UnityEngine;
using System.Collections;

public class SpawnObjects : MonoBehaviour {

	public GameObject cube;
	public GameObject parent;
	public GameObject sphere;
	int random_number;
	// Use this for initialization
	void Start () 
	{
		StartCoroutine(YourFunctionName());
	}

	IEnumerator YourFunctionName()
	{
		GameObject temp;
		while (true) {
			random_number = Random.Range (1, 5);
			switch (random_number) {
			case 1:
				 Instantiate (cube, new Vector3 (-2.45f, 5f, -11f), Quaternion.identity);
				//cube.transform.localPosition = new Vector3 (-2.54f, 5f, -11f);
				break;
				
			case 2:
				Instantiate (cube, new Vector3 (-0.55f, 5f, -11f), Quaternion.identity);
				//cube.transform.localPosition = new Vector3 (-0.55f, 5f, -11f);
				break;
				
			case 3:
				temp = (GameObject)Instantiate (sphere, new Vector3 (-2.45f, 5f, -11f), sphere.transform.rotation);
				CapsuleCollider cap = temp.AddComponent<CapsuleCollider>() as CapsuleCollider;
				//CapsuleCollider cap = new CapsuleCollider();
				cap.center = new Vector3(+2, 0, 0);
				cap.isTrigger =true;
				cap.radius = 0.5f;
				cap.height=2;
				//temp.AddComponent(CapsuleCollider);
				//sphere.transform.localPosition = new Vector3 (-2.54f, 5f, -11f);
				break;
				
			case 4:
				temp =(GameObject) Instantiate (sphere, new Vector3 (-0.55f, 5f, -11f), sphere.transform.rotation);
				//sphere.transform.localPosition = new Vector3 (-0.55f, 5f, -11f);
				CapsuleCollider cap2 = temp.AddComponent<CapsuleCollider>() as CapsuleCollider;
				//CapsuleCollider cap = new CapsuleCollider();
				cap2.center = new Vector3(-2, 0, 0);
				cap2.isTrigger =true;
				cap2.radius = 0.5f;
				cap2.height=2;
				break;

			}
			random_number = Random.Range (1, 5);
			switch (random_number) {
			case 1:
				Instantiate (cube, new Vector3 (0.75f, 5f, -11f), Quaternion.identity);
				//cube.transform.localPosition = new Vector3 (-2.54f, 5f, -11f);
				break;
				
			case 2:
				Instantiate (cube, new Vector3 (2.92f, 5f, -11f), Quaternion.identity);
				//cube.transform.localPosition = new Vector3 (-0.55f, 5f, -11f);
				break;
				
			case 3:
				temp = (GameObject)Instantiate (sphere, new Vector3 (0.75f, 5f, -11f), sphere.transform.rotation);
				//sphere.transform.localPosition = new Vector3 (-2.54f, 5f, -11f);
				CapsuleCollider cap3 = temp.AddComponent<CapsuleCollider>() as CapsuleCollider;
				//CapsuleCollider cap = new CapsuleCollider();
				cap3.center = new Vector3(+2, 0, 0);
				cap3.isTrigger =true;
				cap3.radius = 0.5f;
				cap3.height=2;
				break;
				
			case 4:
				temp = (GameObject)Instantiate (sphere, new Vector3 (2.92f, 5f, -11f), sphere.transform.rotation);
				CapsuleCollider cap4 = temp.AddComponent<CapsuleCollider>() as CapsuleCollider;
				//CapsuleCollider cap = new CapsuleCollider();
				cap4.center = new Vector3(-2, 0, 0);
				cap4.isTrigger =true;
				cap4.radius = 0.5f;
				cap4.height=2;
				//sphere.transform.localPosition = new Vector3 (-0.55f, 5f, -11f);
				break;
				
			}

				//cube.transform.parent = parent.transform;
				yield return new WaitForSeconds (1);

		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
