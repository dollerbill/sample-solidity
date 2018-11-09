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
    public class TrueBooleanTests : ContractTest
    {
        protected TrueBoolean trueBool;

        protected override async Task BeforeEach()
        {
            trueBool = await TrueBoolean.New(RpcClient);
        }

        [TestMethod]
        public async Task isTruee_AmountsEqual_AssertTrue()
        {
            var result = await trueBool.isTrue(1, 1).CallAndTransact();
            Assert.AreEqual(result.Result, true);
        }

        [TestMethod]
        public async Task isTrue_AmountsNotEqual_AssertFalse()
        {
            var result = await trueBool.isTrue(5, 2).CallAndTransact();
            Assert.AreEqual(result.Result, false);
        }
    }

    [TestClass]
    public class FalseBooleanTests : ContractTest
    {
        protected FalseBoolean falseBool;

        protected override async Task BeforeEach()
        {
            falseBool = await FalseBoolean.New(RpcClient);
        }

        [TestMethod]
        public async Task isFalse_AmountsNotEqual_AssertFalse()
        {
            var result = await falseBool.isFalse(1, 2).CallAndTransact();
            Assert.AreEqual(result.Result, false);
        }

        [TestMethod]
        public async Task isFalse_AmountsEqual_AssertTrue()
        {
            var result = await falseBool.isFalse(2, 2).CallAndTransact();
            Assert.AreEqual(result.Result, true);
        }
    }
}

