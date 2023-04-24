using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoscaCollision : MonoBehaviour
{
    public Vector3 initialPosition;
    public int lives = 3;
    public int Puntaje = 0;
    public TextMeshProUGUI textVidas;
    public TextMeshProUGUI textScore;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
        textVidas.text = "Vidas: " + lives;
        textScore.text = "Puntaje: " + Puntaje;
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ventilador")
        {
            //Destroy(gameObject);
            transform.position = initialPosition;
            lives--;
            textVidas.text = "Vidas: " + lives;
            if (lives == 0)
            {
                Destroy(gameObject);
            }
        }
        else if (collision.gameObject.name == "Target")
        {
            Destroy(collision.gameObject);
            Puntaje++;
            textScore.text = "Puntaje: " + Puntaje;
        }
    }

}
