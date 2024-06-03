using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppBankProjekt
{
    public static class JSONHelper
    {
        public static void saveAsJson<T>(List<T> list, string path)
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true }; // JSON formatını daha okunabilir yapmak için
                string jsonString = JsonSerializer.Serialize(list, options);
                File.WriteAllText(path, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving data to {path}: {ex.Message}");
            }
        }
        public static List<T> ReadFromJson<T>(string path)
        {
            try
            {
                string jsonString = File.ReadAllText(path);
                List<T> list = JsonSerializer.Deserialize<List<T>>(jsonString);
                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while reading data from {path}: {ex.Message}");
                return null;
            }
        }
    }
}
