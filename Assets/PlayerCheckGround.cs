using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCheckGround : MonoBehaviour {

public float distanceFromGround;
public LayerMask mask;
public GameObject movementBox;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		CheckGround();	
	}

	void CheckGround()
	{
		RaycastHit hit;
		Debug.DrawLine(gameObject.transform.position,gameObject.transform.position + Vector3.down * 1,Color.red);
		if (Physics.Raycast(gameObject.transform.position,Vector3.down,out hit, distanceFromGround,mask))
		{
			Debug.DrawLine(gameObject.transform.position,hit.transform.position,Color.red);
			Debug.Log("grounding");
			movementBox.GetComponent<playerControler>().Ground();
		}
		
	}
}
