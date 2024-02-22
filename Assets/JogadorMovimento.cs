using UnityEngine;

public class JogadorMovimento : MonoBehaviour
{
    public float velocidadeMovimento = 5f;
    private Vector3 destino;

    private void Update()
    {
        // Movimento suave em direção ao destino
        transform.position = Vector3.MoveTowards(transform.position, destino, velocidadeMovimento * Time.deltaTime);
    }

    // Define o destino para onde o jogador deve se mover
    public void MoverParaPorta(Vector3 portaPosition)
    {
        destino = portaPosition;
    }
}

