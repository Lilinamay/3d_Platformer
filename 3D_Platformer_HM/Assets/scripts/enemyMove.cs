using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//enemy movement and trigger
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
        //if reach one end, turn around
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
            transform.position = Vector3.MoveTowards(transform.position, endPos.position, Time.deltaTime * enemySpeed);     //move towards the other end
            Vector3 relativePos = endPos.position - strPos.position;
            //transform.LookAt(endPos.position);
            //Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
            //transform.rotation = rotation;
            transform.localScale = new Vector3(-1,1,1);     //not sure why look at or look rotation didn't work, I think it has to do something with how the
                                                            //object prefab was originally oriented
                                                            //instead I flip the object by -1 to x scale
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, strPos.position, Time.deltaTime * enemySpeed);
            Vector3 relativePos = strPos.position - endPos.position;
            //transform.LookAt(strPos.position);
            //Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
            //transform.rotation = rotation;
            transform.localScale = new Vector3(1, 1, 1);
        }



    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            StartCoroutine(attack());
        }
    }

    IEnumerator attack()
    {
        Color myColor = GetComponent<Renderer>().material.color;
        GetComponent<Renderer>().material.color = Color.red;

        yield return new WaitForSeconds(0.5f);
        GetComponent<Renderer>().material.color = myColor;




    }
}
