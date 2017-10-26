using UnityEngine;
using System.Collections;

public class BallContolloler : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "DeleteSphere")
        {

            DestroyObject(collision.gameObject);
        }
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
