using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SheetManager : MonoBehaviour
{
    static readonly string[] Scopes = { Google.Apis.Sheets.v4.SheetsService.Scope.Spreadsheets };
    static readonly string ApplicationName = "mExpressData";
    static readonly string SpreadsheetId = "1jOGjA3UDEoJcltcoF3J47_8pGrknyGpYC5xtYkH1yo0";
    static readonly string sheet = "Sheet2";
    static Google.Apis.Sheets.v4.SheetsService service;
    static public List<string> Usernames = new List<string>();
    static public List<string> Times = new List<string>();

    public void Start()
    {
        Google.Apis.Auth.OAuth2.GoogleCredential credential;

        using(var stream = new FileStream("idp-ape-escape-ac4df45a6727.json", FileMode.Open, FileAccess.Read))
        {
            credential = Google.Apis.Auth.OAuth2.GoogleCredential.FromStream(stream).CreateScoped(Scopes);
        }
        service = new Google.Apis.Sheets.v4.SheetsService(new Google.Apis.Services.BaseClientService.Initializer()
        {
            HttpClientInitializer = credential,
            ApplicationName = ApplicationName,
        });
        ReadRow1();
        ReadRow2();
        ReadRow3();
        ReadRow4();
        ReadRow5();
    }

    public UnityEngine.UI.Text Username1;
    public UnityEngine.UI.Text Time1;
    public UnityEngine.UI.Text Username2;
    public UnityEngine.UI.Text Time2;
    public UnityEngine.UI.Text Username3;
    public UnityEngine.UI.Text Time3;
    public UnityEngine.UI.Text Username4;
    public UnityEngine.UI.Text Time4;
    public UnityEngine.UI.Text Username5;
    public UnityEngine.UI.Text Time5;

    public void ReadRow1()
    {
        var range = $"{sheet}!A1:M1";
        var request = service.Spreadsheets.Values.Get(SpreadsheetId, range);

        var response = request.Execute();
        var values = response.Values;

        if (values != null && values.Count > 0)
        {
            foreach (var row in values)
            {
                Username1.text = "1. " + ($"{row[0]}") + ":";
                Time1.text = "   " + ($"{row[1]}") + " seconds";
            }
        }
    }

    public void ReadRow2()
    {
        var range = $"{sheet}!A2:M2";
        var request = service.Spreadsheets.Values.Get(SpreadsheetId, range);

        var response = request.Execute();
        var values = response.Values;

        if (values != null && values.Count > 0)
        {
            foreach (var row in values)
            {
                Username2.text = "2. " + ($"{row[0]}") + ":";
                Time2.text = "   " + ($"{row[1]}") + " seconds";
            }
        }
    }

    public void ReadRow3()
    {
        var range = $"{sheet}!A3:M3";
        var request = service.Spreadsheets.Values.Get(SpreadsheetId, range);

        var response = request.Execute();
        var values = response.Values;

        if (values != null && values.Count > 0)
        {
            foreach (var row in values)
            {
                Username3.text = "3. " + ($"{row[0]}") + ":";
                Time3.text = "   " + ($"{row[1]}") + " seconds";
            }
        }
    }

    public void ReadRow4()
    {
        var range = $"{sheet}!A4:M4";
        var request = service.Spreadsheets.Values.Get(SpreadsheetId, range);

        var response = request.Execute();
        var values = response.Values;

        if (values != null && values.Count > 0)
        {
            foreach (var row in values)
            {
                Username4.text = "4. " + ($"{row[0]}") + ":";
                Time4.text = "   " + ($"{row[1]}") + " seconds";
            }
        }
    }

    public void ReadRow5()
    {
        var range = $"{sheet}!A5:M5";
        var request = service.Spreadsheets.Values.Get(SpreadsheetId, range);

        var response = request.Execute();
        var values = response.Values;

        if (values != null && values.Count > 0)
        {
            foreach (var row in values)
            {
                Username5.text = "5. " + ($"{row[0]}") + ":";
                Time5.text = "   " + ($"{row[1]}") + " seconds";
            }
        }
    }
}
