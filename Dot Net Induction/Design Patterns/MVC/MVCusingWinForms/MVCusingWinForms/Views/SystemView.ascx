<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SystemView.ascx.cs" Inherits="MVCusingWinForms.Views.SystemView" %>
<div style="height: 30px; background-color: rgb(0, 148, 255); color: white; margin-bottom: 10px;">
    <asp:label style="display: block;" 
      text="System Configuration" runat="server" id="label1" />
</div>
<span style="float: left; font-weight: bold; color: rgb(0, 148, 255);">Current Status:&nbsp;</span>
<span>Ram:</span><asp:label runat="server" id="lblRam" /><span>GB</span>
<span>Disk:</span><asp:label runat="server" id="lblDisk" /><span>GB</span>
<span>CPU Speed:</span><asp:label runat="server" id="lblcpuspeed" /><span>GHz</span>
<table style="padding: 10px 0px; float: left; width: 365px;">
    <tbody><tr>
        <td style="font-weight: bold;">RAM:</td>
        <td><asp:textbox runat="server" id="txtRam" /></td>
        <td>GB</td>
    </tr>
    <tr>
        <td style="font-weight: bold;">Disk Space:</td>
        <td><asp:textbox runat="server" id="txtDisk" /></td>
        <td>GB</td>
    </tr>
    <tr>
        <td style="font-weight: bold;">Processor:</td>
        <td><asp:textbox runat="server" id="txtProcessor" /></td>
        <td>GHz</td>
    </tr>
    <tr>
        <td>
            <asp:button onclick="btnUpdate_Click" 
              text="Update" runat="server" id="btnUpdate">
        </asp:button></td>
        <td></td>
        <td></td>
    </tr>
</tbody>
</table>