using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;

namespace SentezSwaggerIntro.Models
{
    public class ApiModels
    {
        public class BOTable
        {
            public BOTable()
            {
                Columns = new List<BOColumn>();
                Values = new List<List<object>>();
            }
            public string Name { get; set; }
            public string Caption { get; set; }
            public List<BOColumn> Columns { get; set; }
            public List<List<object>> Values { get; set; }
        }
        public class BOColumn
        {
            public string Name { get; set; }
            public string Caption { get; set; }
            public object UdtType { get; set; }
            public object Usage { get; set; }
        }

        #region
        public class Filter
        {
            public string ParentRowRelationName { get; set; }
            public string TableName { get; set; }
            public string AliasName { get; set; }
            public string FieldName { get; set; }
            public long? Value { get; set; }
            public long Condition { get; set; }
            public long Concator { get; set; }
            public long Function { get; set; }
            public List<InnerCondition> InnerConditions { get; set; }
            public List<object> RangeValues { get; set; }
            public object ValueDelegate { get; set; }
        }
        public class InnerCondition
        {
            public string ParentRowRelationName { get; set; }
            public string TableName { get; set; }
            public string AliasName { get; set; }
            public string FieldName { get; set; }
            public long Value { get; set; }
            public long Condition { get; set; }
            public long Concator { get; set; }
            public long Function { get; set; }
            public List<object> InnerConditions { get; set; }
            public List<object> RangeValues { get; set; }
            public object ValueDelegate { get; set; }
        }
        public class BOLookups
        {
            public bool Cacheable { get; set; }
            public List<string> DisplayFieldAliases { get; set; }
            public List<string> DisplayFields { get; set; }
            public string QueryFieldAlias { get; set; }
            public string QueryField { get; set; }
            public string FKColumn { get; set; }
            public string FKTable { get; set; }
            public string PkTable { get; set; }
            public string PkField { get; set; }
            public List<Filter> Filters { get; set; }
            public List<string> FilterColumns { get; set; }
            public string WorkList { get; set; }
            public bool FKCheckValue { get; set; }
            public List<object> FieldFilters { get; set; }
        }
        #endregion

        #region
        public class ReportParameter
        {
            public long ReportType { get; set; }//1,2,3,4,5,6,7,8
            public string ReportName { get; set; }
            public string ColumnSetName { get; set; }
            public string DefName { get; set; }
            public string FilterSetName { get; set; }
            public string PolicyParamFieldName { get; set; }
            public string PolicyParamFormTagObj { get; set; }
            public string PolicyParamWhereStr { get; set; }
            public long PolicyParamRecordRecId { get; set; }
        }
        #endregion

        #region        
        public class SetModel
        {
            public int RecId { get; set; }
            public string SetCode { get; set; }
            public string SetName { get; set; }
        }
        public class LookupModel
        {
            public List<string> DisplayFields { get; set; }
            public string ValueField { get; set; }
            public List<SetModel> Data { get; set; }
        }
        #endregion

        public class PostDataModel
        {
            public string TableName { get; set; }
            public long ChangeType { get; set; }
            public long RowId { get; set; }
            public string ColumnName { get; set; }
            public object Value { get; set; }
        }
        public class SoDQueryModel
        {
            public string Query { get; set; }
        }
        public class Response
        {
            public bool IsOk { get; set; }
            public long ErrorCode { get; set; }
            public string ErrorMessage { get; set; }
            public string[] ServerMessages { get; set; }
            public object Data { get; set; }
        }
        public class SoDServiceModel
        {
            public string ServiceName { get; set; }
            public object[] Params { get; set; }
        }
        public class WindowSettingModel
        {
            public short ProductCode { get; set; }
            public int UserId { get; set; }
            public short Type { get; set; }
            public string WindowName { get; set; }
            public string ControlName { get; set; }
            public string PropertyName { get; set; }
            public string PropertyValue { get; set; }
        }
        public enum LanguagePackages
        {
            None = 0,
            Spanish,
            Turkish = 1055,
            Germanian = 1031,
            English = 1033,
            Italian,
            Chinese = 2052,
            French = 1036,
            Arabic = 3073,
            Vietnamese = 1066,
            Russian = 1049
        }

        public static Dictionary<string, object> dataRow1 = new Dictionary<string, object>();
        public static Dictionary<string, object> dataRow2 = new Dictionary<string, object>();
        public static List<Dictionary<string, object>> dataTable = new List<Dictionary<string, object>>();
        public static Dictionary<string, List<Dictionary<string, object>>> dataSet = new Dictionary<string, List<Dictionary<string, object>>>();
        
        public static void Fonk1()
        {
            dataRow1.Add("InventoryCode", "CK-01");
            dataRow1.Add("InventoryName", "MK-01");
            dataRow1.Add("Quantity", 10);

            dataRow2.Add("InventoryCode", "CK-02");
            dataRow2.Add("InventoryName", "MK-02");
            dataRow2.Add("Quantity", 15);

            dataTable.Add(dataRow1);
            dataTable.Add(dataRow2);

            dataSet.Add("Erp_Inventory", dataTable);
            foreach (var row in dataTable)
            {
                row["InventoryCode"].ToString();
                row["InventoryName"].ToString();
                row["Quantity"].ToString();
            }
        }
    }
}
