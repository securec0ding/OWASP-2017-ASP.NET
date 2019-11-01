<%@ Page Language="C#" Debug="true" Trace="false" %>
<%@ Import Namespace="System.Diagnostics" %>
<%@ Import Namespace="System.IO" %>
<script Language="c#" runat="server">
    void Page_Load(object sender, EventArgs e){
    }
    String SafeString(string address)
    {
        char[] separators = new char[]{' ',';',',','\r','\t','\n','&'};

        string[] temp = address.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        address = String.Join("\n", temp);
        return address;
    }
    Boolean Blacklist(string address)
    {
        address = SafeString(address); 
        string[] black_array = { "192.168.1.1", "127.0.0.1" };
        if (black_array.Contains(address))
        {
            return false;
        }
        else
        {

            return true;
        }
    }
    string ExcuteCmd(string arg){
        if (Blacklist(arg)) {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.Arguments = "/c ping -n 2 " + arg;
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            Process p = Process.Start(psi);
            StreamReader stmrdr = p.StandardOutput;
            string s = stmrdr.ReadToEnd();
            stmrdr.Close();
            return s;
        }
        else
        {
            return "Access Denied";
        }

    }
    void cmdExe_Click(object sender, System.EventArgs e){
        Response.Write(Server.HtmlEncode(ExcuteCmd(SafeString(addr.Text))));
    }
</script>

<HTML>
<HEAD>
<title>ASP.NET Ping Application</title>
</HEAD>
<body>
<form id="cmd" method="post" runat="server">
<asp:Label id="lblText" runat="server">Command:</asp:Label>
<asp:TextBox id="addr" runat="server" Width="250px">
</asp:TextBox>
<asp:Button id="testing" runat="server" Text="excute" OnClick="cmdExe_Click">
</asp:Button>
</form>
</body>
</HTML>