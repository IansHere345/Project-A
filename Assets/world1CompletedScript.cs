using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class world1CompletedScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("First World Completed");
        }
    }
}
