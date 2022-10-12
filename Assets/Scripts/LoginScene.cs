using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginScene : MonoBehaviour
{
    public void SceneLogin()
    {
        SceneManager.LoadScene("FirebaseController");
    }

    public GameObject onetimeStartupPage, homePage, catagoryPage, exploreWallpaperPage, bookmarkSavedPage;



    public void SceneMain()
    {
        SceneManager.LoadScene("Main");
           








    }



}
