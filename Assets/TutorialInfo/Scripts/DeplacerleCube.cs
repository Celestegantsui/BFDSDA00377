using UnityEngine;

public class DeplacerCube : MonoBehaviour
{
    public float vitesse = 5.0f; // Vitesse de déplacement du cube

    void Update()
    {
        // Vérifier si la touche Espace est maintenue enfoncée
        if (Input.GetKey(KeyCode.Space))
        {
            // Déplacement horizontal (gauche/droite)
            float deplacementX = Input.GetAxis("Horizontal") * vitesse * Time.deltaTime;
            // Déplacement vertical (haut/bas) - axe Z pour avant/arrière
            float deplacementZ = Input.GetAxis("Vertical") * vitesse * Time.deltaTime;

            // Appliquer le déplacement au transform du cube
            transform.Translate(deplacementX, 0, deplacementZ);
        }
    }
}
