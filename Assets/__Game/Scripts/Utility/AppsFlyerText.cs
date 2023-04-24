using TMPro;
using UnityEngine;

public class AppsFlyerText : MonoBehaviour {
    [SerializeField] private TextMeshProUGUI dataText;

    private void Start() {
        AppsFlyerObjectScript.OnConversionDataSuccess += SetAppsFlyerText;
    }

    private void OnDisable() {
        AppsFlyerObjectScript.OnConversionDataSuccess -= SetAppsFlyerText;
    }

    private void SetAppsFlyerText(string aFText) {
        dataText.SetText(aFText);
    }
}