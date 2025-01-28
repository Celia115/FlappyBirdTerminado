using UnityEngine;
using UnityEngine.SceneManagement;

public class VolverMenu : MonoBehaviour
{
    // Método público para cargar la escena de créditos
    public void IrAMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
