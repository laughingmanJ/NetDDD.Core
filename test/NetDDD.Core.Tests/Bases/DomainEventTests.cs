using NetDDD.Core.Bases;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace NetDDD.Core.Tests.Bases
{
    public class DomainEventTests
    {
        [Fact]
        public void Created_Timestamp()
        {
            var timeStamp = DateTime.Now;
            var testEvent = new TestEvent();

            Assert.Equal(timeStamp, testEvent.Created, new TimeSpan(0, 0, 0, 1));
        }

        /// <summary>
        /// 
        /// </summary>
        private class TestEvent : DomainEvent
        {
        }
    }
}
