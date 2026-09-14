using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioescena : MonoBehaviour
{
    public void Escena (int numeroEscena)
    {
        SceneManager.LoadScene (numeroEscena);
        
    }
}

