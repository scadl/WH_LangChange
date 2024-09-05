namespace WH_LangChange
{

    using System;
    using System.Diagnostics;

    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using CsvHelper;
    using CsvHelper.Configuration;

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());


        }
    }

    internal class LangDicStor
    {
        Dictionary<string, string> langDic = new Dictionary<string, string>();

        public LangDicStor()
        {            
            langDic.Add("0x0409", "en-US");
            langDic.Add("0x0419", "ru-RU");
        }
        public string GetLang(string lang) { 
            return langDic["0x"+lang];
        }
    }
}