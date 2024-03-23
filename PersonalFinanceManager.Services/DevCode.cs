using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PersonalFinanceManager.Services
{
    public static class DevCode
    {
        public static int ToInt32(this string value)
        {
            return Convert.ToInt32(value);
        }

        public static T ToEnum<T>(this string str) where T : Enum
        {
            return (T)Enum.Parse(typeof(T), str, true);
        }

        public static string ToThousandSeparator(this decimal dec)
        {
            return dec.ToString("n0");
        }

        public static DataTable ToDataTable(this List<dynamic> items)
        {
            DataTable dataTable = new DataTable();
            if (items.Count == 0)
                return dataTable;

            // Get properties of the first item
            var firstItem = items[0];
            var propertyInfos = ((object)firstItem).GetType().GetProperties();

            // Create columns in DataTable
            foreach (var propertyInfo in propertyInfos)
            {
                dataTable.Columns.Add(propertyInfo.Name, Nullable.GetUnderlyingType(propertyInfo.PropertyType) ?? propertyInfo.PropertyType);
            }

            // Add rows to DataTable
            foreach (var item in items)
            {
                DataRow row = dataTable.NewRow();
                foreach (var propertyInfo in propertyInfos)
                {
                    row[propertyInfo.Name] = propertyInfo.GetValue(item) ?? DBNull.Value;
                }
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

        public static DataTable ToJson2DataTable(this string json)
        {
            JArray jsonArray = JArray.Parse(json);
            DataTable dataTable = new DataTable();

            if (jsonArray.Count == 0)
                return dataTable;

            var properties = jsonArray.First().Children<JProperty>();

            foreach (JProperty property in properties)
            {
                dataTable.Columns.Add(property.Name, typeof(string));
            }

            foreach (JObject jsonObject in jsonArray)
            {
                DataRow row = dataTable.NewRow();
                foreach (JProperty property in jsonObject.Children<JProperty>())
                {
                    row[property.Name] = property.Value.ToString();
                }
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

        public static string ToJson(this object dt)
        {
            return JsonConvert.SerializeObject(dt);
        }
    }
}
