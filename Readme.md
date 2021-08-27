<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128566055/15.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T263406)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/DXWebApplication1/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/DXWebApplication1/Controllers/HomeController.vb))
* **[Index.cshtml](./CS/DXWebApplication1/Views/Home/Index.cshtml)**
* [_Layout.cshtml](./CS/DXWebApplication1/Views/Shared/_Layout.cshtml)
<!-- default file list end -->
# How to apply Bootstrap Form (form-control, btn) style to DevExpress editors in Native mode
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t263406/)**
<!-- run online end -->


This example illustrates how to enable the Native rendering mode (by setting the Native property to True) in order to produce the raw HTML elements and apply the Bootstrap <a href="http://getbootstrap.com/css/#forms">Form</a> (form-control, btn, etc.) style.<br />There is also a side-by-side comparison with the same set if editors in the DevExprss <a href="https://demos.devexpress.com/ASP/Themes/Default.aspx?Theme=Moderno&Control=1">Moderno</a> theme (applied in the Web.config) that has a similar color schema as the Bootstrap.<br /><br />The main requirement is to set the editor's <a href="https://documentation.devexpress.com/#AspNet/CustomDocument11893">Native</a> property in order to produce the raw HTML rendering and apply the Bootstrap style via the CssClass property:<br /><br />


```cs
@Html.DevExpress().TextBox(settings => {
    ...
    settings.ControlStyle.CssClass = "form-control";
    settings.Properties.Native = true;
}).GetHtml()

@Html.DevExpress().Memo(settings => {
    ...
    settings.ControlStyle.CssClass = "form-control";
    settings.Properties.Native = true;
}).GetHtml()

@Html.DevExpress().Button(settings => {
    ...
    settings.ControlStyle.CssClass = "btn btn-primary";
    settings.Styles.Native = true;
}).GetHtml()
```


<br />Optionally, it may be necessary to specify the editor's Width and Height dimensions (in percent or pixels) in order to achieve a consistent/custom layout.<br /><br /><strong>WebForms Version:</strong><br /><a href="https://www.devexpress.com/Support/Center/p/T263405">How to apply a Bootstrap Form (form-control, btn, etc.) style to the DevExpress editors in Native mode</a>

<br/>


