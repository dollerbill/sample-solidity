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
    public class AdditionTests : ContractTest
    {
        protected Addition adding;

        protected override async Task BeforeEach()
        {
            adding = await Addition.New(RpcClient);

            // Peform contract deployments and other test setup.
        }

        [TestMethod]
        public async Task addTwoIntegers_AssertSum_EmitEvent()
        {
            var result = await adding.addTwoIntegers(3, 75).FirstEventLog<Add2Ints.Adding>();
            Assert.AreEqual(result.sum, 78);
        }

        [TestMethod]
        public async Task addTwoIntegers_CallResult_AssertSum()
        {
            var result = await adding.addTwoIntegers(3, 75).Call();
            Assert.AreEqual(result, 78);
        }

        [TestMethod]
        public async Task addTwoIntegers_CallAndTransact_AssertSumFromEvent()
        {
            var result = await adding.addTwoIntegers(3, 75).CallAndTransact();
            Assert.AreEqual(result.Result, 78);
            Assert.AreEqual(result.Receipt.FirstEventLog<Add2Ints.Adding>().sum, 78);
        }
    }
}

