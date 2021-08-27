<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128655215/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T156704)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WpfApplication57/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication57/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfApplication57/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApplication57/MainWindow.xaml.vb))
<!-- default file list end -->
# How to: Generate Properties in PropertyGridControl From a Collection


<p>This example demonstrates how to create <a href="https://documentation.devexpress.com/#WPF/CustomDocument15521">Property Definitions</a> and <a href="https://documentation.devexpress.com/#WPF/CustomDocument15719">Collection Definitions</a> based on a data source collection. For this, you can utilize the following properties.<br><br>The <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPropertyGridPropertyGridControl_PropertyDefinitionsSourcetopic">PropertyDefinitionsSource</a> property can be bound to a collection of custom objects.<br><br>The <a href="https://documentation.devexpress.com/WPF/DevExpressXpfPropertyGridPropertyGridControl_PropertyDefinitionTemplatetopic.aspx">PropertyDefinitionTemplate</a>, <a href="https://documentation.devexpress.com/WPF/DevExpressXpfPropertyGridPropertyGridControl_PropertyDefinitionStyletopic.aspx">PropertyDefinitionStyle</a>, <a href="https://documentation.devexpress.com/WPF/DevExpressXpfPropertyGridPropertyGridControl_PropertyDefinitionTemplateSelectortopic.aspx">PropertyDefinitionTemplateSelector</a> properties are used to configure generated Property Definition objects. If the PropertyDefinitionsSource collection contains PropertyDefinition objects, the use of these properties is unnecessary.</p>

<br/>


