using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SCene_cahng: MonoBehaviour
{
    public string scenename;

    public void Chang()
    {

        SceneManager.LoadScene(scenename);
    }
}
