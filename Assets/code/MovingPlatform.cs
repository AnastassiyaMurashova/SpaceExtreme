using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    
    public List<Transform> waypoints;
    public float moveSpeed;
    public int target;

    

   

    // Update is called once per frame
    void Update()
    {
         
    
        transform.position = Vector3.MoveTowards(transform.position, waypoints[target].position, moveSpeed * Time.deltaTime);
        
    }

    //private Transform GetNextWaypoint()
    private void FixedUpdate()
    {
        
    
        if(transform.position == waypoints[target].position)
        {
            if(target == waypoints.Count - 1)
            {
               target = 0;
            }
            else
            {
               target += 1;
            }
        }

    }
}
