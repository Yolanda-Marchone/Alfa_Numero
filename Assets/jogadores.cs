using UnityEngine;

public class jogadores : MonoBehaviour
{
    private void OnMouseDown()
    {
        // Quando a porta � clicada, encontra o jogador e o move em dire��o � porta
        GameObject jogador = GameObject.FindGameObjectWithTag("Player");
        if (jogador != null)
        {
            jogador.GetComponent<JogadorMovimento>().MoverParaPorta(transform.position);
        }
    }
}
