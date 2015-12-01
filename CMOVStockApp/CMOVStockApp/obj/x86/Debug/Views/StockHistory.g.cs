﻿#pragma checksum "C:\Users\João Sá\Git\CMOVStockApp\CMOVStockApp\CMOVStockApp\Views\StockHistory.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "28E8996239FBF4B6B3C13C273E16242D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CMOVStockApp.Views
{
    partial class StockHistory : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
        };

        private class StockHistory_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IStockHistory_Bindings
        {
            private global::CMOVStockApp.Views.StockHistory dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ComboBox obj2;

            public StockHistory_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2:
                        this.obj2 = (global::Windows.UI.Xaml.Controls.ComboBox)target;
                        break;
                    default:
                        break;
                }
            }

            // IStockHistory_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            // StockHistory_obj1_Bindings

            public void SetDataRoot(global::CMOVStockApp.Views.StockHistory newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::CMOVStockApp.Views.StockHistory obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_options(obj.options, phase);
                    }
                }
            }
            private void Update_options(global::System.Collections.ObjectModel.ObservableCollection<global::System.String> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj2, obj, null);
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2:
                {
                    this.DecideCompany = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 3:
                {
                    this.ButtonLastWeek = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 14 "..\..\..\Views\StockHistory.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ButtonLastWeek).Click += this.buttonGetLastWeekClick;
                    #line default
                }
                break;
            case 4:
                {
                    this.ButtonLastMonth = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 15 "..\..\..\Views\StockHistory.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ButtonLastMonth).Click += this.buttonGetLastMonthClick;
                    #line default
                }
                break;
            case 5:
                {
                    this.ButtonLast6Month = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 16 "..\..\..\Views\StockHistory.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ButtonLast6Month).Click += this.buttonGetLast6MonthClick;
                    #line default
                }
                break;
            case 6:
                {
                    this.ButtonLastYear = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 17 "..\..\..\Views\StockHistory.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ButtonLastYear).Click += this.buttonGetLastYearClick;
                    #line default
                }
                break;
            case 7:
                {
                    this.LineChart = (global::WinRTXamlToolkit.Controls.DataVisualization.Charting.Chart)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    StockHistory_obj1_Bindings bindings = new StockHistory_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

