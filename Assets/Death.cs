using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour 
{
    void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(other.gameObject);
    }

}
