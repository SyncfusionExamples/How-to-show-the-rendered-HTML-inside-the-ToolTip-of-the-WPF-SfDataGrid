using System;
using System.Collections.Generic;
using System.IO;
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
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.Windows.Controls.RichTextBoxAdv;

namespace WPFDataGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        SfRichTextBoxAdv richTextBoxAdv = new SfRichTextBoxAdv() { Width = 300, Height = 200, LayoutType = LayoutType.Continuous };
        private void OnCellToolTipOpening(object sender, GridCellToolTipOpeningEventArgs e)
        {
            if (e.Record != null && e.Record is OrderInfo)
            {
                string htmlContent = (e.Record as OrderInfo).HTMLCode;
                if (htmlContent != null)
                {
                    Stream stream = new MemoryStream();
                    byte[] bytes = Encoding.UTF8.GetBytes(htmlContent);
                    if (bytes != null)
                        stream.Write(bytes, 0, bytes.Length);
                    stream.Position = 0;
                    richTextBoxAdv.Load(stream, FormatType.Html);
                    e.ToolTip.Content = richTextBoxAdv;
                }      
            }
        }
    }
}
