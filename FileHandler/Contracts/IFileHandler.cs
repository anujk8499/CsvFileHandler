using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandler.Contracts
{
    public interface IFileHandler<T>
    {
       public List<T> Read(string filePath);
        public void Write(string filePath, List<T> data);
        public void Delete(string filePath);

        public List<T> ParseCsvGeneric<T>(string filePath) where T : new();
    }
    }
