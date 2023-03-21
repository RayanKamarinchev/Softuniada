using System.Text;

int n = int.Parse(Console.ReadLine());
StringBuilder sb = new StringBuilder();
sb.AppendLine(new string('_', n/2+2) + '^' + new string('_', n/2+2));
sb.AppendLine(new string('_', n/2+1) + '/' + '|' + '\\' + new string('_', n/2 + 1));
for (int i = n/2; i >= 0; i--)
{
    sb.AppendLine(new string('_', i) + '/' + new string('.', n/2-i) + "|||" + new string('.', n / 2 - i) + '\\' + new string('_', i));
}
sb.AppendLine("_"+ '/' + new string('.', n/2-1) + "|||" + new string('.', n/2-1) + '\\' + '_');
for (int i = 0; i < n; i++)
{
    sb.AppendLine(new string('_', n/2+1) + "|||" + new string('_', n/2+1));
}
sb.AppendLine(new string('_', n/2+1) + "~~~" + new string('_', n/2+1));
for (int i = n/2; i >= 1; i--)
{
    sb.AppendLine(new string('_', i) + "//" + new string('.', n/2-i) + '!' + new string('.', n / 2 - i) + "\\\\" + new string('_', i));
}

Console.WriteLine(sb.ToString());

//20min