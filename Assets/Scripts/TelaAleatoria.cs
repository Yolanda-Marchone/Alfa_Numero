using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class TelaAleatoria : MonoBehaviour
{
    public List<string> cenasDisponiveis = new List<string>(); // Lista de nomes das cenas dispon�veis
    public float tempoDeEspera = 240f; // Tempo de espera antes de carregar a cena aleat�ria

    void Start()
    {
        Invoke("CarregarCenaAleatoria", tempoDeEspera);
    }

    void CarregarCenaAleatoria()
    {
        // Verifica se existem cenas dispon�veis na lista
        if (cenasDisponiveis.Count > 0)
        {
            // Seleciona aleatoriamente um �ndice da lista
            int indiceAleatorio = Random.Range(0, cenasDisponiveis.Count);

            // Carrega a cena correspondente ao �ndice aleat�rio selecionado
            SceneManager.LoadScene(cenasDisponiveis[indiceAleatorio]);
        }
        else
        {
            Debug.LogWarning("Nenhuma cena dispon�vel na lista.");
        }
    }
}
