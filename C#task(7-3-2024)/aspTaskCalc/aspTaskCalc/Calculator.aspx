<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="aspTaskCalc.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <style>
        .calculator {
  border: 1px solid #ccc;
  border-radius: 5px;
  width: 400px;
}

.calculator-screen {
  width: 100%;
  height: 80px;
  border: none;
  background-color: #252525;
  color: #fff;
  text-align: right;
  padding-right: 20px;
  padding-left: 10px;
  font-size: 4rem;
}

button {
  height: 60px;
  font-size: 2rem!important;
}

.equal-sign {
  height: 98%;
  grid-area: 2 / 4 / 6 / 5;
}

.calculator-keys {
  display: grid;
  grid-template-columns: repeat(4, 1fr);
  grid-gap: 20px;
  padding: 20px;
}
    </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="calculator card">
            <asp:TextBox ID="CalculatorScreen" runat="server" CssClass="calculator-screen z-depth-1" ReadOnly="True"></asp:TextBox>
            <div class="calculator-keys">
                <asp:Button ID="ButtonPlus" runat="server" Text="+" CssClass="operator btn btn-info" OnClick="ButtonPlus_Click"  />
                <asp:Button ID="ButtonMinus" runat="server" Text="-" CssClass="operator btn btn-info" OnClick="ButtonMinus_Click" />
                <asp:Button ID="ButtonMultiply" runat="server" Text="×" CssClass="operator btn btn-info" OnClick="ButtonMultiply_Click"  />
                <asp:Button ID="ButtonDivide" runat="server" Text="÷" CssClass="operator btn btn-info" OnClick="ButtonDivide_Click"  />

                <asp:Button ID="Button7" runat="server" Text="7" CssClass="btn btn-light waves-effect" OnClick="Button7_Click"  />
                <asp:Button ID="Button8" runat="server" Text="8" CssClass="btn btn-light waves-effect" OnClick="Button8_Click"  />
                <asp:Button ID="Button9" runat="server" Text="9" CssClass="btn btn-light waves-effect" OnClick="Button9_Click"  />

                <asp:Button ID="Button4" runat="server" Text="4" CssClass="btn btn-light waves-effect" OnClick="Button4_Click"  />
                <asp:Button ID="Button5" runat="server" Text="5" CssClass="btn btn-light waves-effect" OnClick="Button5_Click"  />
                <asp:Button ID="Button6" runat="server" Text="6" CssClass="btn btn-light waves-effect" OnClick="Button6_Click"  />

                <asp:Button ID="Button1" runat="server" Text="1" CssClass="btn btn-light waves-effect" OnClick="Button1_Click"  />
                <asp:Button ID="Button2" runat="server" Text="2" CssClass="btn btn-light waves-effect" OnClick="Button2_Click"  />
                <asp:Button ID="Button3" runat="server" Text="3" CssClass="btn btn-light waves-effect" OnClick="Button3_Click"  />

                <asp:Button ID="Button0" runat="server" Text="0" CssClass="btn btn-light waves-effect" OnClick="Button0_Click"  />
                <asp:Button ID="ButtonDecimal" runat="server" Text="." CssClass="decimal function btn btn-secondary" OnClick="ButtonDecimal_Click" />
                <asp:Button ID="ButtonClear" runat="server" Text="AC" CssClass="all-clear function btn btn-danger btn-sm" OnClick="ButtonClear_Click" />
                <asp:Button ID="ButtonEquals" runat="server" Text="=" CssClass="equal-sign operator btn btn-default" OnClick="ButtonEquals_Click" />
            </div>
        </div>
    </form>
</body>
</html>
