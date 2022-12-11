using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cliente : MonoBehaviour
{
    public GameObject cliente0;
    public GameObject cliente1;
    public GameObject cliente2;
    public GameObject cliente3;
    public GameObject cliente4;
    public Player pl;
    public Text TextoPedido;
    public Transform Player;
    private int numeropratoCliente0;
    private int numeropratoCliente1;
    private int numeropratoCliente2;
    private int numeropratoCliente3;
    private int numeropratoCliente4;
    // Start is called before the first frame update
    void Start()
    {   
        TextoPedido.enabled = false;
        StartCoroutine(ComecoSetup());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ClientesSetup()
    {
        
        int numerocliente = Random.Range(0, 5);
        //print(numerocliente);
        if(numerocliente == 0 && !cliente0.activeSelf){
            cliente0.SetActive(true);
            numeropratoCliente0 = Random.Range(1, 7);
            StartCoroutine(ClientePedido(cliente0, numeropratoCliente0));
        }
        else if(numerocliente == 1 && !cliente1.activeSelf){
            cliente1.SetActive(true);
            numeropratoCliente1 = Random.Range(1, 7);
            StartCoroutine(ClientePedido(cliente1, numeropratoCliente1));
        }
        else if(numerocliente == 2 && !cliente2.activeSelf){
            cliente2.SetActive(true);
            numeropratoCliente2 = Random.Range(1, 7);
            StartCoroutine(ClientePedido(cliente2, numeropratoCliente2));
        }
        else if(numerocliente == 3 && !cliente3.activeSelf){
            cliente3.SetActive(true);
            numeropratoCliente3 = Random.Range(1, 7);
            StartCoroutine(ClientePedido(cliente3, numeropratoCliente3));
        }
        else if(numerocliente == 4 && !cliente4.activeSelf){
            cliente4.SetActive(true);
            numeropratoCliente4 = Random.Range(1, 7);
            StartCoroutine(ClientePedido(cliente4, numeropratoCliente4));
        }
        yield return new WaitForSeconds(5);

        
        StartCoroutine(ClientesSetup());
    }

    IEnumerator ComecoSetup(){
        yield return new WaitForSeconds(3);
        StartCoroutine(ClientesSetup());
    }

    IEnumerator ClientePedido(GameObject Cliente, int numeroprato){
        print(numeroprato);
        bool loop = true;
        while(loop){
        if (Input.GetMouseButtonDown(0)) {
                 RaycastHit hit;
                 Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                  
                  if (Physics.Raycast(ray, out hit, 1) && hit.collider.gameObject == Cliente) {
                    print(hit.collider.gameObject);
                    if(numeroprato == 1 && pl.prato1.activeSelf){
                        Cliente.SetActive(false);
                        pl.prato1.SetActive(false);
                        pl.pratoMao = false;
                        loop = false;
                    }
                    else if(numeroprato == 2 && pl.prato2.activeSelf){
                        Cliente.SetActive(false);
                        pl.prato2.SetActive(false);
                        pl.pratoMao = false;
                        loop = false;
                    }
                    else if(numeroprato == 3 && pl.prato3.activeSelf){
                        Cliente.SetActive(false);
                        pl.prato3.SetActive(false);
                        pl.pratoMao = false;
                        loop = false;
                    }
                    else if(numeroprato == 4 && pl.prato4.activeSelf){
                        Cliente.SetActive(false);
                        pl.prato4.SetActive(false);
                        pl.pratoMao = false;
                        loop = false;
                    }
                    else if(numeroprato == 5 && pl.prato5.activeSelf){
                        Cliente.SetActive(false);
                        pl.prato5.SetActive(false);
                        pl.pratoMao = false;
                        loop = false;
                    }
                    else if(numeroprato == 6 && pl.prato6.activeSelf){
                        Cliente.SetActive(false);
                        pl.prato6.SetActive(false);
                        pl.pratoMao = false;
                        loop = false;
                    }
                  }
        }
        if(Vector3.Distance(Player.position, cliente0.transform.position) < 2 && cliente0.activeSelf){
            TextoPedido.enabled = true;
            TextoPedido.text = PedidoTexto(numeropratoCliente0);
        }
        else if(Vector3.Distance(Player.position, cliente1.transform.position) < 2 && cliente1.activeSelf){
            TextoPedido.enabled = true;
            TextoPedido.text = PedidoTexto(numeropratoCliente1);
        }
        else if(Vector3.Distance(Player.position, cliente2.transform.position) < 2 && cliente2.activeSelf){
            TextoPedido.enabled = true;
            TextoPedido.text = PedidoTexto(numeropratoCliente2);
        }
        else if(Vector3.Distance(Player.position, cliente3.transform.position) < 2  && cliente3.activeSelf){
            TextoPedido.enabled = true;
            TextoPedido.text = PedidoTexto(numeropratoCliente3);
        }
        else if(Vector3.Distance(Player.position, cliente4.transform.position) < 2  && cliente4.activeSelf){
            TextoPedido.enabled = true;
            TextoPedido.text = PedidoTexto(numeropratoCliente4);
        }
        else{
            TextoPedido.enabled = false;
        }
        yield return new WaitForSeconds(0.01f);
        }
    }

    private string PedidoTexto(int numeroprato){
        string textopedido = "";
        if(numeroprato == 1){
            textopedido = "Ovos com bacon";
        }
        else if(numeroprato == 2){
            textopedido = "Hamburger com batatas";
        }
        else if(numeroprato == 3){
            textopedido = "Hamburger e cachorro-quente com batatas";
        }
        else if(numeroprato == 4){
            textopedido = "Sushi";
        }
        else if(numeroprato == 5){
            textopedido = "Bolo de morango";
        }
        else if(numeroprato == 6){
            textopedido = "Bolo de baunilha";
        }
        return (textopedido);
    }
}
