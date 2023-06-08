using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour {

    public GameObject CanvasStart;

    public GameObject CanvasControls;

    // Start is called before the first frame update
    void Start() {
        CanvasControls.SetActive(false);
        
    }

    // Update is called once per frame
    void Update() {
        
    }


    public void EntrarJuego(){
        SceneManager.LoadScene("MainLevel");

    }

    public void MostrarControles(){
     CanvasStart.SetActive(false);
     CanvasControls.SetActive(true);
     }

    public void IraStart(){
     CanvasControls.SetActive(false);
     CanvasStart.SetActive(true);
    } 

}// fin clase
