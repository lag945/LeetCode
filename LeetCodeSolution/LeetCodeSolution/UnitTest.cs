using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolution
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void L0001Solution1TestMethod()
        {
            int[] nums = new int[] { 3, 2, 4 };
            int target = 6;
            int[] ret = L0001.Solution1(nums, target);
            Assert.IsTrue(ret[0] == 1 && ret[1] == 2, "L0001Solution1TestMethod failed");
        }

        [TestMethod]
        public void L0001Solution2TestMethod()
        {
            int[] nums = new int[] { 3, 2, 4 };
            int target = 6;
            int[] ret = L0001.Solution3(nums, target);
            Assert.IsTrue(ret[0] == 1 && ret[1] == 2, "L0001Solution2TestMethod failed");
        }

        [TestMethod]
        public void L0001Solution3TestMethod()
        {
            int[] nums = new int[] { 3, 2, 4 };
            int target = 6;
            int[] ret = L0001.Solution3(nums, target);
            Assert.IsTrue(ret[0] == 1 && ret[1] == 2, "L0001Solution3TestMethod failed");
        }


    }
}
