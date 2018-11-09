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
    public class DivisionTest : ContractTest
    {
        protected Division divide;

        protected override async Task BeforeEach()
        {
            divide = await Division.New(RpcClient);

        }

        [TestMethod]
        public async Task divTwoIntegers_DivideBy2AssertQuotient_EmitEvent()
        {
            var result = await divide.divTwoIntegers(156, 2).FirstEventLog<Div2Ints.Divide>();
            Assert.AreEqual(result.quotient, 78);
        }
       
        [TestMethod]
        public async Task divTwoIntegers_DivideBySame_AssertResult()
        {
            var result = await divide.divTwoIntegers(100, 100).FirstEventLog<Div2Ints.Divide>();
            Assert.AreEqual(result.quotient, 1);
        }

        [TestMethod]
        public async Task divTwoIntegers_DivideByZero_ExpectRevert()
        {
            await divide.divTwoIntegers(100, 0).ExpectRevertTransaction();
        }
    }
}