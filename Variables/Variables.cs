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
    public class VariablesTest : ContractTest
    {
        protected Variables variables;

        protected override async Task BeforeEach()
        {
            variables = await Variables.New(RpcClient);

        }

        [TestMethod]
        public async Task checkGlobalVariable()
        {
            var globalVar = await variables.globalVariable().Call();
            Assert.AreEqual(globalVar, "This is global");
        }

        [TestMethod]
        public async Task changeThenCheckGlobal()
        {
            await variables.changeGlobal();
            var globalVar = await variables.globalVariable().Call();
            Assert.AreEqual(globalVar, "This variable changed");

        }

        [TestMethod]
        public async Task changeGlobalVariable()
        {
            var globalVar = await variables.changeGlobal().Call();
            Assert.AreEqual(globalVar, "This variable changed");
        }

        [TestMethod]
        public async Task checkLocalVariable()
        {
            var localVar = await variables.localVariable("This is local").Call();
            Assert.AreEqual(localVar, "This is local");
        }


    }
}