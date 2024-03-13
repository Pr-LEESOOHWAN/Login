using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginHandler : MonoBehaviour
{   
    private LoginManager loginManager;
    private string enteredID;
    private string enteredPW;

    public void Initialize(LoginManager manager){
        loginManager = manager;
    }

    public void HandleLogin(){
        loginManager.InfoView.SetActive(false);
        Debug.Log("로그인 ID:" + loginManager.inputField_ID.text);
        Debug.Log("로그인 PW:" + loginManager.inputField_Pw.text);

        enteredID = loginManager.inputField_ID.text;
        enteredPW = loginManager.inputField_Pw.text;

        Debug.Log("enteredID: "+ enteredID);
        bool loginSuccess = false;

        List<Dictionary<string, object>> data_user = CSVReader.Read("Login_Test_CSV");

        foreach (var user in data_user){
            string storedID = user["ID"].ToString();
            string storedPW = user["Password"].ToString();

            if(enteredID == storedID && enteredPW == storedPW){
                loginSuccess = true;
                UserData.SetEnteredID(enteredID); //enteredID를 UserData에 저장
                break;
            }
        }

        if (loginSuccess){
            Debug.Log("로그인 성공");
            //로그인 성공시 필요한 작업 추가 가능
            loginManager.LoginView.SetActive(false);
            loginManager.InfoView.SetActive(true);
        }
        else{
            Debug.Log("로그인 실패");
            //로그인 실패시 필요한 작업 추가 가능
        }
    }
    
}
