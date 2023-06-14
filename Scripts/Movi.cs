using UnityEngine;

public class Movi : MonoBehaviour
{
    public float sensibilidade = 1.5f;
    public float limiteVerticalSuperior = 50f;
    public float limiteVerticalInferior = -50f;

    private float rotacaoVertical = 0f;

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Rotacionar a câmera horizontalmente com base no movimento do mouse
        transform.Rotate(Vector3.up * mouseX * sensibilidade);

        // Rotacionar a câmera verticalmente com base no movimento do mouse
        rotacaoVertical -= mouseY * sensibilidade;
        rotacaoVertical = Mathf.Clamp(rotacaoVertical, limiteVerticalInferior, limiteVerticalSuperior);

        transform.localRotation = Quaternion.Euler(rotacaoVertical, transform.localEulerAngles.y, transform.localEulerAngles.z);
    }
}
