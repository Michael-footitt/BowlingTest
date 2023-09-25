<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Bowling.aspx.cs" Inherits="_Bowling" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <div class="jumbotron">
        <h1>Score Board</h1>
       <table runat="server" id="tblScore">
           <tr style="border-style: dashed; border-width: thin">
               <td>
                   <asp:Label runat="server" ID="lblName"></asp:Label>
               </td>
               <td>
                 1 - <asp:Label runat="server" ID="lblrd1"></asp:Label>-
               </td>
               <td>
                 2 -  <asp:Label runat="server" ID="lblrd2"></asp:Label>-
               </td>
               <td>
                 3 -  <asp:Label runat="server" ID="lblrd3"></asp:Label>-
               </td>
               <td>
               4  -   <asp:Label runat="server" ID="lblrd4"></asp:Label>-
               </td>
               <td>
                5   - <asp:Label runat="server" ID="lblrd5"></asp:Label>-
               </td>
               <td>
              6  -    <asp:Label runat="server" ID="lblrd6"></asp:Label>-
               </td>
               <td>
               7    - <asp:Label runat="server" ID="lblrd7"></asp:Label>-
               </td>
               <td>
               8     -<asp:Label runat="server" ID="lblrd8"></asp:Label>-
               </td>
               <td>
               9     -<asp:Label runat="server" ID="lblrd9"></asp:Label>-
               </td>
               <td>
                 10  - <asp:Label runat="server" ID="lblrd10"></asp:Label>-
               </td>
               <td>
                 Total Score  - <asp:Label runat="server" ID="lblrdTotal"></asp:Label>-
               </td>
           </tr>

       </table>
    </div>
<asp:Panel runat="server" ID="pnlGame">
    <div class="row">
        <table runat="server" id="tblPlayer">
            <tr>
            <th>
                Please enter bowlers score for this player for frame <asp:Label runat="server" ID="lblFrame"></asp:Label>
            </th>
            </tr>
            <tr>
                <td>
                    Score
                </td>
                <td> <asp:TextBox runat="server" ID="txtScore" TextMode="Number"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="rfvScore" Text="*" ForeColor="Red" Font-Size="14" ErrorMessage="Score is required" ControlToValidate="txtScore">
                    </asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
        <asp:Button runat="server" ID="btnRoll" Text="Roll" OnClick="btnRoll_Click" /> <br />
        <asp:Label runat="server" ID="lblForRound"  Text=""></asp:Label>
        <br />
        <asp:HiddenField runat="server" ID="hfvframe" Value ="1" />
    </div>
    </asp:Panel>
    <asp:Panel runat="server" ID="pnlThankYou" Visible="false">
        <div class="row">
            <asp:Label runat="server" ID="lblThankYou" Text="Thank you for playing"></asp:Label>
            </div>

    </asp:Panel>
</asp:Content>
