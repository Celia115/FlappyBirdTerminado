using UnityEngine;
using UnityEngine.SceneManagement;

public class Creditos : MonoBehaviour
{
    // Método público para cargar la escena de créditos
    public void IrACreditos()
    {
        SceneManager.LoadScene("Creditos"); 
    }
}
