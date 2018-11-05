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
    public class ExternalTests : ContractTest
    {
        protected External ext;

        protected override async Task BeforeEach()
        {
            ext = await External.New(RpcClient);
        }

        [TestMethod]
        public async Task extStringReturn()
        {
            var result = await ext.externalFunction().CallAndTransact();
            Assert.AreEqual(result.Result, "Hello");
        }
    }

    [TestClass]
    public class InternalTests : ContractTest
    {
        protected Internal inte;

        protected override async Task BeforeEach()
        {
            inte = await Internal.New(RpcClient);
        }

        [TestMethod]
        public async Task intStringReturn()
        {
            var result = await inte.callableFunction().CallAndTransact();
            Assert.AreEqual(result.Result, "Hello");
        }
    }

    [TestClass]
    public class PublicTests : ContractTest
    {
        protected Public pub;

        protected override async Task BeforeEach()
        {
            pub = await Public.New(RpcClient);
        }

        [TestMethod]
        public async Task trueBoolReturnTrue()
        {
            var result = await pub.publicFunction().CallAndTransact();
            Assert.AreEqual(result.Result, "Hello");
        }
    }

    [TestClass]
    public class PrivateTests : ContractTest
    {
        protected Private priv;

        protected override async Task BeforeEach()
        {
            priv = await Private.New(RpcClient);
        }

        [TestMethod]
        public async Task privateFunction()
        {
            var result = await priv.callableFunction().CallAndTransact();
            Assert.AreEqual(result.Result, "Hello");
        }
    }
}

