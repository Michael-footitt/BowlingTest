<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div >
        <h1>Lets Bowl!</h1>
        <p class="lead">On this page add all players</p>
    </div>

    <div class="row">
        <table runat="server" id="tblPlayer">
            <tr>
            <th>
                Please enter Bowler information
            </th>
            </tr>
            <tr>
                <td>
                    Name
                </td>
                <td> <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="rfvName" Text="*" ForeColor="Red" Font-Size="14" ErrorMessage="Name is required" ControlToValidate="txtName">
                    </asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
        <asp:Button runat="server" ID="btnAddPlayer" Text="Add Player" OnClick="btnAddPlayer_Click" /> <br />
        <asp:Label runat="server" ID="lblPlayerAdded" ForeColor="Green" Text=""></asp:Label>
        <br />
        <asp:Button runat="server" ID="btnPlay" Text="Start Bowling!" OnClick="btnPlay_Click" Visible="false" />
        
    </div>
</asp:Content>
