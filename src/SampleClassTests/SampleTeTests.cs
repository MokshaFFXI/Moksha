using Moksha.Sample;
using Xunit;

namespace SampleClassTests
{
    public class SampleTeTests
    {
        [Fact]
        public void GivenAnything_WhenConstructing_NoErrorsThrown()
        {
            var ex = Record.Exception(() => new SampleClass());

            Assert.Null(ex);

        }
    }
}
