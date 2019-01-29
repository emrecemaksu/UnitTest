using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;
namespace TestNinja.UnitTests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void Push_Null_Exception()
        {
            var stack = new Stack<string>();
            Assert.ThrowsException<ArgumentNullException>(() => stack.Push(null));
        }
        [TestMethod]
        public void Push_Add_Object()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            Assert.AreEqual(stack.Count, 1);
        }
        [TestMethod]
        public void Pop_Zero_Exception()
        {
            var stack = new Stack<string>();
            Assert.ThrowsException<InvalidOperationException>(() => stack.Pop());
        }
        [TestMethod]
        public void Pop_EmptyStack_Object_Zero()
        {
            var stack = new Stack<string>();
            Assert.AreEqual(stack.Count, 0);
        }
        [TestMethod]
        public void Pop_Remove_Object()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            var result = stack.Pop();
            Assert.AreEqual(result, "b");
        }
        [TestMethod]
        public void Peek_Zero_Exception()
        {
            var stack = new Stack<string>();
            Assert.ThrowsException<InvalidOperationException>(() => stack.Peek());
        }
        [TestMethod]
        public void Peek_ReturnObjectOnTop()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            var result = stack.Peek();
            Assert.AreEqual(result, "b");
        }
    }
}
