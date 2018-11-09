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
    public class VersionTests : ContractTest
    {
        protected Version400 version400;
        protected Version410 version410;
        protected Version420 version420;
        protected Version421 version421;
        protected Version424 version424;

        protected override async Task BeforeEach()
        {
            version400 = await Version400.New(RpcClient);
            version410 = await Version410.New(RpcClient);
            version420 = await Version420.New(RpcClient);
            version421 = await Version421.New(421, RpcClient);
            version424 = await Version424.New(RpcClient);

        }

        [TestMethod]
        public async Task v400Throw_FromOwner_ReturnTrue()
        {
            await version400.v400Throw();
        }

        [TestMethod]
        public async Task v400Throw_FromOther_Throw()
        {
            await version400.v400Throw().ExpectRevertTransaction(new TransactionParams { From = Accounts[1] });
        }

        [TestMethod]
        public async Task v410_NotFromOwner_ReturnTrue()
        {
            await version410.v410Revert().SendTransaction(new TransactionParams { From = Accounts[75] });
        }

        [TestMethod]
        public async Task v410_FromOwner_ExpectRevert()
        {
            await version410.v410Revert().ExpectRevertTransaction();
        }

         [TestMethod]
        public async Task v420_ReturnBool_AssertResult()
        {
            var vsResult = await version420.v420().Call();
            Assert.AreEqual(true, vsResult);
        }
       
        [TestMethod]
        public async Task v421_ReturnVersionConstructor_AssertResult()
        {
            var vsResult = await version421.v421Returns().Call();
            Assert.AreEqual(421, vsResult);
        }
       
        [TestMethod]
        public async Task v424_ReturnBool_AssertResult()
        {
            var vsResult = await version424.v424Something(1, 2).Call();
            Assert.AreEqual(true, vsResult);
        }



    }
}