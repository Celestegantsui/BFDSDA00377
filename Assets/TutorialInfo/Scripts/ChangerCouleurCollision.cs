using UnityEngine;

public class ChangerCouleurCollision : MonoBehaviour
{
    public Color couleurCollision = Color.red; // Couleur à appliquer lors de la collision
    private Color couleurOriginale; // Pour stocker la couleur initiale du cube
    private Renderer cubeRenderer; // Référence au composant Renderer du cube

    void Start()
    {
        // Obtenir le composant Renderer du cube au démarrage
        cubeRenderer = GetComponent<Renderer>();
        // Stocker la couleur originale du cube
        couleurOriginale = cubeRenderer.material.color;
    }

    // Cette fonction est appelée lorsqu'une collision commence
    void OnCollisionEnter(Collision collision)
    {
        // Changer la couleur du cube à la couleur de collision
        cubeRenderer.material.color = couleurCollision;
        Debug.Log("Collision détectée avec : " + collision.gameObject.name);
    }

    // Cette fonction est appelée lorsque la collision se termine
    void OnCollisionExit(Collision collision)
    {
        // Revenir à la couleur originale du cube
        cubeRenderer.material.color = couleurOriginale;
        Debug.Log("Fin de collision avec : " + collision.gameObject.name);
    }
}

// Revenir à la couleur originale du cube
