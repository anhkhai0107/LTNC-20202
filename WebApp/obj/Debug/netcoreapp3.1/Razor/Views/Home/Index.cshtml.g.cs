#pragma checksum "D:\tai lieu\Nam 4\20202\Lap trinh nang cao\LTNC-20202\WebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d960562850a45e8529a732e066ed8d9d8ee86f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "D:\tai lieu\Nam 4\20202\Lap trinh nang cao\LTNC-20202\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\tai lieu\Nam 4\20202\Lap trinh nang cao\LTNC-20202\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d960562850a45e8529a732e066ed8d9d8ee86f7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<LedModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\tai lieu\Nam 4\20202\Lap trinh nang cao\LTNC-20202\WebApp\Views\Home\Index.cshtml"
   ViewData["Title"] = "Home"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col-sm-2""></div>
    <div class=""col-sm-8"">
        <h2 class=""text-center m-3"">Smart Home <span id=""time"" class=""m-3""></span></h2>
    </div>    
    <div class=""col-sm-2""></div>
</div>
    <hr />
    <div class=""row"">
        <div class=""col-sm-3""></div>        
        <div class=""col-sm-6"">
            <div class=""card"">
                <div class=""card-header bg-primary text-white"">Devices</div>
                <div class=""card-body"">
                    <div class=""m-3"">
                        <span class=""badge badge-success"" style=""font-size:15px;"">Led 1:</span>
                        <input class=""switch"" data-room=""1"" ison type=""checkbox"" data-toggle=""toggle"" data-onstyle=""primary"" />
                        <span");
            BeginWriteAttribute("class", " class=\"", 845, "\"", 879, 2);
            WriteAttributeValue("", 853, "float-right", 853, 11, true);
#nullable restore
#line 21 "D:\tai lieu\Nam 4\20202\Lap trinh nang cao\LTNC-20202\WebApp\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 864, Model[0].isOn, 865, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" data-room=""1""></span>
                    </div>
                    <hr />
                    <div class=""m-3"">
                        <span class=""badge badge-success"" style=""font-size:15px;"">Led 2:</span>
                        <input class=""switch"" data-room=""2"" type=""checkbox"" data-toggle=""toggle"" data-onstyle=""primary"" />
                        <span");
            BeginWriteAttribute("class", " class=\"", 1249, "\"", 1283, 2);
            WriteAttributeValue("", 1257, "float-right", 1257, 11, true);
#nullable restore
#line 27 "D:\tai lieu\Nam 4\20202\Lap trinh nang cao\LTNC-20202\WebApp\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1268, Model[1].isOn, 1269, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" data-room=""2""></span>
                    </div>
                    <hr />
                    <div class=""m-3"">
                        <span class=""badge badge-success"" style=""font-size:15px;"">Led 3:</span>
                        <input class=""switch"" data-room=""3"" type=""checkbox"" data-toggle=""toggle"" data-onstyle=""primary"" />
                        <span");
            BeginWriteAttribute("class", " class=\"", 1653, "\"", 1687, 2);
            WriteAttributeValue("", 1661, "float-right", 1661, 11, true);
#nullable restore
#line 33 "D:\tai lieu\Nam 4\20202\Lap trinh nang cao\LTNC-20202\WebApp\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1672, Model[2].isOn, 1673, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" data-room=""3""></span>
                    </div>
                    <hr />
                    <div class=""m-3"">
                        <span class=""badge badge-success"" style=""font-size:15px;"">Led 4:</span>
                        <input class=""switch"" data-room=""4"" type=""checkbox"" data-toggle=""toggle"" data-onstyle=""primary"" />
                        <span");
            BeginWriteAttribute("class", " class=\"", 2057, "\"", 2091, 2);
            WriteAttributeValue("", 2065, "float-right", 2065, 11, true);
