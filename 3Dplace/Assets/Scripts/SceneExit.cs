using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneExit : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Door_12_Black 1")
        {
            SceneManager.LoadScene("lobby");
        }
    }
}