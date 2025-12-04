var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

string CreatePage(string title)
{
    var html = @"
<!DOCTYPE html>
<html lang=""en"">
<head>
<meta charset=""utf-8"" />
<title>{TITLE}</title>
<style>
html, body {
    height: 100%;
    margin: 0;
}
body {
    display: flex;
    align-items: center;
    justify-content: center;
    font-family: ""Segoe UI Light"", ""Segoe UI"", sans-serif;
}
.container {
    text-align: center;
}
.title {
    font-size: 42px;
    margin-bottom: 24px;
}
.datetime {
    font-size: 20px;
    line-height: 1.6;
}
</style>
</head>
<body>
<div class=""container"">
    <div class=""title"">{TITLE}</div>
    <div class=""datetime"">
        <div id=""date""></div>
        <div id=""time""></div>
        <div id=""tz""></div>
    </div>
</div>
<script>
function updateTime() {
  var now = new Date();
  var dateStr = now.toLocaleDateString(undefined, { year: 'numeric', month: '2-digit', day: '2-digit' });
  var timeStr = now.toLocaleTimeString(undefined, { hour12: false });
  var tz = Intl.DateTimeFormat().resolvedOptions().timeZone;
  var locale = navigator.language || '';
  var country = '';
  if (locale.indexOf('-') !== -1) {
    country = locale.split('-')[1];
  }
  var tzLine = tz;
  if (country) {
    tzLine = tz + ' (' + country + ')';
  }
  document.getElementById('date').textContent = dateStr;
  document.getElementById('time').textContent = timeStr;
  document.getElementById('tz').textContent = tzLine;
}
updateTime();
setInterval(updateTime, 1000);
</script>
</body>
</html>";
    return html.Replace("{TITLE}", title);
}

app.MapGet("/", () => Results.Content(CreatePage("Hello DevOps"), "text/html"));
app.MapGet("/info", () => Results.Content(CreatePage("Hello DevOps info endpoint"), "text/html"));

app.Run("http://0.0.0.0:8080");