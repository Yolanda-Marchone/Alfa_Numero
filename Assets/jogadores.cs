using UnityEngine;

public class jogadores : MonoBehaviour
{
    private void OnMouseDown()
    {
        // Quando a porta é clicada, encontra o jogador e o move em direção à porta
        GameObject jogador = GameObject.FindGameObjectWithTag("Player");
        if (jogador != null)
        {
            jogador.GetComponent<JogadorMovimento>().MoverParaPorta(transform.position);
        }
    }
}
