using UnityEngine;
using System.Collections;

public class Turret : MonoBehaviour 
{
	Transform targetPlayer;
	Transform targetTurret;
	public Rigidbody2D rb;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent <Rigidbody2D>();

		targetPlayer = GameObject.FindWithTag ("Player1").transform;

	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 relative = (targetPlayer.position) - transform.position;
		float angle = Mathf.Atan2(relative.y, relative.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(0, 0, angle);
	}
}