#nullable restore
#line 39 "D:\tai lieu\Nam 4\20202\Lap trinh nang cao\LTNC-20202\WebApp\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 2076, Model[3].isOn, 2077, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" data-room=""4""></span>
                    </div>
                </div>
                <div class=""card-footer"">
                    <div class=""d-flex justify-content-center"">
                        <input class=""btn btn-primary btn-control"" type=""button"" value=""Turn on all"">
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-sm-3""></div>
    </div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n        <script>\r\n\r\n        $(() => {\r\n            toastr.options = {\r\n                \"preventDuplicates\": true\r\n            }\r\n\r\n            $(document).ready(function () {\r\n                if (\"");
#nullable restore
#line 61 "D:\tai lieu\Nam 4\20202\Lap trinh nang cao\LTNC-20202\WebApp\Views\Home\Index.cshtml"
                Write(Model[0].isOn);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" == \"on\") {\r\n                        $(`.switch[data-room=\'${1}\']`).bootstrapToggle(\'on\', true)\r\n                }\r\n                if (\"");
#nullable restore
#line 64 "D:\tai lieu\Nam 4\20202\Lap trinh nang cao\LTNC-20202\WebApp\Views\Home\Index.cshtml"
                Write(Model[1].isOn);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" == \"on\") {\r\n                        $(`.switch[data-room=\'${2}\']`).bootstrapToggle(\'on\', true)\r\n                }\r\n                if (\"");
#nullable restore
#line 67 "D:\tai lieu\Nam 4\20202\Lap trinh nang cao\LTNC-20202\WebApp\Views\Home\Index.cshtml"
                Write(Model[2].isOn);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" == \"on\") {\r\n                        $(`.switch[data-room=\'${3}\']`).bootstrapToggle(\'on\', true)\r\n                }\r\n                if (\"");
