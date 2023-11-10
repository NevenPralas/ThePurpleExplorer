using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicanjeEnemy : MonoBehaviour
{
    [SerializeField] GameObject[] wayPoints;
    int index = 0;

    [SerializeField] float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, wayPoints[index].transform.position) < 0.1f)
        {
            if (index == 0) index = 1;
            else index = 0;
        }

        transform.position = Vector3.MoveTowards(transform.position, wayPoints[index].transform.position, speed * Time.deltaTime);
    }
}
