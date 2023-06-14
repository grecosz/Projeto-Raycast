using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raio : MonoBehaviour
{
    void Update()
    {
        RaycastHit pontoDeColisao;

        if (Physics.Raycast(transform.position, transform.forward, out pontoDeColisao, 8))
        {
            Debug.Log("VOCÊ ACERTOU TODOS OS PLANETAS, PARABÉNS!");
            if (pontoDeColisao.transform.gameObject.GetComponent<MeshRenderer>() != null)
            {
                pontoDeColisao.transform.gameObject.GetComponent<MeshRenderer>().enabled = false;
                Debug.Log(pontoDeColisao.transform.tag);
                Destroy(pontoDeColisao.transform.gameObject);
            }
        }
        else
        {
           Debug.Log("ACERTE OS PLANETAS");
        }
    }
}