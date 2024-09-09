namespace WH_LangChange
{

    using System;
    using System.Diagnostics;

    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using CsvHelper;
    using CsvHelper.Configuration;
    using System.Resources;
    using System.Reflection;

    public class langCodes
    {
        // Language,Location,Language_ID,Language_tag,Supported_version
        public string Language { get; set; }
        public string Location { get; set; }
        public string Language_ID { get; set; }
        public string Language_tag { get; set; }
        public string Supported_version { get; set; }
    }

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
        // In C# assoc array is replaced with Dictionaries. The are more flexible, because can have mutople field with one key.
        Dictionary<string, string> langDic = new Dictionary<string, string>();
        IEnumerable<langCodes> langCodesStor;
        string[] lngList;

        public LangDicStor()
        {
            // Assembly is used to extract CSV storage file from app's resocurces, and put into file stream
            // CSV processing is very striagforvard, if field of storage class a similar to first rown in csv
            // https://code-maze.com/csharp-read-data-from-csv-file/
            var assembly = Assembly.GetExecutingAssembly();
            Stream myStream = assembly.GetManifestResourceStream("WH_LangChange.ms_lang_list.csv");
            using (var stReader = new StreamReader(myStream))
            using (var csvReader = new CsvReader(stReader, CultureInfo.InvariantCulture))
            {
               langCodesStor = csvReader.GetRecords<langCodes>();
                foreach (var langCode in langCodesStor)
                {
                    if (!langDic.ContainsKey(langCode.Language_ID))
                    {
                        langDic.Add(langCode.Language_ID, langCode.Language_tag);
                    }
                }
            }
        }

        public Dictionary<string, string> GetFullList()
        {
            return langDic;
        }

        public string GetLang(string lang) {
            return langDic["0x"+lang] ;
        }
    }
}