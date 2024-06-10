using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UILevelManager : MonoBehaviour
{
   //serializefiled feld in unity zum auswählen von buttons/panels usw.
    private CharakterMovement charaktermovementsc;
    [SerializeField] private CanvasGroup panelWin;
    [SerializeField] private Button buttonnextlevel;
    [SerializeField] private Button buttonplayagainwin;
    [SerializeField] private Button menubuttonwin;
    
    [SerializeField] private CanvasGroup panelLOSE;
    [SerializeField] private Button buttonplayagainLOSE;
    [SerializeField] private Button menubuttonlose;
    [SerializeField] private string nameNextScene;
    [SerializeField] private string menuscene;

    private int coincounter = 0;
    [SerializeField] private TextMeshProUGUI txtcoincount;
    
    
    // Start is called before the first frame update
    void Start()
    {
        charaktermovementsc = FindObjectOfType<CharakterMovement>();
        //win und lose screen hide
        panelWin.HideCanvasGroup();
        panelLOSE.HideCanvasGroup();
       
        //zuweisen was die einzelnen knöpfe beim klicken machen
        buttonplayagainwin.onClick.AddListener(RestartLevel);
        buttonplayagainLOSE.onClick.AddListener(RestartLevel);
        buttonnextlevel.onClick.AddListener(LoadNextLevel);
        menubuttonlose.onClick.AddListener(backtoMenu);
        menubuttonwin.onClick.AddListener(backtoMenu);
        
        //geschwindigkeit der zeit auf "normal" gesetzt
        Time.timeScale = 1f;
        txtcoincount.text = coincounter.ToString();


    }

    public void OnGameWin()
    {
        //winscreen show
        panelWin.ShowCanvasGroup();
        PlayerPrefs.SetInt(nameNextScene, 1);
        Time.timeScale = 0f;
    }

    public void OnGameLose()
    {
        //losescreen show
        panelLOSE.ShowCanvasGroup();
        Time.timeScale = 0f;
    }

    public void AddCoin()
    {
        coincounter++; //coincount++; same as coincount = coincount +1;
        txtcoincount.text = coincounter.ToString();
    }

    void RestartLevel()
    {
        //reload current level
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void LoadNextLevel()
    {
        //loadnextlevel
        SceneManager.LoadScene(nameNextScene);
    }

    void backtoMenu()
    {
        //back to menu
        SceneManager.LoadScene(menuscene); 
    }

    

    

   
}

public static class UIExtentions
{
    public static void HideCanvasGroup(this CanvasGroup canvasGroup)
    {
        canvasGroup.interactable = false;
        canvasGroup.alpha = 0f;
        canvasGroup.blocksRaycasts = false;
    }
    public static void ShowCanvasGroup(this CanvasGroup canvasGroup)
    {
        canvasGroup.interactable = true;
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
    }
}