#nullable restore
#line 70 "D:\tai lieu\Nam 4\20202\Lap trinh nang cao\LTNC-20202\WebApp\Views\Home\Index.cshtml"
                Write(Model[3].isOn);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""" == ""on"") {
                        $(`.switch[data-room='${4}']`).bootstrapToggle('on', true)
                }
            })

            $switch = $("".switch"")

            $switch.on('change', async (e) => {
                var target = e.target
                var roomNo = $(target).data('room')

                var switchElement = $(`.switch[data-room='${roomNo}']`)
                var bulbElement = $(`span[data-room='${roomNo}']`)

                var switchValue = $(target).prop('checked')

                var command = switchValue == true ? 'on' : 'off'
                var message = roomNo + (command == 'on' ? '1' : (command == 'off' ? '0' : ''))
                var time = new Date().toLocaleString()
                $.ajax({

                    url: `/Home/PublishMessage?message=${message}`,
                    method: 'Post',

                    success: (result) => {
                        if (switchValue)
                            $(bulbElement).removeClass(""off"").");
                WriteLiteral(@"addClass(""on"")
                        else
                            $(bulbElement).removeClass(""on"").addClass(""off"")

                        toastr.success('Command completed successfully!')
                    },
                    error: (error) => {
                        $(switchElement).bootstrapToggle('off', true)
                        $(bulbElement).removeClass(""on"").addClass(""off"")

                        toastr.error('Could not complete command. Please try again!')
                    }
                })
                $.ajax({
                    url: `/Home/UpdateLed`,
                    type: ""POST"",
                    cache: false,
                    data: { id: roomNo, state: command },
                })

                $.ajax({
                    url: `/Home/CreateHistory`,         ");
                WriteLiteral(@"
                    type: ""POST"",
                    cache: false,
                    data: { _time: time, _start: ""Web"", _end: roomNo, _turn: command },
                })

            })

            $btnControl = $("".btn-control"")
            $btnControl.on('click', async function () {
                var textValue = $btnControl.val()
                var message = (textValue == ""Turn on all"" ? ""01"" : (textValue == ""Turn off all"" ? ""00"" : """"))
                var command = textValue == ""Turn on all"" ? 'on' : 'off'
                var time = new Date().toLocaleString()
                $.ajax({

                    url: `/Home/PublishMessage?message=${message}`,
                    method: 'Post',
                    success: (result) => {
                        if (message == ""01"") {
                            for (let i = 1; i <= 4; i++) {
                                $(`.switch[data-room='${i}']`).bootstrapToggle('on', true)
                                $(`span[data-room='$");
                WriteLiteral(@"{i}']`).removeClass(""off"").addClass(""on"")

                            }
                            $btnControl.val(""Turn off all"")

                        }
                        else {
                            for (let i = 1; i <= 4; i++) {
                                $(`.switch[data-room='${i}']`).bootstrapToggle('off', true)
                                $(`span[data-room='${i}']`).removeClass(""on"").addClass(""off"")
                            }
                            $btnControl.val(""Turn on all"")
                        }
                        toastr.success('Command completed successfully!')

                    },
                    error: (error) => {
                        alert(error)
                        toastr.error('Could not complete command. Please try again!')
                    }
                })
                for (var i = 1; i <=4; i++) {
                    $.ajax({
                        url: `/Home/UpdateLed`,
                        ");
                WriteLiteral("type: \"POST\",\r\n                        cache: false,\r\n                        data: { id: i, state: command },\r\n                    })\r\n                    $.ajax({\r\n                        url: `/Home/CreateHistory`,         ");
                WriteLiteral(@"
                        type: ""POST"",
                        cache: false,
                        data: { _time: time, _start: ""Web"", _end: i, _turn: command },
                    })
                }
            })

            setInterval(function () {
                $.ajax({
                    url: `/Home/ReceiveMessage`,
                    method: 'Get',
                    success: (result) => {
                        var roomNo = result[0]
                        var command = (result[1] == '1' ? 'on' : (result[1] == '0' ? 'off' : ''))
                        var switchElement = $(`.switch[data-room='${roomNo}']`)
                        var bulbElement = $(`span[data-room='${roomNo}']`)
                        switch (roomNo) {
                            case '0':
                                if (command == 'on') {
                                    for (let i = 1; i <= 4; i++) {
                                        $(`.switch[data-room='${i}']`).bootstrapToggle('on");
                WriteLiteral(@"', true)
                                        $(`span[data-room='${i}']`).removeClass(""off"").addClass(""on"")
                                    }
                                    $btnControl.val(""Turn off all"")
                                    /*toastr.success('Just received the remote command successfully!')*/
                                }
                                else if (command == 'off') {
                                    for (let i = 1; i <= 4; i++) {
                                        $(`.switch[data-room='${i}']`).bootstrapToggle('off', true)
                                        $(`span[data-room='${i}']`).removeClass(""on"").addClass(""off"")
                                    }
                                    $btnControl.val(""Turn on all"")
                                    /*toastr.success('Just received the remote command successfully!')*/
                                }
                                break;
                            case '1':
 ");
                WriteLiteral(@"                           case '2':
                            case '3':
                            case '4':
                                if (command == 'on') {
                                    $(switchElement).bootstrapToggle('on', true)
                                    $(bulbElement).removeClass(""off"").addClass(""on"")
                                    /*toastr.success('Just received the remote command successfully!')*/
                                }
                                else if (command == 'off') {
                                    $(switchElement).bootstrapToggle('off', true)
                                    $(bulbElement).removeClass(""on"").addClass(""off"")
                                    /*toastr.success('Just received the remote command successfully!')*/
                                }
                                break;
                            default:
                                /*console.log(""OK DEFAULT"")*/
                              ");
                WriteLiteral(@"  break;
                        }
                        $.ajax({
                            url: `/Home/setMessageDefault`,
                            method: 'Put',
                            success: (result) => { },
                            error: (error) => {
                                alert(error)
                            }
                        })
                    },
                    error: (error) => {
                        alert(error);
                    }
                })
            }, 200)

            setInterval(function () {
                var date = new Date().toLocaleString()
                $(""#time"").html(date)
            }, 1000)

        })
        </script>
    ");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<LedModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
