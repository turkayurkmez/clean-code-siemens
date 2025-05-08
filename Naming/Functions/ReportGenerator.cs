using Functions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    /// <summary>
    /// Bir Excel dosyasından rapor üretme amacıyla kullanılır
    /// </summary>
    public class ReportGenerator
    {
        /*
         * Amaç: Belirli bir formattaki excel dosyası içinde yer alan verileri bir PDF raporuna dönüştürmek...
         * 
         */

        private string excelFilePath;
        public ReportGenerator(string filePath)
        {
            //1. filePath parametresi dolu mu boş mu?
            //2. Dosya var mı yok mu?
            //3. Excel dosyası doğru formatta mı?



            //if (string.IsNullOrEmpty(filePath))
            //{
            //    throw new Exception("FilePath boş olamaz");
            //}

            //if (!File.Exists(filePath))
            //{
            //    throw new FileNotFoundException("Dosya bulunamadı");
            //}

            //if (!isTrueFormat)
            //{
            //    throw new Exception("Excel formatı uygun değil");
            //}

            try
            {
                checkFileNameIsValid(filePath);
            }
            catch (Exception ex)
            {

                throw;
            }
            excelFilePath = filePath;

            //if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath) && true  )
            //{
            //    excelFilePath = filePath;
            //}

            //if (!string.IsNullOrEmpty(filePath))
            //{
            //    if (File.Exists(filePath))
            //    {
            //        if (isTrueFormat)
            //        {
            //            excelFilePath = filePath;
            //        }
            //        throw new Exception("Excel dosyası hatalı ");
            //    }
            //    else
            //    {
            //        throw new Exception("Belirttiğiniz adresde dosya yok");
            //    }
            //}
            //else
            //{
            //    throw new Exception("FilePath boş olamaz");
            //}

            //throw new Exception("Dosya parametresi hatalı olduğundan.....");
        }

        bool parameterIsEmpty(string parameterName) { 
            return string.IsNullOrEmpty(parameterName);
        }

        bool isFileExists(string fileName)
        {
            return File.Exists(fileName);
        }

        bool isExcelAvailable(string fileName) {
            return false;
        }

        void checkFileNameIsValid(string fileName) {
            if (parameterIsEmpty(fileName))
            {
                throw new ArgumentNullException("Parametre boş olamaz");
            }

            if (!isFileExists(fileName))
            {
                throw new FileNotFoundException("Dosya bulunamadı");
            }

            if (!isExcelAvailable(fileName))
            {
                throw new ExcelFormatException("Format yanlış", "Sadece perfomans raporları")
                {
                    Source = "ReportGenerator sınıfının constructor'u tarafından fırlatıldı"
                };
            }
        }

        /// <summary>
        /// Bu metot, belirtilen formatta rapor oluşturur.
        /// </summary>
        /// <param name="format">Lütfen talep ettiğiniz formatı seçiniz (PDF ya da HTML)</param>
        public void CreateReport(string format)
        {
            Console.WriteLine("Rapor oluluşturuldu...");
        }

    }
}
