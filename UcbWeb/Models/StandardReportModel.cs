//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;

namespace UcbWeb.Models
{
    public partial class StandardReportModel : BaseModel
    {
    
        public virtual System.Guid Code
        {
            get { return _code; }
            set { _code = value; }
        }
        private System.Guid _code;
    
        public virtual string ReportName
        {
            get { return _reportName; }
            set { _reportName = value; }
        }
        private string _reportName;
    
        public virtual string ReportDescription
        {
            get { return _reportDescription; }
            set { _reportDescription = value; }
        }
        private string _reportDescription;
    
        public virtual System.Guid ReportCategoryCode
        {
            get { return _reportCategoryCode; }
            set { _reportCategoryCode = value; }
        }
        private System.Guid _reportCategoryCode;
    
        public virtual int SortOrder
        {
            get { return _sortOrder; }
            set { _sortOrder = value; }
        }
        private int _sortOrder;
    
        public virtual string ReportUrl
        {
            get { return _reportUrl; }
            set { _reportUrl = value; }
        }
        private string _reportUrl;
    
        public virtual bool IsPrintable
        {
            get { return _isPrintable; }
            set { _isPrintable = value; }
        }
        private bool _isPrintable;
    
        public virtual bool IsExportable
        {
            get { return _isExportable; }
            set { _isExportable = value; }
        }
        private bool _isExportable;
    
        public virtual byte[] RowIdentifier
        {
            get { return _rowIdentifier; }
            set { _rowIdentifier = value; }
        }
        private byte[] _rowIdentifier;
    }
}