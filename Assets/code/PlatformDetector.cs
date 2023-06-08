using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Physics;

public class PlatformDetector : MonoBehaviour
{
    CharacterController controller;
    public Transform player;
    public bool isGrounded;
    public bool check;

    // Start is called before the first frame update
    void Start()
    {
       //controller = GetComponent<CharacterContorller>(); 
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = controller.isGrounded;

        if(!isGrounded)
        {
            check = false;
        }
        if(!check)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, .125f);

            if(hit.collider != null)
            {
                if(hit.collider.CompareTag("MovingPlatform"))
                {
                    player.SetParent(hit.transform);
                }
                else
                {
                    player.SetParent(null);
                }
                check = true;
            }
        }
        
    }
}
