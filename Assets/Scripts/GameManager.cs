using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject PlayPauseToggleUI;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);// Don't destroy this gameObject when reload the scene
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        TogglePauseUI();
        TogglePlayUI();
    }

    /// <summary>
    /// Method <c>TogglePauseUI</c> call a <c>TogglePause</c> method when the ESC key was pressed for pause the game.
    /// </summary>
    public void TogglePauseUI()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }
    /// <summary>
    /// Method <c>TogglePause</c> make active the Pause UI and stop the time in the game for pause.
    /// </summary>
    public void TogglePause()
    {
        //TODO: Apeer Pause UI
        PlayPauseToggleUI.SetActive(true);
        Debug.Log("Pause");
        Time.timeScale = 0;
    }
    /// <summary>
    /// Method <c>TogglePlayUI</c> call a <c>TogglePlay</c> method when the ESC key was pressed for pause the game.
    /// </summary>
    public void TogglePlayUI()
    {
        //TODO: if(PauseUI.activeSelf && Input.GetKeyDown(KeyCode.Escape))
        if (PlayPauseToggleUI.activeSelf && Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePlay();
        }
    }
    /// <summary>
    /// Method <c>TogglePause</c> desactive the Pause UI and stop the time in the game for pause.
    /// </summary>
    public void TogglePlay()
    {
        //TODO: Disapeer Pause UI
        PlayPauseToggleUI.SetActive(false);
        Debug.Log("Play");
        Time.timeScale = 1;
    }
    /// <summary>
    /// Method <c>ReloadCurrentScene</c> relodas the current scene where is called.
    /// </summary>
    public void ReloadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
