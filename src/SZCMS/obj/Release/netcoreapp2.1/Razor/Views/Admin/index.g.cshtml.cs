#pragma checksum "F:\项目\SYCMS1.0\src\SZCMS\Views\Admin\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2b3519e2ba4e0de83fd930bd47864a138b76393"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_index), @"mvc.1.0.view", @"/Views/Admin/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/index.cshtml", typeof(AspNetCore.Views_Admin_index))]
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
#line 1 "F:\项目\SYCMS1.0\src\SZCMS\Views\_ViewImports.cshtml"
using SZCMS;

#line default
#line hidden
#line 2 "F:\项目\SYCMS1.0\src\SZCMS\Views\_ViewImports.cshtml"
using SZCMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2b3519e2ba4e0de83fd930bd47864a138b76393", @"/Views/Admin/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c08668d7bd6090aa73c93cb6fecbbe549a26fd9", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-layout-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(27, 636, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e9b8773161d4359b32ef13f799e56db", async() => {
                BeginContext(33, 623, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title>layuiAdmin std - 通用后台管理模板系统（iframe标准版）</title>
    <meta name=""renderer"" content=""webkit"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, minimum-scale=1.0, maximum-scale=1.0, user-scalable=0"">
   

        <link rel=""stylesheet"" href=""/lib/layuiadmin/layui/css/layui.css"" media=""all"">
        <link rel=""stylesheet"" href=""/lib/layuiadmin/style/admin.css"" media=""all"">

    <script>
        /^http(s*):\/\//.test(location.href) || alert('请先部署到 localhost 下再访问');
    </script>
");
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
            BeginContext(663, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(665, 11705, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4caf3b22d4d48c68227b2eb48cd6783", async() => {
                BeginContext(697, 11666, true);
                WriteLiteral(@"

    <div id=""LAY_app"">
        <div class=""layui-layout layui-layout-admin"">
            <div class=""layui-header"">
                <!-- 头部区域 -->
                <ul class=""layui-nav layui-layout-left"">
                    <li class=""layui-nav-item layadmin-flexible"" lay-unselect>
                        <a href=""javascript:;"" layadmin-event=""flexible"" title=""侧边伸缩"">
                            <i class=""layui-icon layui-icon-shrink-right"" id=""LAY_app_flexible""></i>
                        </a>
                    </li>
                    <li class=""layui-nav-item layui-hide-xs"" lay-unselect>
                        <a href=""http://www.layui.com/admin/"" target=""_blank"" title=""前台"">
                            <i class=""layui-icon layui-icon-website""></i>
                        </a>
                    </li>
                    <li class=""layui-nav-item"" lay-unselect>
                        <a href=""javascript:;"" layadmin-event=""refresh"" title=""刷新"">
                            <i class=""l");
                WriteLiteral(@"ayui-icon layui-icon-refresh-3""></i>
                        </a>
                    </li>
                    <li class=""layui-nav-item layui-hide-xs"" lay-unselect>
                        <input type=""text"" placeholder=""搜索..."" autocomplete=""off"" class=""layui-input layui-input-search"" layadmin-event=""serach"" lay-action=""template/search.html?keywords="">
                    </li>
                </ul>
                <ul class=""layui-nav layui-layout-right"" lay-filter=""layadmin-layout-right"">

                    <li class=""layui-nav-item"" lay-unselect>
                        <a lay-href=""app/message/index.html"" layadmin-event=""message"" lay-text=""消息中心"">
                            <i class=""layui-icon layui-icon-notice""></i>

                            <!-- 如果有新消息，则显示小圆点 -->
                            <span class=""layui-badge-dot""></span>
                        </a>
                    </li>
                    <li class=""layui-nav-item layui-hide-xs"" lay-unselect>
                      ");
                WriteLiteral(@"  <a href=""javascript:;"" layadmin-event=""theme"">
                            <i class=""layui-icon layui-icon-theme""></i>
                        </a>
                    </li>
                    <li class=""layui-nav-item layui-hide-xs"" lay-unselect>
                        <a href=""javascript:;"" layadmin-event=""note"">
                            <i class=""layui-icon layui-icon-note""></i>
                        </a>
                    </li>
                    <li class=""layui-nav-item layui-hide-xs"" lay-unselect>
                        <a href=""javascript:;"" layadmin-event=""fullscreen"">
                            <i class=""layui-icon layui-icon-screen-full""></i>
                        </a>
                    </li>
                    <li class=""layui-nav-item"" lay-unselect>
                        <a href=""javascript:;"">
                            <cite>贤心</cite>
                        </a>
                        <dl class=""layui-nav-child"">
                            <dd><a lay-");
                WriteLiteral(@"href=""set/user/info.html"">基本资料</a></dd>
                            <dd><a lay-href=""set/user/password.html"">修改密码</a></dd>
                            <hr>
                            <dd layadmin-event=""logout"" style=""text-align: center;""><a>退出</a></dd>
                        </dl>
                    </li>

                    <li class=""layui-nav-item layui-hide-xs"" lay-unselect>
                        <a href=""javascript:;"" layadmin-event=""about""><i class=""layui-icon layui-icon-more-vertical""></i></a>
                    </li>
                    <li class=""layui-nav-item layui-show-xs-inline-block layui-hide-sm"" lay-unselect>
                        <a href=""javascript:;"" layadmin-event=""more""><i class=""layui-icon layui-icon-more-vertical""></i></a>
                    </li>
                </ul>
            </div>

            <!-- 侧边菜单 -->
            <div class=""layui-side layui-side-menu"">
                <div class=""layui-side-scroll"">
                    <div class=""layui-logo"" ");
                WriteLiteral(@"lay-href=""home/console.html"">
                        <span>layuiAdmin</span>
                    </div>

                    <ul class=""layui-nav layui-nav-tree"" lay-shrink=""all"" id=""LAY-system-side-menu"" lay-filter=""layadmin-system-side-menu"">
                        <li data-name=""home"" class=""layui-nav-item layui-nav-itemed"">
                            <a href=""javascript:;"" lay-tips=""主页"" lay-direction=""2"">
                                <i class=""layui-icon layui-icon-home""></i>
                                <cite>主页</cite>
                            </a>
                            <dl class=""layui-nav-child"">
                                <dd data-name=""console"" class=""layui-this"">
                                    <a lay-href=""home/console.html"">控制台</a>
                                </dd>
                                <dd data-name=""console"">
                                    <a lay-href=""home/homepage1.html"">主页一</a>
                                </dd>
               ");
                WriteLiteral(@"                 <dd data-name=""console"">
                                    <a lay-href=""home/homepage2.html"">主页二</a>
                                </dd>
                            </dl>
                        </li>
                        <li data-name=""template"" class=""layui-nav-item"">
                            <a href=""javascript:;"" lay-tips=""文章管理"" lay-direction=""2"">
                                <i class=""layui-icon layui-icon-template""></i>
                                <cite>文章管理</cite>
                            </a>
                            <dl class=""layui-nav-child"">
                                <dd><a lay-href=""Admin/ArticleList"">文章列表</a></dd>
                                <dd><a lay-href=""Admin/ArticleCategoryList"">文章类型列表</a></dd>
                             
                            </dl>
                        </li>
                        <li data-name=""template"" class=""layui-nav-item"">
                            <a href=""javascript:;"" lay-tips=""评论管理""");
                WriteLiteral(@" lay-direction=""2"">
                                <i class=""layui-icon layui-icon-template""></i>
                                <cite>评论管理</cite>
                            </a>
                            <dl class=""layui-nav-child"">
                                <dd><a lay-href=""Admin/ArticleList"">评论列表</a></dd>
                                <dd><a lay-href=""Admin/ArticleCategoryList"">文章类型列表</a></dd>
                             
                            </dl>
                        </li>
               
                        <li data-name=""user"" class=""layui-nav-item"">
                            <a href=""javascript:;"" lay-tips=""用户管理"" lay-direction=""2"">
                                <i class=""layui-icon layui-icon-user""></i>
                                <cite>用户</cite>
                            </a>
                            <dl class=""layui-nav-child"">
                                <dd>
                                    <a lay-href=""user/user/list.html"">网站用户</a>");
                WriteLiteral(@"
                                </dd>
                                <dd>
                                    <a lay-href=""user/administrators/list.html"">后台管理员</a>
                                </dd>
                                <dd>
                                    <a lay-href=""user/administrators/role.html"">角色管理</a>
                                </dd>
                            </dl>
                        </li>
                        <li data-name=""set"" class=""layui-nav-item"">
                            <a href=""javascript:;"" lay-tips=""设置"" lay-direction=""2"">
                                <i class=""layui-icon layui-icon-set""></i>
                                <cite>设置</cite>
                            </a>
                            <dl class=""layui-nav-child"">
                                <dd class=""layui-nav-itemed"">
                                    <a href=""javascript:;"">系统设置</a>
                                    <dl class=""layui-nav-child"">
              ");
                WriteLiteral(@"                          <dd><a lay-href=""set/system/website.html"">网站设置</a></dd>
                                        <dd><a lay-href=""set/system/email.html"">邮件服务</a></dd>
                                    </dl>
                                </dd>
                                <dd class=""layui-nav-itemed"">
                                    <a href=""javascript:;"">我的设置</a>
                                    <dl class=""layui-nav-child"">
                                        <dd><a lay-href=""set/user/info.html"">基本资料</a></dd>
                                        <dd><a lay-href=""set/user/password.html"">修改密码</a></dd>
                                    </dl>
                                </dd>
                            </dl>
                        </li>
                
                    </ul>
                </div>
            </div>

            <!-- 页面标签 -->
            <div class=""layadmin-pagetabs"" id=""LAY_app_tabs"">
                <div class=""layui-icon layadmin-t");
                WriteLiteral(@"abs-control layui-icon-prev"" layadmin-event=""leftPage""></div>
                <div class=""layui-icon layadmin-tabs-control layui-icon-next"" layadmin-event=""rightPage""></div>
                <div class=""layui-icon layadmin-tabs-control layui-icon-down"">
                    <ul class=""layui-nav layadmin-tabs-select"" lay-filter=""layadmin-pagetabs-nav"">
                        <li class=""layui-nav-item"" lay-unselect>
                            <a href=""javascript:;""></a>
                            <dl class=""layui-nav-child layui-anim-fadein"">
                                <dd layadmin-event=""closeThisTabs""><a href=""javascript:;"">关闭当前标签页</a></dd>
                                <dd layadmin-event=""closeOtherTabs""><a href=""javascript:;"">关闭其它标签页</a></dd>
                                <dd layadmin-event=""closeAllTabs""><a href=""javascript:;"">关闭全部标签页</a></dd>
                            </dl>
                        </li>
                    </ul>
                </div>
                <div class=""");
                WriteLiteral(@"layui-tab"" lay-unauto lay-allowClose=""true"" lay-filter=""layadmin-layout-tabs"">
                    <ul class=""layui-tab-title"" id=""LAY_app_tabsheader"">
                        <li lay-id=""home/console.html"" lay-attr=""home/console.html"" class=""layui-this""><i class=""layui-icon layui-icon-home""></i></li>
                    </ul>
                </div>
            </div>


            <!-- 主体内容 -->
            <div class=""layui-body"" id=""LAY_app_body"">
                <div class=""layadmin-tabsbody-item layui-show"">
                    <iframe src=""home/console.html"" frameborder=""0"" class=""layadmin-iframe""></iframe>
                </div>
            </div>

            <!-- 辅助元素，一般用于移动设备下遮罩 -->
            <div class=""layadmin-body-shade"" layadmin-event=""shade""></div>
        </div>
    </div>

 

    <script src=""/lib/jquery/dist/jquery.js""></script>
    <script src=""/lib/layuiadmin/layui/layui.js""></script>

    <script>
  layui.config({
      base: '/lib/layuiadmin/' //静态资源所在路径
  }");
                WriteLiteral(@").extend({
    index: 'lib/index' //主入口模块
  }).use('index');
    </script>

    <!-- 百度统计 -->
    <script>
  var _hmt = _hmt || [];
  (function() {
    var hm = document.createElement(""script"");
    hm.src = ""https://hm.baidu.com/hm.js?d214947968792b839fd669a4decaaffc"";
    var s = document.getElementsByTagName(""script"")[0];
    s.parentNode.insertBefore(hm, s);
  })();
    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(12370, 17, true);
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n");
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