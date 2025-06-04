# How to show the rendered HTML inside the ToolTip of the WPF SfDataGrid

By default, SfDataGrid does not have built-in support to render HTML code and display it in the tooltip. However, we can achieve this requirement by rendering the HTML using SfRichTextBox.

In this approach, load the HTML code into SfRichTextBox, render the HTML content, and then set SfRichTextBox as the tooltip content inside the CellToolTipOpening event.

**Step 1: Subscribe to the CellToolTipOpening Event of the SfDataGrid**
                         
 Subscribe to the CellToolTipOpening event of SfDataGrid, and enable the ShowTooltip property for the desired column where the tooltip should be displayed.

 ```xml
<syncfusion:SfDataGrid HorizontalAlignment="Center"  
                       x:Name="dataGrid"  
                       ItemsSource="{Binding Orders}" 
                       AutoGenerateColumns="False" 
                       CellToolTipOpening="dataGrid_CellToolTipOpening"  >
    <syncfusion:SfDataGrid.Columns>
          <syncfusion:GridTextColumn HeaderText="Customer ID" 
                                     MappingName="CustomerID" 
                                     ShowToolTip="True"  />
        <syncfusion:GridTextColumn HeaderText="Customer Name" 
                                   MappingName="CustomerName"/>
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid> 
 ```
**Step 2: Handle the Event**
           
   In the event handler, retrieve the HTML code, convert it into a stream, and pass it to RichTextBoxAdv. Then, set RichTextBoxAdv as the tooltip content of the SfDataGrid.

 ```csharp
    SfRichTextBoxAdv richTextBoxAdv = new SfRichTextBoxAdv() { Width = 300, Height = 200, LayoutType = LayoutType.Continuous};

    private void dataGrid_CellToolTipOpening(object sender, Syncfusion.UI.Xaml.Grid.GridCellToolTipOpeningEventArgs e)
    {
        string htmlContent = (e.Record as OrderInfo).HTMLCode;
        Stream stream = new MemoryStream();
        byte[] bytes = Encoding.UTF8.GetBytes(htmlContent);
        stream.Write(bytes, 0, bytes.Length);
        stream.Position = 0;
        richTextBoxAdv.Load(stream, FormatType.Html);
        e.ToolTip.Content = richTextBoxAdv;
    }
 ```

 ![ToolTip display HTML value](ToolTipdisplayHTML.png)

Take a moment to peruse the [WPF SfDataGrid - ToolTip](https://help.syncfusion.com/wpf/datagrid/tooltip){target="_blank"} documentation where you can find about the tooltip with code examples.