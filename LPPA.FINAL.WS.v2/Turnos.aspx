<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Turnos.aspx.cs" Inherits="LPPA.FINAL.WS.v1.Turnos" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TURNOS</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1> Selección de turnos </h1>
        <p>Seleccione un médico: </p>
        <%--<asp:DropDownList runat="server" ID="Cmboxmed" OnSelectedIndexChanged="Cmboxmed_SelectedIndexChanged"></asp:DropDownList>--%>
        <p>Seleccione una fecha disponible: </p>
      <asp:Calendar runat="server" ID="Cale" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" OnSelectionChanged="Cale_SelectionChanged" Width="200px" >
          <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
          <NextPrevStyle VerticalAlign="Bottom" />
          <OtherMonthDayStyle ForeColor="#808080" />
          <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
          <SelectorStyle BackColor="#CCCCCC" />
          <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
          <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
          <WeekendDayStyle BackColor="#FFFFCC" />
        </asp:Calendar>
        <p>Seleccione un horario disponible: </p>
      <asp:DropDownList runat="server" ID="Cmboxhs"></asp:DropDownList>
        <p></p>
        <asp:Button runat="server" Text="Reservar" />

        <div>
        </div>
    </form>
</body>
</html>
