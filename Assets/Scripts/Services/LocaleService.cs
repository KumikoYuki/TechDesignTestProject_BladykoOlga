using System.Collections;
using UnityEngine;
using UnityEngine.Localization.Settings;

namespace MainMenu
{
    public class LocaleService : MonoBehaviour
    {
        private bool _active = false;
        
        public void ChangeLocale(int index)
        {
            if (_active)
                return;

            StartCoroutine(ChangeLanguage(index));
        }

        private IEnumerator ChangeLanguage(int index)
        {
            _active = true;
            yield return LocalizationSettings.InitializationOperation;

            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[index];
            
            _active = false;
        }
    }
}