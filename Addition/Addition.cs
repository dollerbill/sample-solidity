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
    public class Add2IntsTest : ContractTest
    {
        protected Add2Ints adding;

        protected override async Task BeforeEach()
        {
            adding = await Add2Ints.New(RpcClient);

            // Peform contract deployments and other test setup.
        }

        [TestMethod]
        public async Task Adding2IntsEvent()
        {
            var result = await adding.addTwoIntegers(3, 75).FirstEventLog<Add2Ints.Adding>();
            Assert.AreEqual(result.sum, 78);
        }

        [TestMethod]
        public async Task Adding2IntsCall()
        {
            var result = await adding.addTwoIntegers(3, 75).Call();
            Assert.AreEqual(result, 78);
        }

        [TestMethod]
        public async Task Adding2IntsCallAndTransact()
        {
            var result = await adding.addTwoIntegers(3, 75).CallAndTransact();
            Assert.AreEqual(result.Result, 78);
            Assert.AreEqual(result.Receipt.FirstEventLog<Add2Ints.Adding>().sum, 78);
        }
    }
}

