using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitScript : MonoBehaviour {


	public GameObject target = null;
	public GameObject cannonBallPrefab;
	public Transform cannonBallSpawn;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		float speed = 10.0f;

		if (target != null)
		{
			transform.LookAt(target.transform);
			transform.RotateAround(target.transform.position, Vector3.up, Input.GetAxis("Mouse X")*speed);
			transform.RotateAround(target.transform.position, Vector3.left, Input.GetAxis("Mouse Y")*speed);
		}




	}

	 public void Fire()
	{
        // Instaciate Cannonball
        GameObject cannonBall = Instantiate(cannonBallPrefab,cannonBallSpawn.position,cannonBallSpawn.rotation);

        // Add velocity to the bullet
        cannonBall.GetComponent<Rigidbody>().velocity = cannonBall.transform.forward * 50;

        // Destroy the bullet after 2 seconds
        Destroy(cannonBall, 2.0f); 
	}
}      
