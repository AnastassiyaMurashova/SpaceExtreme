using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balaMovimiento : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() => Destroy(gameObject, 0.5f);

    // Update is called once per frame
    void Update()
    {
        // Right
        if (movement.direccionBala && !movement.ParardireccionBala)
        {
            transform.Translate(new Vector2(Time.deltaTime * 7, 0));
        }
        // Left
        if (!movement.direccionBala && movement.ParardireccionBala)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            transform.Translate(new Vector2(-Time.deltaTime * 7, 0));
        }
    }
}