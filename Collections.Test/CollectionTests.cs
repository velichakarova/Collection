using NUnit.Framework;

namespace Collections.Test
{
    public class CollectionTests
    {
     

        [Test]
        public void Test_EmpetyConstructor()
        {
            //Arange
            var nums = new Collection<int>();
            //Act

            //Assert
            Assert.AreEqual(0,nums.Count);
            Assert.AreEqual(16, nums.Capacity);
            Assert.AreEqual(nums.ToString(), Is.EqualTo("[]");
            
        }
        [Test]
         public void Test_Collection_ConstructorSingleItem() 
       
        {
            //Arange
            var nums = new Collection<int>(5);
            //Act

            //Assert
            Assert.That(nums.ToString(), Is.EqualTo("[5]"));

        }
    }
}