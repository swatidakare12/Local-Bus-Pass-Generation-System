#pragma checksum "C:\Users\swati\Desktop\Git\Sprint Project\Local Bus Pass Generation System\LocalBusPassMvcCore\Views\AdminHome\PassengerProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2658da22b3e7cb320dbc644969eefb2425164f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminHome_PassengerProfile), @"mvc.1.0.view", @"/Views/AdminHome/PassengerProfile.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2658da22b3e7cb320dbc644969eefb2425164f7", @"/Views/AdminHome/PassengerProfile.cshtml")]
    #nullable restore
    public class Views_AdminHome_PassengerProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LocalBussPassLibrary.Entities.Passenger>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    | <a href=""/logout"">Logout</a>
<section class=""vh-100"" style=""background-image: url('https://media.istockphoto.com/photos/chhatrapati-shivaji-picture-id667564382?k=20&m=667564382&s=612x612&w=0&h=CmUbMKkhjFdq09GWI6nrlmy-thQDmEF-EcY1djvyqFM='); background-repeat: no-repeat; background-position: center; background-size: cover; "">
    <div class=""container py-5 h-100"">
        <div class=""row d-flex justify-content-center align-items-center h-100"">
            <div class=""col-12 col-md-8 col-lg-6 col-xl-5"">
                <div class=""card shadow-2-strong"" style=""border-radius: 1rem;"">
                    <div class=""card-body p-5 text-center"">
                        <div>
                            <form action=""/adminhome/viewprofile"" method=""post"">
");
#nullable restore
#line 11 "C:\Users\swati\Desktop\Git\Sprint Project\Local Bus Pass Generation System\LocalBusPassMvcCore\Views\AdminHome\PassengerProfile.cshtml"
                                 if (ViewBag.Error != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"alert alert-dark\">");
#nullable restore
#line 13 "C:\Users\swati\Desktop\Git\Sprint Project\Local Bus Pass Generation System\LocalBusPassMvcCore\Views\AdminHome\PassengerProfile.cshtml"
                                                             Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 14 "C:\Users\swati\Desktop\Git\Sprint Project\Local Bus Pass Generation System\LocalBusPassMvcCore\Views\AdminHome\PassengerProfile.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"form-outline mb-4\">\r\n                                    <label for=\"Username\" class=\"control-label\">Enter Passenger Id</label>\r\n                                    ");
#nullable restore
#line 17 "C:\Users\swati\Desktop\Git\Sprint Project\Local Bus Pass Generation System\LocalBusPassMvcCore\Views\AdminHome\PassengerProfile.cshtml"
                               Write(Html.TextBoxFor(m => m.PassengerId, new { @class = "form-control form-control-lg" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <button class=\"btn btn-primary btn-lg btn-block\" type=\"submit\">Submit</button>\r\n                            </form>\r\n                        </div>\r\n                        <div>\r\n");
#nullable restore
#line 23 "C:\Users\swati\Desktop\Git\Sprint Project\Local Bus Pass Generation System\LocalBusPassMvcCore\Views\AdminHome\PassengerProfile.cshtml"
                             if (Model != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <h3 class=""mb-5"">Passenger Profile</h3>
                                <div class=""table-scroll"">
                                    <table>
                                        <tbody>
                                            <tr>
                                                <th scope=""row"">Passenger ID </th>
                                                <td>  ");
#nullable restore
#line 31 "C:\Users\swati\Desktop\Git\Sprint Project\Local Bus Pass Generation System\LocalBusPassMvcCore\Views\AdminHome\PassengerProfile.cshtml"
                                                 Write(Model.PassengerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            </tr>\r\n\r\n                                            <tr>\r\n                                                <th scope=\"row\"> Name </th>\r\n                                                <td>");
#nullable restore
#line 36 "C:\Users\swati\Desktop\Git\Sprint Project\Local Bus Pass Generation System\LocalBusPassMvcCore\Views\AdminHome\PassengerProfile.cshtml"
                                               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            </tr>\r\n\r\n                                            <tr>\r\n                                                <th scope=\"row\">Email </th>\r\n                                                <td>");
#nullable restore
#line 41 "C:\Users\swati\Desktop\Git\Sprint Project\Local Bus Pass Generation System\LocalBusPassMvcCore\Views\AdminHome\PassengerProfile.cshtml"
                                               Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            </tr>\r\n\r\n                                            <tr>\r\n                                                <th scope=\"row\">Address </th>\r\n                                                <td>");
#nullable restore
#line 46 "C:\Users\swati\Desktop\Git\Sprint Project\Local Bus Pass Generation System\LocalBusPassMvcCore\Views\AdminHome\PassengerProfile.cshtml"
                                               Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            </tr>\r\n\r\n                                            <tr>\r\n                                                <th scope=\"row\">Age </th>\r\n                                                <td>");
#nullable restore
#line 51 "C:\Users\swati\Desktop\Git\Sprint Project\Local Bus Pass Generation System\LocalBusPassMvcCore\Views\AdminHome\PassengerProfile.cshtml"
                                               Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            </tr>\r\n\r\n                                            <tr>\r\n                                                <th scope=\"row\">Gender </th>\r\n                                                <td>");
#nullable restore
#line 56 "C:\Users\swati\Desktop\Git\Sprint Project\Local Bus Pass Generation System\LocalBusPassMvcCore\Views\AdminHome\PassengerProfile.cshtml"
                                               Write(Model.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            </tr>\r\n\r\n                                            <tr>\r\n                                                <th scope=\"row\">AadharId </th>\r\n                                                <td>");
#nullable restore
#line 61 "C:\Users\swati\Desktop\Git\Sprint Project\Local Bus Pass Generation System\LocalBusPassMvcCore\Views\AdminHome\PassengerProfile.cshtml"
                                               Write(Model.AadharId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            </tr>\r\n                                        </tbody>\r\n                                    </table>\r\n                                </div>\r\n");
#nullable restore
#line 66 "C:\Users\swati\Desktop\Git\Sprint Project\Local Bus Pass Generation System\LocalBusPassMvcCore\Views\AdminHome\PassengerProfile.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                        <div class=""form-outline mb-4"">
                            <a href=""/adminhome"">Return to Admin Home</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LocalBussPassLibrary.Entities.Passenger> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
