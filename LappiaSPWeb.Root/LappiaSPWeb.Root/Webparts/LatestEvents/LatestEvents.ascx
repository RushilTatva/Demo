<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LatestEvents.ascx.cs" Inherits="LappiaSPWeb.Root.Webparts.LatestEvents.LatestEvents" %>
<h2 class="title">Tapahtumat</h2>
<ul class="sec2-list">
    <li>
        <div class="date"><span>6</span>KESÄ</div>
        <div class="text"><a href="#">Consectetur adipisci elit.</a></div>
    </li>
    <li>
        <div class="date"><span>15</span>HEINÄ</div>
        <div class="text"><a href="#">Sed eiusmod tempor incidunt ut labore.</a></div>
    </li>
    <li>
        <div class="date"><span>20</span>MARRAS</div>
        <div class="text"><a href="#">Sunt in culpa qui officia.</a></div>
    </li>
    <li>
        <div class="date"><span>18</span>JOULU</div>
        <div class="text"><a href="#">Et dolore magna aliqua.</a></div>
    </li>
</ul>
<a href="#">Tapahtumakalenteri</a>