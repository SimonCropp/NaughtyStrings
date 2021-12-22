//using System.Text;
//using System.Threading.Tasks;
//using System.Unicode;
//using VerifyXunit;
//using Xunit;

//[UsesVerify]
//public class UnicodeTesting
//{
//    [Fact]
//    public Task Run()
//    {
//        Assert.Equal('—',(char)0x2014);
//        StringBuilder builder = new();
//        for (var codePoint = 0; codePoint < 1114111; codePoint++)
//        {
//            var info = UnicodeInfo.GetCharInfo(codePoint);
//            var name = info.Name ?? info.OldName;
//            if (name != null && name.ToLowerInvariant().Contains("hyphen"))
//            {
//                builder.AppendLine(info.GetDisplayText());
//                builder.AppendLine(codePoint.ToString("X4"));

//                builder.AppendLine(name);
//            }
//        }

//        return Verify(builder);
//    }
//}