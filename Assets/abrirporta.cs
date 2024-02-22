using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abrirporta : MonoBehaviour
{
    bool aberta = false;

    void OnMouseDown()
    {
        if (!aberta)
        {
            // Se a porta estiver fechada, abre a porta
            transform.localScale = new Vector3(0.1f, 1f, 1f); // Supondo que a porta gire em torno do eixo Y
            aberta = true;
        }
        else
        {
            // Se a porta estiver aberta, fecha a porta
            transform.localScale = new Vector3(1f, 1f, 1f); // Retorna à escala original
            aberta = false;
        }
    }
}