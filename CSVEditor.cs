using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Data;

public class CSVEditor : MonoBehaviour
{
    public TMP_InputField inputField;
    public Button saveButton;

    private string IDFromLoginHandler;
    
    private LoginHandler loginHandler;
    

    
    // Start is called before the first frame update
    void Start(){
        IDFromLoginHandler = UserData.EnteredID; //UserData로부터 유저 ID 받아옴
        Debug.Log("ID from LoginHandler: " + UserData.EnteredID);
        // 버튼 클릭 이벤트에 함수 연결
        saveButton.onClick.AddListener(SaveInputToCSV);
    
    }

    void Update(){
        /*if(csvWriter==null)
        Debug.Log("csvWriter is null");*/
    }

    // Update is called once per frame
    void SaveInputToCSV(){

        string inputText = inputField.text;

        if(IDFromLoginHandler !=null ){
            
            using (var writer = new CsvFileWriter("Assets/Resources/test.csv"))
		{
			List<string> columns = new List<string>(){"ID", "Value"};// making Index Row
			writer.WriteRow(columns);
			columns.Clear();

			columns.Add(IDFromLoginHandler); // ID
            Debug.Log("IDFromLoginHandler is " +IDFromLoginHandler);
            columns.Add(inputText); //inputText
            Debug.Log("inputText is " +inputText);
            writer.WriteRow(columns);
            columns.Clear();
			
		}
                

                

                Debug.Log("Success!");
            
        }

        else{
            Debug.Log("enteredID is null!");
        }    
    }
}
