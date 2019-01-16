#pragma checksum "F:\asp.net\webwapi(core)\SyZero.BlogAPI\SZCMS\Views\Admin\ArticleCategoryList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6695bfdf42db28f99c6ba3ff035b1d4be454af0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ArticleCategoryList), @"mvc.1.0.view", @"/Views/Admin/ArticleCategoryList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/ArticleCategoryList.cshtml", typeof(AspNetCore.Views_Admin_ArticleCategoryList))]
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
#line 1 "F:\asp.net\webwapi(core)\SyZero.BlogAPI\SZCMS\Views\_ViewImports.cshtml"
using SZCMS;

#line default
#line hidden
#line 2 "F:\asp.net\webwapi(core)\SyZero.BlogAPI\SZCMS\Views\_ViewImports.cshtml"
using SZCMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6695bfdf42db28f99c6ba3ff035b1d4be454af0d", @"/Views/Admin/ArticleCategoryList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c08668d7bd6090aa73c93cb6fecbbe549a26fd9", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ArticleCategoryList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<object>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\asp.net\webwapi(core)\SyZero.BlogAPI\SZCMS\Views\Admin\ArticleCategoryList.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_LayUI";

#line default
#line hidden
            DefineSection("Css", async() => {
                BeginContext(91, 83, true);
                WriteLiteral(" \r\n    <link rel=\"stylesheet\" href=\"/lib/layuiadmin/style/admin.css\" media=\"all\">\r\n");
                EndContext();
            }
            );
            BeginContext(177, 767, true);
            WriteLiteral(@"<div class=""layui-fluid"">
    <div class=""layui-card"">
        <div class=""layui-card-header layuiadmin-card-header-auto"">
            <button class=""layui-btn layuiadmin-btn-tags"" data-type=""add"">添加</button>
        </div>
        <div class=""layui-card-body"">    
            <table id=""table-article-category"" lay-filter=""table-article-category""></table>  
            <script type=""text/html"" id=""table-article-categorybar"">
                <a class=""layui-btn layui-btn-normal layui-btn-xs"" lay-event=""edit""><i class=""layui-icon layui-icon-edit""></i>编辑</a>
                <a class=""layui-btn layui-btn-danger layui-btn-xs"" lay-event=""del""><i class=""layui-icon layui-icon-delete""></i>删除</a>
            </script>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(961, 5518, true);
                WriteLiteral(@" 
    
    <script>
        layui.config({
            base: '/lib/layuiadmin/' //静态资源所在路径
        }).extend({
            index: 'lib/index' //主入口模块
        }).use(['index', 'contlist', 'table'], function(){

            var table = layui.table;
           
            table.render({
                elem: '#table-article-category'
                , url: '/api/admin/ajax/getarticlecategory'
                , title: '用户数据表'
                , cols: [[
                    {type:'numbers'}
                    , { field: 'Id', title: 'ID', width: 200 }
                    , { field: 'Name', title: '分类名' }
                    , { field: 'UpdateTime', title: '修改时间', width: 150 }
                    , { fixed: 'right', title: '操作', toolbar: '#table-article-categorybar', width: 150 }
                ]]
              
            });

            var $ = layui.$, active = {
                                 add: function(){
                                     addCategory();
                 ");
                WriteLiteral(@"                }
                             }

            //监听行工具事件
            table.on('tool(table-article-category)', function (obj) {
                var data = obj.data;
                if (obj.event === 'del') {
                    layer.confirm('真的删除行么', function (index) {
                        var id = data.Id;
                        $.ajax({
                            type: ""post"",
                            url: ""/api/admin/ajax/DelArticleCategory"",
                            data: { Id: id},
                            dataType: ""json"",
                            success: function (data) {
                                if (data.msg == ""ok"") {
                                    obj.del();
                                    layer.close(index);
                                }
                            }
                        });
                       
                    });
                } else if (obj.event === 'edit') {
                    addCategory");
                WriteLiteral(@"(data);
                }
            });

            //添加分类  编辑分类
            function addCategory(edit) {
                var index = layui.layer.open({
                    type: 2
                    , title: '添加分类'
                    , content: '/admin/ArticleCategoryEdit'
                    , area: ['100%', '100%']
                    , btn: ['确定', '取消']
                    , yes: function (index, layero) {
                        var othis = layero.find('iframe').contents().find(""#layuiadmin-app-form-tags""),
                            name = othis.find('input[name=""name""]').val(),
                            content = othis.find('#content').val(),
                            id = othis.find('input[name=""id""]').val();
                        if (edit) {
                            $.ajax({
                                type: ""post"",
                                url: ""/api/admin/ajax/UpdateArticleCategory"",
                                data: {Id:id, Name: name, Status: ""发布");
                WriteLiteral(@""", Describe: content },
                                dataType: ""json"",
                                success: function (data) {
                                    if (data.msg == ""ok"") {
                                        table.reload('table-article-category');
                                        layer.close(index);
                                    }
                                }
                            });
                        } else {
                            $.ajax({
                                type: ""post"",
                                url: ""/api/admin/ajax/AddArticleCategory"",
                                data: { Name: name, Status: ""发布"", Describe: content },
                                dataType: ""json"",
                                success: function (data) {
                                    if (data.msg == ""ok"") {
                                        table.reload('table-article-category');
                                        la");
                WriteLiteral(@"yer.close(index);
                                    }
                                }
                            });
                        }
                    },
                    success: function (layero, index) {
                        var body = layui.layer.getChildFrame('body', index);
                        if (edit) {
                            body.find('input[name=""id""]').val(edit.Id);
                            body.find('input[name=""name""]').val(edit.Name);
                            body.find('#content').val(edit.Describe);
                        }
                        setTimeout(function () {
                            layui.layer.tips('点击此处返回文章分类列表', '.layui-layer-setwin .layui-layer-close', {
                                tips: 3
                            });
                        }, 500);
                    }
                });

                layui.layer.full(index);
                //改变窗口大小时，重置弹窗的宽高，防止超出可视区域（如F12调出debug的操作）
               ");
                WriteLiteral(@" $(window).on(""resize"", function () {
                    layui.layer.full(index);
                })
            }

            $('.layui-btn.layuiadmin-btn-tags').on('click', function(){
                var type = $(this).data('type');
                active[type] ? active[type].call(this) : '';
            });
        });
    </script>
    
    <script>
       
    </script>

");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<object> Html { get; private set; }
    }
}
#pragma warning restore 1591