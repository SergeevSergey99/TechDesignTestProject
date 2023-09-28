using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class ToggleLocale : MonoBehaviour
{
    [SerializeField] private LocalizationSettings localizationSettings;
    
    public void ToggleLocaleTo()
    {
        var locales = localizationSettings.GetAvailableLocales().Locales;
        
        var index = locales.FindIndex(localizationSettings.GetSelectedLocale().Equals);
        localizationSettings.SetSelectedLocale(locales[(index + 1) % locales.Count]);
    }
}
