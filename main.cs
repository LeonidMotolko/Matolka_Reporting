using Xunit;
using Allure.Xunit.Attributes;

namespace TestProject
{
    public class SampleTests
    {
        [AllureXunit]
        [AllureTag("positive")]
        [AllureOwner("LeonidMotolko")]
        [AllureSuite("Sample Suite")]
        [Fact(DisplayName = "Test that should pass")]
        public void PassingTest()
        {
            Assert.True(2 + 2 == 4);
        }

        [AllureXunit]
        [AllureTag("negative")]
        [AllureOwner("LeonidMotolko")]
        [AllureSuite("Sample Suite")]
        [Fact(DisplayName = "Test that should fail")]
        public void FailingTest()
        {
            Assert.Equal(1, 2);
        }

        [AllureXunit]
        [AllureTag("skip")]
        [AllureOwner("LeonidMotolko")]
        [AllureSuite("Sample Suite")]
        [Fact(DisplayName = "Test that should be skipped", Skip = "Test skipped intentionally")]
        public void SkippedTest()
        {
            // Kод не выполнится из-за Skip
        }
    }
}
