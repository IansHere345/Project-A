using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startButtonScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
    // The Scene name is called by an On Click() that can be found in the Inspector of the Start Button
    // Source used: https://youtu.be/mA-4nROr_-o?si=Chw5P-z82VpWk8X2
}
