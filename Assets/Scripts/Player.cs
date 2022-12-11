using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject prato1;
    public GameObject prato2;
    public GameObject prato3;
    public GameObject prato4;
    public GameObject prato5;
    public GameObject prato6;
    public bool pratoMao;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
                 RaycastHit hit;
                 Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                  
                  if (Physics.Raycast(ray, out hit, 1)) {
                      if(hit.collider.name == "plate1" && !pratoMao){
                        prato1.SetActive(true);
                        pratoMao = true;
                      }
                      else if(hit.collider.name == "plate2" && !pratoMao){
                        prato2.SetActive(true);
                        pratoMao = true;
                      }
                      else if(hit.collider.name == "plate3" && !pratoMao){
                        prato3.SetActive(true);
                        pratoMao = true;
                      }
                      else if(hit.collider.name == "plate4" && !pratoMao){
                        prato4.SetActive(true);
                        pratoMao = true;
                      }
                      else if(hit.collider.name == "plate5" && !pratoMao){
                        prato5.SetActive(true);
                        pratoMao = true;
                      }
                      else if(hit.collider.name == "plate6" && !pratoMao){
                        prato6.SetActive(true);
                        pratoMao = true;
                      }
                      else if(hit.collider.name == "door3" && pratoMao){
                        prato1.SetActive(false);
                        prato2.SetActive(false);
                        prato3.SetActive(false);
                        prato4.SetActive(false);
                        prato5.SetActive(false);
                        prato6.SetActive(false);
                        pratoMao = false;
                      }
                  }
              }
    }
}
