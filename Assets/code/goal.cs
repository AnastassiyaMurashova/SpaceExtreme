using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour {

    public GameObject gestorSonido;

    void Awake(){
        gestorSonido = GameObject.Find("AudioManager");
    }

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }


    void OnTriggerEnter2D() {
        mainScript.Score +=10;
        Destroy(this.gameObject, 0.5f);
        gestorSonido.GetComponent<audioManager>().sonidoPuntos();

    }
}

