using UnityEngine;
using TMPro;
public class OpenEmailApp: MonoBehaviour
{
    public TMP_InputField TMP_Input;
    public void OpenEmail()
    {
        string email = "mailto:"+TMP_Input.text; 

        Application.OpenURL(email);
    }
}
