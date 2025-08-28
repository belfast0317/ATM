using UnityEngine;
using UnityEngine.UI;

public class WithdrawManager : MonoBehaviour
{       
    public GameObject withdrawInputPanel; 
    public ATMUIManager atmUIManager; 
                        
    public void WithdrawCustom()
    {
        withdrawInputPanel.SetActive(true);               
    }
       
    public void Back()
    {       
        if (atmUIManager != null)
        {
            atmUIManager.OnBackClick();
        }
        else
        {
            Debug.LogError("ATM UIManager 스크립트가 연결되지 않았습니다.");
        }
    }
}
