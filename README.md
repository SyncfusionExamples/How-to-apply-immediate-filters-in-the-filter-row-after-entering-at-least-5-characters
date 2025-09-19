
# How to apply immediate filters in the filter row after entering at least 5 characters in WPF DataGrid?


In [WPF DataGrid](https://www.syncfusion.com/wpf-controls/datagrid) (SfDataGrid), by default, filters are applied immediately upon entering text in the [FilterRow](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.RowFilter.FilterRow.html) when the  [GridColumn.ImmediateUpdateColumnFilter](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.GridColumn.html#Syncfusion_UI_Xaml_Grid_GridColumn_ImmediateUpdateColumnFilter) property is set to true for the corresponding column.

However, we can customize the immediate filter behavior of the FilterRow by creating a custom renderer that inherits from [FilterRowCellRenderers](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.SfDataGrid.html#Syncfusion_UI_Xaml_Grid_SfDataGrid_FilterRowCellRenderers). By overriding the **ProcessSingleFilter** method, filters can be applied when the filter value contains five or more characters, and removed when the filter length reaches zero.


**Overriding the renderer**
 ```C#
    this.datagrid.FilterRowCellRenderers.Remove("TextBox");
    this.datagrid.FilterRowCellRenderers.Add("TextBox", new GridFilterRowTextBoxRendererExt());
 ```
 
**GridFilterRowTextBoxRendererExt class**
 
 ```C#
 public class GridFilterRowTextBoxRendererExt : GridFilterRowTextBoxRenderer
 {
     public GridFilterRowTextBoxRendererExt() : base()
     {
     }

     public override void ProcessSingleFilter(object filterValue)
     {
         if (filterValue.ToString().Length >= 5)
             base.ProcessSingleFilter(filterValue);
     }  
  }
 ```
  
![sum68Emx48.gif](https://support.syncfusion.com/kb/agent/attachment/article/15724/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjIxNzE4Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.2EbZ-0tYRB8RNX1kOxEyIo4Ck7iRTkTchbLPzj9x7wg)

Take a moment to persue the [WPF DataGrid - FilterRow](https://help.syncfusion.com/wpf/datagrid/filterrow#customizing-filter-row-editors)  documentation, where you can find about the FilterRow customizations with code examples.
