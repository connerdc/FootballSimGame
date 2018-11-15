using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewFranchise : MonoBehaviour {

    private string NewFranchiseScene = "NewFranchise";

	public void NewFranchiseClick()
    {
        SceneManager.LoadScene(NewFranchiseScene);
    }
}
