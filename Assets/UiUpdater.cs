using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UiUpdater : MonoBehaviour
{

    public TextMeshProUGUI textMesh;
    public TMP_Dropdown dropdown;



    // Start is called before the first frame update
    void Start()
    {
        textMesh.text = 
            "<color=#FF0000>SBS 유니티 게임 개발</color> \n 수업입니다.";

        dropdown.onValueChanged.AddListener((t) =>
        {
            
            Debug.Log(dropdown.options[t].text);
        });
    }


}
