using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    //Rigidbody enemyBody;
    //Transform enemyTrans;
    public float enemySpeed = 6f;
    //public Vector3 startPos;
    //public Vector3 endPos;
    public Transform strPos;
    public Transform endPos;
    public bool toEnd = true;
    public Vector3 mydirection = new Vector3(0, 0.5f, 0);

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
            Debug.Log("turn");


        }
        if (transform.position == strPos.position && !toEnd)
        {
            toEnd = true;
            Debug.Log("aaaahhhhh");
        }

        

        if (toEnd)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPos.position, Time.deltaTime * enemySpeed);
            Vector3 relativePos = endPos.position - transform.position;
            //LookAt(Transform target);
            Quaternion rotation = Quaternion.LookRotation(relativePos,Vector3.up);
            transform.rotation = rotation;
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, strPos.position, Time.deltaTime * enemySpeed);
            Vector3 relativePos = strPos.position - transform.position;
            Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
            transform.rotation = rotation;
        }


        //Debug.Log(transform.position == endPos.position);


    }
}
