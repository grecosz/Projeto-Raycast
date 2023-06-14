using UnityEngine;

public class Movimento : MonoBehaviour
{
    public float velocidade = 300f;

    void Update()
    {
        // Movimento para frente
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * velocidade * Time.deltaTime);
        }

        // Movimento para trás
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * velocidade * Time.deltaTime);
        }

        // Movimento para a direita
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * velocidade * Time.deltaTime);
        }

        // Movimento para a esquerda
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * velocidade * Time.deltaTime);
        }

        // Movimento para baixo
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.down * velocidade * Time.deltaTime);
        }
    }
}
