using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Telas : MonoBehaviour
{
    public string sceneName; // Nome da cena para carregar

    // Método chamado quando o botão é clicado
    public void escolhamenino()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void escolhamenina()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void voltartelamenina()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void voltartelamenino()
    {
        SceneManager.LoadScene(sceneName);
    }
}