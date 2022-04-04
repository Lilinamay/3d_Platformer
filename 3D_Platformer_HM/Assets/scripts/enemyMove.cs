using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{

    public float enemySpeed = 6f;
    public Transform strPos;
    public Transform endPos;
    public bool toEnd = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position == endPos.position && toEnd)
        {
            toEnd = false;


        }
        if (transform.position == strPos.position && !toEnd)
        {
            toEnd = true;
        }

        

        if (toEnd)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPos.position, Time.deltaTime * enemySpeed);
            Vector3 relativePos = endPos.position - strPos.position;
            transform.LookAt(endPos.position);
            //Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
            //transform.rotation = rotation;
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, strPos.position, Time.deltaTime * enemySpeed);
            Vector3 relativePos = strPos.position - endPos.position;
            transform.LookAt(strPos.position);
            //Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
            //transform.rotation = rotation;
        }



    }
}
