
using Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace EAAutoFramework.Helpers
{
    public class ExcelHelpers
    {

        private static List<Datacollection> _dataCol = new List<Datacollection>();

        //Storing all the excel values in to the in-memory collections
        public static void PopulateInCollection(string fileName)
        {
            DataTable table = ExcelToDataTable(fileName);

            //Iterate through the rows and columns of the Table
            for(int row = 1; row <= table.Rows.Count; row++)
            {
                for(int col = 0; col < table.Columns.Count; col++)
                {
                    Datacollection dtTable = new Datacollection()
                    {
                        rowNumber = row,
                        colName = table.Columns[col].ColumnName,
                        colValue = table.Rows[row -1][col].ToString()

                    };
                    //Add all the details for each row
                    _dataCol.Add(dtTable);
                }
            }
        }

        //Reading all the data from the excel sheets
        private static DataTable ExcelToDataTable(string fileName)
        {
            //open file and retuns as Stream
            FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
            //Createopenxmlreader via ExcelReaderFactory
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream); //.xlsx
            //Set the Firat Row as Column Name
            excelReader.IsFirstRowAsColumnNames = true;
            //Retur as DataSet
            DataSet result = excelReader.AsDataSet();
            //Get all the Tables
            DataTableCollection table = result.Tables;
            //Store it in DataTable
            DataTable resultTable = table["Sheet1"];
            //return
            return resultTable;

        }


        public static string ReadData(int rowNumber, string columnName)
        {
            try
            {
                //Retriving Data using LINQ to reduce much of iterations
                string data = (from colData in _dataCol
                               where colData.colName == columnName && colData.rowNumber == rowNumber
                               select colData.colValue).SingleOrDefault();

                return data.ToString();
            }catch(Exception e)
            {
                return null;
            }

        }

    }

    public class Datacollection
    {
        public int rowNumber { get; set; }
        public string colName { get; set; }

        public string colValue { get; set; }
    }
}
