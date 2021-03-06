﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Pizza.Mvc;
    using Pizza.Mvc.HtmlHelpers;
    
    #line 1 "..\..\Views\Account\Login.cshtml"
    using Pizza.Mvc.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/Login.cshtml")]
    public partial class _Views_Account_Login_cshtml : System.Web.Mvc.WebViewPage<Pizza.Contracts.Security.ViewModels.LoginViewModel>
    {
        public _Views_Account_Login_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Account\Login.cshtml"
  
    ViewBag.Title = UiTexts.LoginPage_Title;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2>");

            
            #line 7 "..\..\Views\Account\Login.cshtml"
Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral(".</h2>\r\n<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-md-8\"");

WriteLiteral(">\r\n        <section");

WriteLiteral(" id=\"loginForm\"");

WriteLiteral(">\r\n");

            
            #line 11 "..\..\Views\Account\Login.cshtml"
            
            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\Account\Login.cshtml"
             using (Html.BeginForm("Login", "Account", new { ReturnUrl = Request.QueryString["ReturnUrl"] }, FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
            {
                
            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\Account\Login.cshtml"
           Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\Account\Login.cshtml"
                                        

            
            #line default
            #line hidden
WriteLiteral("                <h4>");

            
            #line 14 "..\..\Views\Account\Login.cshtml"
               Write(UiTexts.LoginPage_Message);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n");

WriteLiteral("                <hr />\r\n");

            
            #line 16 "..\..\Views\Account\Login.cshtml"
                
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Account\Login.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Account\Login.cshtml"
                                                                                 

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 18 "..\..\Views\Account\Login.cshtml"
               Write(Html.LabelFor(m => m.UserName, new { @class = "col-md-2 control-label" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 20 "..\..\Views\Account\Login.cshtml"
                   Write(Html.TextBoxFor(m => m.UserName, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 21 "..\..\Views\Account\Login.cshtml"
                   Write(Html.ValidationMessageFor(m => m.UserName, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");

WriteLiteral("                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 25 "..\..\Views\Account\Login.cshtml"
               Write(Html.LabelFor(m => m.Password, new { @class = "col-md-2 control-label" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 27 "..\..\Views\Account\Login.cshtml"
                   Write(Html.PasswordFor(m => m.Password, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 28 "..\..\Views\Account\Login.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Password, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");

WriteLiteral("                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-md-offset-2 col-md-10\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"checkbox\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 34 "..\..\Views\Account\Login.cshtml"
                       Write(Html.CheckBoxFor(m => m.RememberMe));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 35 "..\..\Views\Account\Login.cshtml"
                       Write(Html.LabelFor(m => m.RememberMe));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </d" +
"iv>\r\n");

WriteLiteral("                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-md-offset-2 col-md-10\"");

WriteLiteral(">\r\n                        <input");

WriteLiteral(" type=\"submit\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2021), Tuple.Create("\"", 2060)
            
            #line 41 "..\..\Views\Account\Login.cshtml"
, Tuple.Create(Tuple.Create("", 2029), Tuple.Create<System.Object, System.Int32>(UiTexts.LoginPage_Button_Login
            
            #line default
            #line hidden
, 2029), false)
);

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n");

            
            #line 44 "..\..\Views\Account\Login.cshtml"
                
            
            #line default
            #line hidden
            
            #line 46 "..\..\Views\Account\Login.cshtml"
                      
            }

            
            #line default
            #line hidden
WriteLiteral("        </section>\r\n    </div>\r\n</div>\r\n\r\n");

DefineSection("Scripts", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 53 "..\..\Views\Account\Login.cshtml"
Write(Scripts.Render("~/bundles/jqueryval"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

        }
    }
}
#pragma warning restore 1591
