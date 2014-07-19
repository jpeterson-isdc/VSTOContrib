using System;

namespace VSTOContrib.Core.RibbonFactory
{
    public class NewViewEventArgs : EventArgs
    {
        readonly OfficeWin32Window viewInstance;
        readonly object viewContext;
        readonly string ribbonType;

        public NewViewEventArgs(OfficeWin32Window viewInstance, object viewContext, string ribbonType)
        {
            this.viewInstance = viewInstance;
            this.viewContext = viewContext;
            this.ribbonType = ribbonType;
        }

        public string RibbonType
        {
            get { return ribbonType; }
        }

        public OfficeWin32Window ViewInstance
        {
            get { return viewInstance; }
        }

        public object ViewContext
        {
            get { return viewContext; }
        }

        /// <summary>
        /// True if a viewmodel was wired up to the view. If false call Marshal.ReleaseComObject on view. 
        /// DO NOT release com object if this property is true
        /// </summary>
        public bool Handled { get; set; }
    }
}