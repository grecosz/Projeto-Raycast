using UnityEngine;

public class Explosão : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null && hit.collider.gameObject == gameObject)
                {
                    RemoverObjeto();
                }
            }
        }
    }

    void RemoverObjeto()
    {
        Destroy(gameObject);
    }
}
