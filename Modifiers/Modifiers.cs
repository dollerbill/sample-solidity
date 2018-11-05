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
    public class ModifiersTests : ContractTest
    {
        protected Modifiers modify;

        protected override async Task BeforeEach()
        {
            modify = await Modifiers.New(RpcClient);
        }

        [TestMethod]
        public async Task modifierOwner()
        {
            await modify.isOwner();
        }

        [TestMethod]
        public async Task modifierOwner_Fail()
        {
            await modify.isOwner().ExpectRevertTransaction(new TransactionParams { From = Accounts[17]});
        }

        [TestMethod]
        public async Task notModifierOwner()
        {
            await modify.isNotOwner().SendTransaction(new TransactionParams { From  = Accounts[15]});
        }

        [TestMethod]
        public async Task notModifierOwner_Fail()
        {
            await modify.isNotOwner().ExpectRevertTransaction();
        }

        [TestMethod]
        public async Task isThisModifier()
        {
            await modify.isAddress(Accounts[15]).SendTransaction(new TransactionParams { From = Accounts[15] });
        }

        [TestMethod]
        public async Task isThisModifier_Fail()
        {
            await modify.isAddress(Accounts[15]).ExpectRevertTransaction();
        }

        [TestMethod]
        public async Task notThisModifier()
        {
            await modify.isNotAddress(Accounts[15]);
        }

        [TestMethod]
        public async Task notThisModifier_Fail()
        {
            await modify.isNotAddress(Accounts[15]).ExpectRevertTransaction(new TransactionParams { From = Accounts[15] });
        }

        [TestMethod]
        public async Task multipleModifiers()
        {
            await modify.bothMods(Accounts[0]);
        }
    }
}

