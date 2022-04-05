using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//rotate coin and collected by player
public class coin : MonoBehaviour
{
    float angle = 90;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Spin the object around the target at 90 degrees/second.
        transform.RotateAround(transform.position, Vector3.up, angle * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
        }
    }


}
