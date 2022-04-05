using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//rotate coin and collected by player
public class coin : MonoBehaviour
{
    float angle = 90;
    coinDisplay coinDisplay;
    [SerializeField] int coinValue = 1;
    // Start is called before the first frame update
    void Start()
    {
        coinDisplay = GetComponentInParent<coinDisplay>();
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
            coinDisplay.totalC += coinValue;            //collide with player, total coin num +1
            Destroy(gameObject);
        }
    }


}
