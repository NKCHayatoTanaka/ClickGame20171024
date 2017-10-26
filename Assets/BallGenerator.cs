using UnityEngine;
using System.Collections;

public class BallGenerator : MonoBehaviour
{
     public GameObject ballPrefab;
         

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject ball = Instantiate(ballPrefab) as GameObject;
        }
    }
}
