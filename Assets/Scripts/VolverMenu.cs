using UnityEngine;
using UnityEngine.SceneManagement;

public class VolverMenu : MonoBehaviour
{
    // M�todo p�blico para cargar la escena de cr�ditos
    public void IrAMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
