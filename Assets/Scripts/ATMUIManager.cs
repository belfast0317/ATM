using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ATMUIManager : MonoBehaviour
{
    public GameObject mainUI;
    public GameObject depositUI;
    public GameObject withdrawUI;
    public GameObject popupErrorPanel;


    public TextMeshProUGUI cashText;
    public TextMeshProUGUI balanceText;
    public TextMeshProUGUI popupMessageText;

    public TMP_InputField depositInputField;
    public TMP_InputField withdrawInputField;

    private void Start()
    {
        RefreshUI();
    }
    void RefreshUI()
    {
        cashText.text= DataManager.Instance.user.Cash.ToString("N0");
        balanceText.text= DataManager.Instance.user.Balance.ToString("N0");
               
    }   
    
    public void DepositAmount(int amount)
    {
        if(DataManager.Instance.user.Cash >= amount)
        {
            DataManager.Instance.user.Cash -= amount;
            DataManager.Instance.user.Balance += amount;
            RefreshUI();
            DataManager.Instance.SaveUserData();
        }
        else
        {
            ShowPopup("Not enough cash to deposit.");
        }    
    }

    public void WithdrawAmount(int amount)
    {
        if (DataManager.Instance.user.Balance >= amount)
        {
            DataManager.Instance.user.Balance -= amount;
            DataManager.Instance.user.Cash += amount;            
            RefreshUI();
            DataManager.Instance.SaveUserData();
        }
        else
        {
            ShowPopup("Not enough balance to withdraw.");
        }
    }

    public void DepositCustomAmount()
    {       
        string inputText = depositInputField.text;
        int amount;
               
        if (int.TryParse(inputText, out amount)&&amount>0)
        {
            DepositAmount(amount);
        }
        else
        {
            Debug.Log("유효하지 않은 금액입니다.");
            ShowPopup("It's an invalid amount");
        }
    }

    public void WithdrawCustomAmount()
    {
        string inputText = withdrawInputField.text;
        int amount;

        if (int.TryParse(inputText, out amount) && amount > 0)
        {
            WithdrawAmount(amount);
        }
        else
        {
            Debug.Log("유효하지 않은 금액입니다.");
            ShowPopup("It's an invalid amount");
        }
    }
    public void ShowPopup(string message)
    {
        if (popupErrorPanel != null)
        {
            popupErrorPanel.SetActive(true);
           
            if (popupMessageText != null)
            {
                popupMessageText.text = message;
            }
        }
    }

    public void HidePopup()
    {
        if (popupErrorPanel != null)
        {
            popupErrorPanel.SetActive(false);
        }
    }

    public void OnDepositClick()
    {
        mainUI.SetActive(false);
        depositUI.SetActive(true);
    }
        
    public void OnWithdrawClick()
    {
        mainUI.SetActive(false);
        withdrawUI.SetActive(true);
    }
       
    public void OnBackClick()
    {
        depositUI.SetActive(false);
        withdrawUI.SetActive(false);
        mainUI.SetActive(true);
    }
}
