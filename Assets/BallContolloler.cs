using UnityEngine;
using System.Collections;

public class BallContolloler : MonoBehaviour
{
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir*2);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "DeleteSphere")
        {
            Debug.Log("Hit");
            DestroyObject(collision.gameObject);
            Destroy(gameObject);
        }
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= 0.3)
        {
            Destroy(gameObject);
        }
    }
}
