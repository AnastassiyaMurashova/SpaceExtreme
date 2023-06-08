using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balaMovimiento : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() {
        Destroy (gameObject, 0.5f);
        
    }

    // Update is called once per frame
    void Update() {
        if(movement.direccionBala == true && movement. ParardireccionBala == false) {
        transform.Translate (new Vector2 (Time.deltaTime * 7,0));
        }
        if(movement.direccionBala == false && movement. ParardireccionBala == true) {
        transform.Translate (new Vector2 (-Time.deltaTime * 7,0));
        }
    }
}

