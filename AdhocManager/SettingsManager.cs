﻿using AdhocManager.Properties;

namespace AdhocManager
{
    internal class SettingsManager
    {
        public string Password
        {
            get { return Settings.Default.Password; }
            set { Settings.Default.Password = value; }
        }

        public string Ssid
        {
            get { return Settings.Default.SSID; }
            set { Settings.Default.SSID = value; }
        }

        public string Language
        {
            get { return Settings.Default.Language; }
            set { Settings.Default.Language = value; }
        }

        public void Save()
        {
            Settings.Default.Save();
        }
    }
}
