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

        

        public void Write(string filePath, List<T> data)
        {
           
        }

        public void Delete(string filePath)
        {
           
        }
    }

}
