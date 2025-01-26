using System.Data;
using ExcelDataReader;

namespace Klinrek.Class {
    public static class FileReader { 
        public static DataSet ReadFile(string filePath) {
            DataSet result;
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read)) {
                using (var reader = ExcelReaderFactory.CreateReader(stream)) {
                    result = reader.AsDataSet(); 
                }
            }
            return result;
        }
    }
}