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
            Debug.LogError("ATM UIManager ��ũ��Ʈ�� ������� �ʾҽ��ϴ�.");
        }
    }
}
