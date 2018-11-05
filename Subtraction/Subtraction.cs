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
    public class Subtract2IntsTest : ContractTest
    {
        protected Subtract2Ints subtracting;

        protected override async Task BeforeEach()
        {
            subtracting = await Subtract2Ints.New(RpcClient);

            // Peform contract deployments and other test setup.
        }

        [TestMethod]
        public async Task Subtracting2IntsEvent()
        {
            var result = await subtracting.diffTwoIntegers(81, 3).FirstEventLog<Subtract2Ints.Subtracting>();
            Assert.AreEqual(result.difference, 78);
        }

        [TestMethod]
        public async Task SubtractingIntsCall()
        {
            var result = await subtracting.diffTwoIntegers(81, 3).Call();
            Assert.AreEqual(result, 78);
        }

        [TestMethod]
        public async Task Subtractinging2IntsCallAndTransact()
        {
            var result = await subtracting.diffTwoIntegers(81, 3).CallAndTransact();
            Assert.AreEqual(result.Result, 78);
            Assert.AreEqual(result.Receipt.FirstEventLog<Subtract2Ints.Subtracting>().difference, 78);
        }
    }
}

