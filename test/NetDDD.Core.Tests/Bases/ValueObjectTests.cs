using NetDDD.Core.Bases;
using System;
using Xunit;

namespace NetDDD.Core.Tests.Bases
{
    public class ValueObjectTests
    {
        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void Is_Equal()
        {
            const string street = "101 Clerk Street";
            const string city = "Chicago";
            const string state = "IL";
            const string zipcode = "60007";

            var address1 = new Address(street, city, state, zipcode);
            var address2 = new Address(street, city, state, zipcode);

            Assert.Equal(address1, address2);
            Assert.True(address1 == address2);
            Assert.False(address1 != address2);
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void Is_Not_Equal()
        {
            const string street = "101 Clerk Street";
            const string city = "Chicago";
            const string state = "IL";
            const string zipcode1 = "60007";
            const string zipcode2 = "60603";

            var address1 = new Address(street, city, state, zipcode1);
            var address2 = new Address(street, city, state, zipcode2);

            Assert.NotEqual(address1, address2);
            Assert.False(address1 == address2);
            Assert.True(address1 != address2);
        }

        /// <summary>
        /// 
        /// </summary>
        private class Address : ValueObject<Address>
        {
            public String Street { get; private set; }
            public String City { get; private set; }
            public String State { get; private set; }
            public String ZipCode { get; private set; }

            public Address(string street, string city, string state, string zipcode)
            {
                Street = street;
                City = city;
                State = state;
                ZipCode = zipcode;
            }
        }

    }
}
