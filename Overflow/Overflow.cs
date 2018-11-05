using System;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Meadow.JsonRpc.Types;
using Meadow.JsonRpc.Client;
using Meadow.UnitTestTemplate;
using Meadow.Core.Utils;
using Meadow.Core.EthTypes;
using Meadow.Contract;
using Meadow.CoverageReport.Debugging;


namespace HoshoAudit
{
    [TestClass]
    public class OverflowTest : ContractTest
    {
        protected Overflow overflow;

        protected override async Task BeforeEach()
        {
            overflow = await Overflow.New(RpcClient);

            // Peform contract deployments and other test setup.
        }

        [TestMethod]
        public async Task Uint8()
        {
            var result = await overflow.uint8Overflow().CallAndTransact();
            Assert.AreEqual(result.Result, 0);
        }

        [TestMethod]
        public async Task Uint16()
        {
            var result = await overflow.uint16Overflow().CallAndTransact();
            Assert.AreEqual(result.Result, 0);
        }

        [TestMethod]
        public async Task Uint24()
        {
            var result = await overflow.uint24Overflow().CallAndTransact();
            Assert.AreEqual(result.Result, 0UL);
        }

        [TestMethod]
        public async Task Uint32()
        {
            var result = await overflow.uint32Overflow().CallAndTransact();
            Assert.AreEqual(result.Result, 0UL);
        }

        [TestMethod]
        public async Task Uint40()
        {
            var result = await overflow.uint40Overflow().CallAndTransact();
            Assert.AreEqual(result.Result, 0UL);
        }

        [TestMethod]
        public async Task Uint48()
        {
            var result = await overflow.uint48Overflow().CallAndTransact();
            Assert.AreEqual(result.Result, 0UL);
        }

        [TestMethod]
        public async Task Uint56()
        {
            var result = await overflow.uint56Overflow().CallAndTransact();
            Assert.AreEqual(result.Result, 0UL);
        }

        [TestMethod]
        public async Task Uint64()
        {
            var result = await overflow.uint64Overflow().CallAndTransact();
            Assert.AreEqual(result.Result, 0UL);
        }

        [TestMethod]
        public async Task Uint72()
        {
            var result = await overflow.uint72Overflow().CallAndTransact();
            Assert.AreEqual(result.Result, 0);
        }

        [TestMethod]
        public async Task Uint80()
        {
            var result = await overflow.uint80Overflow().CallAndTransact();
            Assert.AreEqual(result.Result, 0);
        }

        [TestMethod]
        public async Task Uint88()
        {
            var result = await overflow.uint88Overflow().CallAndTransact();
            Assert.AreEqual(result.Result, 0);
        }

        [TestMethod]
        public async Task Uint96()
        {
            var result = await overflow.uint96Overflow().CallAndTransact();
            Assert.AreEqual(result.Result, 0);
        }

        [TestMethod]
        public async Task Uint104()
        {
            var result = await overflow.uint104Overflow().CallAndTransact();
            Assert.AreEqual(result.Result, 0);
        }

        [TestMethod]
        public async Task Uint112()
        {
            var result = await overflow.uint112Overflow().CallAndTransact();
            Assert.AreEqual(result.Result, 0);
        }

        [TestMethod]
        public async Task Uint120()
        {
            var result = await overflow.uint120Overflow().CallAndTransact();
            Assert.AreEqual(result.Result, 0);
        }

        [TestMethod]
        public async Task Uint128()
        {
            var result = await overflow.uint128Overflow().CallAndTransact();
            Assert.AreEqual(result.Result, 0);
        }

        [TestMethod]
        public async Task Uint136()
        {
            var result = await overflow.uint136Overflow().CallAndTransact();
            Assert.AreEqual(result.Result, 0);
        }

        [TestMethod]
        public async Task Uint144()
        {
            var result = await overflow.uint144Overflow().CallAndTransact();
            Assert.AreEqual(result.Result, 0);
        }

        [TestMethod]
        public async Task Uint152()
        {
            var result = await overflow.uint152Overflow().CallAndTransact();
            Assert.AreEqual(result.Result, 0);
        }

        [TestMethod]
        public async Task Uint160()
        {
            var result = await overflow.uint160Overflow().CallAndTransact();
            Assert.AreEqual(result.Result, 0);
        }

        [TestMethod]
        public async Task Uint168()
        {
            var result = await overflow.uint168Overflow().CallAndTransact();
            Assert.AreEqual(result.Result, 0);
        }

        [TestMethod]
        public async Task Uint176()
        {
            var result = await overflow.uint176Overflow().CallAndTransact();
            Assert.AreEqual(result.Result, 0);
        }

        [TestMethod]
        public async Task Uint184()
        {
            var result = await overflow.uint184Overflow().CallAndTransact();
            Assert.AreEqual(result.Result, 0);
        }

        [TestMethod]
        public async Task Uint192()
        {
            var result = await overflow.uint192Overflow().CallAndTransact();
            Assert.AreEqual(result.Result, 0);
        }

        [TestMethod]
        public async Task Uint200()
        {
            var result = await overflow.uint200Overflow().CallAndTransact();
            Assert.AreEqual(result.Result, 0);
        }

        [TestMethod]
        public async Task Uint208()
        {
            var result = await overflow.uint208Overflow().CallAndTransact();
            Assert.AreEqual(result.Result, 0);
        }

        [TestMethod]
        public async Task Uint216()
        {
            var result = await overflow.uint216Overflow().CallAndTransact();
            Assert.AreEqual(result.Result, 0);
        }

        [TestMethod]
        public async Task Uint224()
        {
            var result = await overflow.uint224Overflow().CallAndTransact();
            Assert.AreEqual(result.Result, 0);
        }

        [TestMethod]
        public async Task Uint232()
        {
            var result = await overflow.uint232Overflow().CallAndTransact();
            Assert.AreEqual(result.Result, 0);
        }

        [TestMethod]
        public async Task Uint240()
        {
            var result = await overflow.uint240Overflow().CallAndTransact();
            Assert.AreEqual(result.Result, 0);
        }

        [TestMethod]
        public async Task Uint248()
        {
            var result = await overflow.uint248Overflow().CallAndTransact();
            Assert.AreEqual(result.Result, 0);
        }

        [TestMethod]
        public async Task Uint256()
        {
            var result = await overflow.uint256Overflow().CallAndTransact();
            Assert.AreEqual(result.Result, 0);
        }

        [TestMethod]
        public async Task Uint()
        {
            var result = await overflow.uintOverflow().CallAndTransact();
            Assert.AreEqual(result.Result, 0);
        }
    }
}