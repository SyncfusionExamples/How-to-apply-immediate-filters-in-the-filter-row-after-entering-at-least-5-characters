using Syncfusion.Data.Extensions;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Cells;
using Syncfusion.UI.Xaml.Grid.RowFilter;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SfDataGrid_Demo4_8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            this.datagrid.FilterRowCellRenderers.Remove("TextBox");
            this.datagrid.FilterRowCellRenderers.Add("TextBox", new GridFilterRowTextBoxRendererExt());
        }
    }

    public class GridFilterRowTextBoxRendererExt : GridFilterRowTextBoxRenderer
    {
        public GridFilterRowTextBoxRendererExt() : base()
        {
        }
        public override void ProcessSingleFilter(object filterValue)
        {
            if (filterValue.ToString().Length >= 5 || filterValue.ToString().Length == 0) 
                base.ProcessSingleFilter(filterValue);
        }
       
    }

}
