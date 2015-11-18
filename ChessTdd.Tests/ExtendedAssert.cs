using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessTdd.Tests
{
    public static class ExtendedAssert
    {
        public static void Throws<TException>(Action executable) where TException : Exception
        {
            try
            {
                executable();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.GetType() == typeof(TException), $"Expected exception of type {typeof (TException)} but got {ex.GetType()}");
                return;
            }

            Assert.Fail($"Expected exception of type {typeof(TException)}, but no exception was thrown");
        }
    }
}