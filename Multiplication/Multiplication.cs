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
    public class Mul2IntsTest : ContractTest
    {
        protected Mul2Ints multiply;

        protected override async Task BeforeEach()
        {
            multiply = await Mul2Ints.New(RpcClient);

        }

        [TestMethod]
        public async Task Mul2IntsEvent()
        {
            var result = await multiply.mulTwoIntegers(39, 2).FirstEventLog<Mul2Ints.Multiply>();
            Assert.AreEqual(result.product, 78);
        }

        [TestMethod]
        public async Task MulByZero()
        {
            var result = await multiply.mulTwoIntegers(100, 0).FirstEventLog<Mul2Ints.Multiply>();
            Assert.AreEqual(result.product, 0);
        }
    }
}