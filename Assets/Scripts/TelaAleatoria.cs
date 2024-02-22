using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class TelaAleatoria : MonoBehaviour
{
    public List<string> cenasDisponiveis = new List<string>(); // Lista de nomes das cenas disponíveis
    public float tempoDeEspera = 240f; // Tempo de espera antes de carregar a cena aleatória

    void Start()
    {
        Invoke("CarregarCenaAleatoria", tempoDeEspera);
    }

    void CarregarCenaAleatoria()
    {
        // Verifica se existem cenas disponíveis na lista
        if (cenasDisponiveis.Count > 0)
        {
            // Seleciona aleatoriamente um índice da lista
            int indiceAleatorio = Random.Range(0, cenasDisponiveis.Count);

            // Carrega a cena correspondente ao índice aleatório selecionado
            SceneManager.LoadScene(cenasDisponiveis[indiceAleatorio]);
        }
        else
        {
            Debug.LogWarning("Nenhuma cena disponível na lista.");
        }
    }
}
