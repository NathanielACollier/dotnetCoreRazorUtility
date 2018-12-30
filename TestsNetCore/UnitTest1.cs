using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace TestsNetCore
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            // for now try to fake what we are trying to get working to just see if it works
            System.IO.Directory.CreateDirectory("Views");
            System.IO.File.WriteAllText(@"myView2.cshtml", @"
                The number is @Model
            ");
            var result = await dotnetStandardRazorUtility.Utility.RenderView("myView2.cshtml", 7);

            Assert.IsTrue(result.IndexOf('7') >= 0, "Didn't render correctly");
        }
    }
}
