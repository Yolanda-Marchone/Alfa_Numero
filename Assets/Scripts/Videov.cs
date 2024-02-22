using UnityEngine;
using UnityEngine.SceneManagement;

public class videov : MonoBehaviour
{
    public string nomeDaProximaCena;
    public float tempoDeEspera = 3f;

    void Start()
    {
        Invoke("CarregarProximaCena", tempoDeEspera);
    }

    void CarregarProximaCena()
    {
        SceneManager.LoadScene(nomeDaProximaCena);
    }
}

