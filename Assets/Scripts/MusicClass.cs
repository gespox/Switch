using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class MusicClass : MonoBehaviour
{
    
    public AudioSource Source1;
    public float Setlevel = 0.5f;
    void Awake()
    {
        Source1.volume = 0.5f;
        Source1.Play();

        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
        if (objs.Length > 1)
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);
       
    }

    public void SetLevel(float Volume)
    {
        Setlevel = Volume;
    }
    void Update()
    {
        Source1.volume = Setlevel;
        if (SceneManager.GetActiveScene().name == "SceneName")
        {
            Destroy(this.gameObject);
        }
    }
}