using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuEvents : MonoBehaviour
{
    public void LoadLevel(int index)
    {
        if (index >= 0 && index <= 3) // Pastikan hanya memuat level 0, 1, atau 2
        {
            SceneManager.LoadScene(index);
        }
        else
        {
            Debug.LogWarning("Level tidak valid!");
        }
    }
}
