using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

    public bool pressed = false;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player") //kollar ifall vi kolliderar med player
        {
            pressed = true;
        }
    }
	
	// Update is called once per frame
	void Update () 
    {
	    if(pressed)
        {
            
            Destroy(gameObject);
        }
	}
}
