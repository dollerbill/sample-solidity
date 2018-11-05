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
    public class Div2IntsTest : ContractTest
    {
        protected Div2Ints divide;

        protected override async Task BeforeEach()
        {
            divide = await Div2Ints.New(RpcClient);

        }

        [TestMethod]
        public async Task Div2IntsEvent()
        {
            var result = await divide.divTwoIntegers(156, 2).FirstEventLog<Div2Ints.Divide>();
            Assert.AreEqual(result.quotient, 78);
        }

        [TestMethod]
        public async Task DivByZero()
        {
            await divide.divTwoIntegers(100, 0).ExpectRevertTransaction();
        }
    }
}