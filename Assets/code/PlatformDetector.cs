using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDetector : MonoBehaviour
{
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, .5f);
        if (hit.collider == null) return;
        player.SetParent(hit.collider.CompareTag("MovingPlatform") ? hit.collider.transform : null);
        
    }
}
