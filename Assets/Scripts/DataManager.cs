using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    //public int cashAmount = 100000;
    //public int balanceAmount = 50000;

    public UserData user; 
    private string path;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;            
        }            
        else
        {
            Destroy(gameObject);
        }

        path= Path.Combine(Application.persistentDataPath, "userdata.json");

        LoadUserData();
    }
    public void SaveUserData()
    {
        string json = JsonUtility.ToJson(user);
        File.WriteAllText(path, json);
        //PlayerPrefs.SetInt("userCash",cashAmount);
        //PlayerPrefs.SetInt("userBalance",balanceAmount);
        //PlayerPrefs.Save();
    }

    public void LoadUserData()
    {
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);

            user = JsonUtility.FromJson<UserData>(json);
        }
        else
        {
            user = new UserData("Park geon", 50000, 100000);
        }
        //if (PlayerPrefs.HasKey("userCash"))
        //{
        //    cashAmount = PlayerPrefs.GetInt("userCash");            
        //}

        //if (PlayerPrefs.HasKey("userBalance"))
        //{
        //    balanceAmount = PlayerPrefs.GetInt("userBalance");            
        //}
    }
    
}
