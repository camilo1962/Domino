using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Esta clase es una clase de utilidad para fichas que colocan botones en el tablero.
 */
public class SC_PlaceTileButton : MonoBehaviour
{
    public int index;

    // Elimina el botón en el que se hizo clic e inicia la lógica de la ubicación.
    public void OnClick()
    {
        GetComponentInParent<SC_BoardTile>().PlacingClicked(this.transform, index);
        GetComponentInParent<SC_BoardTile>().RemoveButton(index);
    }

    // Si el botón choca con un mosaico o los bordes del tablero => eliminar botón
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "GameObject")
        {
            GetComponentInParent<SC_BoardTile>().RemoveButton(index);
        }
    }
}
