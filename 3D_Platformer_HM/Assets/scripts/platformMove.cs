using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMove : MonoBehaviour
{
    public float speed = 2f;
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
            transform.position = Vector3.MoveTowards(transform.position, endPos.position, Time.deltaTime * speed);

        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, strPos.position, Time.deltaTime * speed);
        }



    }
}
