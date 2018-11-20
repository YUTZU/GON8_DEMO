using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneToNavigate : MonoBehaviour {

    string SeneToNavige;

    public  void SceneToNavigateTo()
    {
        SceneManager.LoadScene(SeneToNavige);
    }
}
