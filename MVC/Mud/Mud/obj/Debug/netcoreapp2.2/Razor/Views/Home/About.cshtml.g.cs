#pragma checksum "C:\Users\Ryan Newman\Desktop\MUD Maker\Mud-Project\MVC\Mud\Mud\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eac7ec85e1f3fd6c01c3733680e1ca77ce760335"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Users\Ryan Newman\Desktop\MUD Maker\Mud-Project\MVC\Mud\Mud\Views\_ViewImports.cshtml"
using Mud;

#line default
#line hidden
#line 2 "C:\Users\Ryan Newman\Desktop\MUD Maker\Mud-Project\MVC\Mud\Mud\Views\_ViewImports.cshtml"
using Mud.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eac7ec85e1f3fd6c01c3733680e1ca77ce760335", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"239814404402e950731866048769ed8bd55d8101", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Ryan Newman\Desktop\MUD Maker\Mud-Project\MVC\Mud\Mud\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(41, 38, true);
            WriteLiteral("﻿\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(79, 1139, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eac7ec85e1f3fd6c01c3733680e1ca77ce7603353640", async() => {
                BeginContext(85, 1126, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"" />
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" />
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js""></script>
    <title>MUD Maker</title>

    <style>
        body {
            background-image: url(""https://cdn.pixabay.com/photo/2018/07/09/00/38/not-dead-3525140_960_720.jpg"");
            background-repeat: no-repeat;
            background-attachment: fixed;
            background-size: cover;
        }

        h1, h2, h3, h4, h5, h6, p, article {
            color: white;
            text-shadow: 1px 1px 3px blue;
            font-family:");
                WriteLiteral(" Georgia, \'Times New Roman\', Times, serif;\r\n            text-align: center;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1218, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1220, 5463, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eac7ec85e1f3fd6c01c3733680e1ca77ce7603356016", async() => {
                BeginContext(1226, 5450, true);
                WriteLiteral(@"

    <h1 styel="""">Multi-User Dungeon Maker</h1>
    <br />
    <nav>

    </nav>
    <article>

        <p>
            <h2><b>Create your own dungeon game with MUD Maker</b></h2> <br />
            <div class=""accordion"" id=""GeneralInfo"">
                <div class=""card bg-dark"" style=""opacity: 0.75"">

                    <div class=""accordion"" id=""accordionExample"">
                        <div class=""card bg-dark"">
                            <div class=""card-header"" id=""headingOne"">
                                <h2 class=""mb-0"">
                                    <button class=""btn btn-link"" type=""button"" data-toggle=""collapse"" data-target=""#collapseOne"" aria-expanded=""false"" aria-controls=""collapseOne"">
                                        <h2> 1.0 General Information</h2>
                                    </button>
                                </h2>
                            </div>

                            <div id=""collapseOne"" class=""collapse show"" aria-label");
                WriteLiteral(@"ledby=""headingOne"" data-parent=""#accordionExample"">
                                <div class=""card-body"">
                                    <h3>1.1 Purpose</h3>

                                    <h3>1.2 MUD Maker Overview</h3>
                                    Philisophical view:

                                    Take control of MUD maker and create a classic text-based game that could indulge your audience into a compelling story or create a unique dungeon game that is near impossible or impossible to beat! The choice of what type of dungeons you create is yours to make with our product!

                                    <h3>1.2.1 What is Multi-User Dungeon maker?</h3>
                                    * Text-based dungeon game creator that allows the user to create a dungeon adventure. <br>
                                    * The user will have a choice to make mission elements, enemies, dungeon levels, characters, and dungeons in the form of story text. <br>
                 ");
                WriteLiteral(@"                   <br>
                                    <h3>1.2.2 Why create this game?</h3>
                                    * This game is created to give the opportunity to anyone who want to make their own compelling story. <br>
                                    * Keeping the user engaged is the goal to unleash creativity. <br>
                                    * Motivate user to send feedback to upgrade the game. <br>
                                    <h3>1.2.3 When does this game take place?</h3>
                                    * Whenever the user decides.
                                    <h3>1.2.4 Where does the environment of the game exist?</h3>
                                    * This game creator will take place in a dungeon at the least, all the other elements are up to the user to create. <br>
                                    <h3>1.2.5 Who will the user/customer play as?</h3>
                                    * The user will decide the player quantity and qual");
                WriteLiteral(@"ity.
                                    <h3>1.2.6 What is the Main Objective</h3>
                                    * The user will decide the main objectives in the game.
                                    <h3>1.2.7 How is this game different from others?</h3>
                                    * The user will be able to use their creativity in developing a story comepelling enough to capture the attention of players and keep that attention.
                                </div>
                            </div>
                        </div>
                        <div class=""card bg-dark"">
                            <div class=""card-header"" id=""headingTwo"">
                                <h2 class=""mb-0"">
                                    <button class=""btn btn-link collapsed"" type=""button"" data-toggle=""collapse"" data-target=""#collapseTwo"" aria-expanded=""false"" aria-controls=""collapseTwo"">
                                        <h2>2.0 Features</h2>
                               ");
                WriteLiteral(@"     </button>
                                </h2>
                            </div>
                            <div id=""collapseTwo"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionExample"">
                                <div class=""card-body"">
                                    <h3>2.1 General</h3>
                                    * The user will have access to several assets to use in creation of the game. <br />
                                    * The user will have the option to make an endless game with story recursion or have a compelling ending. <br />
                                    * The user will have an option of making a multiplayer (pvp) version or a story (pve) version of their dungeon. <br />
                                    <h3>2.2 Multiplayer</h3>
                                    *(Currently unavailable)
                                    <h3>2.3 Gameplay</h3>
                                    * Text based menu selections are availabl");
                WriteLiteral(@"e for implementation. <br />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </p>
    </article>
    <footer>
        <h3><a> &COPY; MSSA Cohort 7 Team 3 2019  </a></h3>
    </footer>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6683, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
