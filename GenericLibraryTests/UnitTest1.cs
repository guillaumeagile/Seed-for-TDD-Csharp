using System;
using Xunit;
using UnderTestLibrary;

namespace GenericLibraryTests
{
    public class UnitTest1
    {
        [Fact]
        public void ItShouldCreateAnEmptyObject()
        {
                var sut = new MyClass();
                Assert.NotNull(sut);
        }
    }
}
 