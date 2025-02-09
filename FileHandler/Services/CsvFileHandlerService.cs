using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using FileHandler.Contracts;
using FileHandler.Dto;
using CsvHelper;
using CsvHelper.Configuration;
namespace FileHandler.Services
{
    public class CsvFileHandlerService<T> : IFileHandler<T> where T : new()
    {
        public List<T> Read(string filePath)
        {
            try {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HeaderValidated = null,
                    MissingFieldFound = null
                };

                using var reader = new StreamReader(filePath);
                using var csv = new CsvReader(reader, config);
                return csv.GetRecords<T>().ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return null;
            
        }


        public List<T> ParseCsvGeneric<T>(string filePath) where T : new()
        {
            List<T> records = new List<T>();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return records;
            }

            var properties = typeof(T).GetProperties();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string headerLine = reader.ReadLine(); // Read header
                if (headerLine == null) return records;

                var headers = headerLine.Split(',').Select(h => h.Trim()).ToArray();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    if (values.Length != headers.Length) continue;

                    T obj = new T();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        var prop = properties.FirstOrDefault(p => p.Name.Equals(headers[i], StringComparison.OrdinalIgnoreCase));
                        if (prop != null)
                        {
                            object value = Convert.ChangeType(values[i].Trim(), prop.PropertyType);
                            prop.SetValue(obj, value);
                        }
                    }
                    records.Add(obj);
                }
            }
            return records;
        }





        public void Write(string filePath, List<T> data)
        {
           
        }

        public void Delete(string filePath)
        {
           
        }
    }

}
